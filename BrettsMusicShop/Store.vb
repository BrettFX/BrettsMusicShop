Public Class frmStore

    '6% sales tax
    Const TAX_RATE As Double = 0.06

    'Format string to separate the item names and prices in the cart (receipt)
    Const RECEIPT_HEADER_FMT As String = "{0, -10}{1, -20}{2, -20}{3, 20}"
    Const RECEIPT_BODY_FMT As String = "{0, -10}{1, -20}{2, -30:C}{3, 20:C}"

    'Guest information
    Const GUEST_NAME As String = "Guest"
    Const GUEST_ID As String = "000000"

    'Row index to keep track of the current inventory item from the database
    Dim rowIndex As Integer

    'Keep track of the total number of items added to the cart
    Dim numItems As Integer

    'Keep track of the subtotal as the cart expands
    Dim subtotal As Double

    'Stores the current user's name
    Dim currentUserName As String = ""

    'Store the current user's ID
    Dim currentUserID As String = ""

    'Keep track of the previously checked sorting order to uncheck it when another sort ordered is selected
    Dim previousSortMnuItem As ToolStripMenuItem

    Private Sub frmStore_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Initialize previousSortMnuItem to mnuAllItruments
        previousSortMnuItem = DirectCast(mnuAllInstruments, ToolStripMenuItem)

        'Initialize the cart with column headings
        lstCart.Items.Add(String.Format(RECEIPT_HEADER_FMT, "SKU", "NAME", "UNIT PRICE", "PRICE"))

        'Set the current user name and id from the sign-in and sign-up pages
        'Since one form's cusName and cusID will always be blank, concatenating both from each form will result
        'in one cusName and one cusID
        currentUserName = frmCustomerSignIn.cusName & frmSignUp.cusName
        currentUserID = frmCustomerSignIn.cusID & frmSignUp.cusID

        If (currentUserName = "" And currentUserID = "") Then
            currentUserName = GUEST_NAME
            currentUserID = GUEST_ID
            MessageBox.Show("You must sign up or sign in to add items to the cart and purchase them!" & vbCrLf &
                            "However, feel free to browse our selection of instruments.")
        End If

        'Create a greating for the customer on the forms title
        Me.Text = "Welcome to Brett's Music Shop " & currentUserName & " (" & currentUserID & ")" & "!"

        'Load everything from the inventory table from the database
        UpdateGrid("Select " & frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & " From " & frmDatabaseManager.INVENTORY_TABLE_NAME)

        numItems = 0
        rowIndex = 0

        InitializeCartDetails()

        UpdateInventoryStock(Me)
    End Sub

    'Update the grid by applying the specified sort filter
    Sub UpdateGrid(sqlStr As String)
        Dim dt As New DataTable()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()
        dgvInventory.DataSource = dt
    End Sub

    'Close the form, initialize the customer ID and customer name fields, and navigate back to the main form
    Private Sub frmStore_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Initialize the cusIDs and cusNames
        frmSignUp.cusID = ""
        frmSignUp.cusName = ""
        frmCustomerSignIn.cusID = ""
        frmCustomerSignIn.cusName = ""

        frmBrettsMusicShop.Show()
    End Sub

    'Confirm that the customer wants to sign out and navigate back to the main form
    Private Sub menuItemSignOut_Click(sender As Object, e As EventArgs) Handles menuItemSignOut.Click
        'Determine if the user really wants to log out
        Dim shouldClose As Boolean
        shouldClose = MessageBox.Show("Are you sure you would like to log out?", "Log out?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)

        If (shouldClose) Then
            Close()
            frmBrettsMusicShop.Show()
        End If
    End Sub

    'Displays instructions on how to navigate through and use the store
    Private Sub menuItemInstructions_Click(sender As Object, e As EventArgs) Handles menuItemInstructions.Click
        MessageBox.Show("Welcome to Brett's Music Shop " & currentUserName & " (" & currentUserID & ")" & "!" & vbCrLf & vbCrLf &
                        "Instructions:" & vbCrLf & vbCrLf &
                        "Select any instrument from the groups of intruments at the bottom of the window." & vbCrLf & vbCrLf &
                        "The information for the item that you select will be displayed to the left of the cart." & vbCrLf & vbCrLf &
                        "Add the item to your order by clicking the 'Add to Cart' button. The item will be added to your cart" & vbCrLf & vbCrLf &
                        "When you are satisfied with your order, confirm your purchase by clicking the 'Purchase' button right below the cart.")
    End Sub

    'Handles selecting individual elements in the datagrid view
    Private Sub dgvInventory_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellEnter

        'Get the row index from the data grid
        Dim gridIndex As Integer = e.RowIndex

        Dim sqlStr As String = "select * from " & frmDatabaseManager.INVENTORY_TABLE_NAME

        Dim dt As New DataTable()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)

        'Only allow the cells in the data grid table to be selected (not the column header)
        If (gridIndex >= 0) Then
            Dim selection As String = dgvInventory.Rows(gridIndex).Cells(0).Value.ToString()

            For i As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(i)(frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD).Equals(selection)) Then

                    'Get the rowIndex location of the selected item from the database
                    rowIndex = i

                    'Exit the for loop by forcing end of condition
                    i = dt.Rows.Count - 1
                End If
            Next

            ' Dim price As Double = dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_ITEM_PRICE)

            'Display the selected item's information
            txtItemSKU.Text = dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_SKU_FIELD)
            txtItemCategory.Text = dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD)
            txtItemName.Text = dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD)
            txtItemPrice.Text = CDbl(dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_ITEM_PRICE_FIELD)).ToString("C")
            txtItemWeight.Text = CDbl(dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_ITEM_WEIGHT_FIELD)).ToString("F") & " lbs"
            txtOnHand.Text = dt.Rows(rowIndex)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD)

            'Set the minimum and maximum quantity amounts 
            nudQty.Minimum = 1
            nudQty.Maximum = CInt(txtOnHand.Text)

            'Only allow purchases if not guest
            If (currentUserName <> GUEST_NAME) Then
                btnAddToCart.Enabled = True
            End If
        End If

        dataAdapter.Dispose()
    End Sub

    'Updates the quantity of inventory on hand once an instrument has been purchased
    Private Sub UpdateInventoryStock(sender As Object)
        Dim sqlStr As String = "Select " & frmDatabaseManager.INVENTORY_SKU_FIELD & ", " &
                                           frmDatabaseManager.INVENTORY_ITEM_PRICE_FIELD & ", " &
                                           frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD & ", " &
                                           frmDatabaseManager.INVENTORY_INITIAL_QTY_ON_HAND_FIELD &
                                " From " & frmDatabaseManager.INVENTORY_TABLE_NAME

        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)

        Dim dt As New DataTable
        dt.Clear()
        dataAdapter.Fill(dt)

        Dim commandBuilder As New OleDb.OleDbCommandBuilder(dataAdapter)

        Dim currentInventoryStock As Integer = 0

        'Variable for returned items
        Dim initQty As Integer = 0
        Dim currQty As Integer = 0

        Dim qtyReturned As Integer = 0

        Dim unitPrice As Double = 0

        Dim tax As Double = 0.0, total As Double = 0.0

        If (sender.Equals(btnAddToCart)) Then

            Console.WriteLine("Updating inventory stock: current inventory stock.")

            'Find the item that was added to the cart
            For i As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(i)(frmDatabaseManager.INVENTORY_SKU_FIELD).Equals(txtItemSKU.Text)) Then
                    currentInventoryStock = CInt(dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD))

                    'Decrement an instrument from the currentInventoryStock
                    currentInventoryStock -= CInt(nudQty.Text)

                    'Go back in and update the field
                    dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD) = currentInventoryStock.ToString()

                    'Update the dataAdapter
                    dataAdapter.Update(dt)

                    'Break out of the loop
                    i = dt.Rows.Count - 1
                End If
            Next
        ElseIf (sender.Equals(btnPurchase)) Then
            'Make the inventory stock official by setting the initial inventory to the current inventory
            Console.WriteLine("Updating inventory stock: initial inventory stock.")

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)(frmDatabaseManager.INVENTORY_INITIAL_QTY_ON_HAND_FIELD) = dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD)
                dataAdapter.Update(dt)
            Next

            'Initialize numItems
            numItems = 0

        ElseIf (sender.Equals(btnRemoveItem)) Then
            'Otherwise if the removeItem button was clicked, update the inventory and update the cart information variables
            Console.WriteLine("Updating inventory stock: setting current inventory stock to initial inventory stock.")

            Dim cartSelection As String = lstCart.SelectedItem.ToString()

            'Get the qtyReturned that is between the parenthesis in the cart for each item
            qtyReturned = CInt(cartSelection.Split("(")(1).Split(")")(0))

            'Get the item SKU (first six characters)
            Dim itemSKU As String = cartSelection.Substring(0, 6)

            'Update the inventory stock and cart information variables
            For i As Integer = 0 To dt.Rows.Count - 1
                If (dt.Rows(i)(frmDatabaseManager.INVENTORY_SKU_FIELD) = itemSKU) Then

                    'Determine if their is a difference between the initial and current inventory
                    If (dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD) <> dt.Rows(i)(frmDatabaseManager.INVENTORY_INITIAL_QTY_ON_HAND_FIELD)) Then

                        'Get and determine new total
                        total = CDbl(txtTotal.Text)

                        currQty = CInt(dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD))

                        unitPrice = CDbl(dt.Rows(i)(frmDatabaseManager.INVENTORY_ITEM_PRICE_FIELD))

                        numItems -= qtyReturned
                        txtNumItems.Text = numItems.ToString()

                        'Get new subtotal
                        subtotal -= unitPrice * qtyReturned
                        txtSubTotal.Text = subtotal.ToString("C")

                        'Get the current tax
                        tax = (unitPrice * qtyReturned) * TAX_RATE

                        total -= ((unitPrice * qtyReturned) + tax)
                        txtTotal.Text = total.ToString("C")

                        'Calculate the new tax
                        tax = subtotal * TAX_RATE
                        txtTax.Text = tax.ToString("C")

                        'Add the quanity returned back to the current inventory stock
                        dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD) = CStr(currQty + qtyReturned)
                        dataAdapter.Update(dt)

                        'Break out of the loop
                        i = dt.Rows.Count - 1
                    End If
                End If
            Next
        Else
            'Otherwise the program was exited before commiting to a purchase and the inventory stocks should be readjusted to what they 
            'were previously
            Console.WriteLine("Updating inventory stock: setting current inventory stock to initial inventory stock.")

            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)(frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD) = dt.Rows(i)(frmDatabaseManager.INVENTORY_INITIAL_QTY_ON_HAND_FIELD)
                dataAdapter.Update(dt)
            Next
        End If

        dataAdapter.Dispose()
    End Sub

    'Add current item to the customer's cart
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        'Determine the total of the transaction after tax
        Dim total As Double = 0.0

        'Determine the tax on the trasactioon
        Dim tax As Double = 0.0

        'Determine the cost multiplied by the quantity (not just unit price)
        Dim costWithQty As Double = CInt(nudQty.Text) * CDbl(txtItemPrice.Text)

        lstCart.Items.Add(String.Format(RECEIPT_BODY_FMT, txtItemSKU.Text, txtItemName.Text & " (" & nudQty.Text & ")", txtItemPrice.Text, costWithQty.ToString("C")))

        'Update the total number of items added to the order
        numItems += CInt(nudQty.Text)

        'Update the total
        subtotal += costWithQty

        tax = subtotal * TAX_RATE

        total = subtotal + tax

        txtNumItems.Text = numItems.ToString()
        txtSubTotal.Text = subtotal.ToString("C")
        txtTax.Text = tax.ToString("C")
        txtTotal.Text = total.ToString("C")

        'Enable the purchase button now that the cart is not empty
        btnPurchase.Enabled = True

        UpdateInventoryStock(btnAddToCart)

        'Initialize item details fields
        nudQty.Minimum = 0
        nudQty.Maximum = 0
        btnAddToCart.Enabled = False

        dgvInventory.Focus()
    End Sub

    'Add all the items in the customer's cart to the transactions table of the database
    'Decrements the total number of units on hand for the times that were purchased
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim sqlStr As String = "select * from " & frmDatabaseManager.TRANSACTIONS_TABLE_NAME
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        Dim dt As New DataTable()

        dt.Clear()
        dataAdapter.Fill(dt)

        Dim rw As DataRow
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(dataAdapter)

        'Add a new row to the transactions table
        'ERROR (12/3/16): Doesn't recognize the fields from the Transaction table
        rw = dt.NewRow
        rw.Item(frmDatabaseManager.CUSTOMER_ID_FIELD) = currentUserID
        rw.Item(frmDatabaseManager.CUSTOMER_NAME_FIELD) = currentUserName
        rw.Item(frmDatabaseManager.TRANSACTION_DATE_FIELD) = DateTime.Now.ToString("d") 'mm/dd/yyyy
        rw.Item(frmDatabaseManager.TRANSACTION_TIME_FIELD) = DateTime.Now.ToString("T") 'hh:mm:ss AM/PM
        rw.Item(frmDatabaseManager.TRANSACTION_SUBTOTAL_FIELD) = txtSubTotal.Text
        rw.Item(frmDatabaseManager.TRANSACTION_TAX_FIELD) = txtTax.Text
        rw.Item(frmDatabaseManager.TRANSACTION_TOTAL_FIELD) = txtTotal.Text

        'Add the row to the database
        Try
            dt.Rows.Add(rw)
            dataAdapter.Update(dt)
            dataAdapter.Dispose()

            'Initialize cart
            lstCart.Items.Clear()
            InitializeCartDetails()

            btnPurchase.Enabled = False

            'Finalize and set the new inventory stock
            UpdateInventoryStock(btnPurchase)

            'Initialize the cart with column headings
            lstCart.Items.Add(String.Format(RECEIPT_HEADER_FMT, "SKU", "NAME", "UNIT PRICE", "PRICE"))

            MessageBox.Show("Thank you for your purchase " & currentUserName & "!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Initialize the cart quantity, subtotal, tax, and total fields
    Sub InitializeCartDetails()
        subtotal = 0.0
        txtNumItems.Text = "0"
        txtSubTotal.Text = 0.ToString("C")
        txtTax.Text = 0.ToString("C")
        txtTotal.Text = 0.ToString("C")
    End Sub

    'Handles checking various sorted order states
    Private Sub mnuSortOrder_Click(sender As Object, e As EventArgs) Handles mnuAllInstruments.Click, mnuPercussion.Click,
            mnuBrass.Click, mnuWoodwind.Click, mnuStrings.Click

        'New sqlStr to be used differently for each sort order
        Dim sqlStr As String = ""

        Dim menuItem As ToolStripMenuItem

        If TypeOf sender Is ToolStripMenuItem Then
            menuItem = DirectCast(sender, ToolStripMenuItem)

            'When the previousSortMnuItem is equal to the current menu item clicked Then
            'Uncheck the previousSortMnuItem
            If Not (previousSortMnuItem.Equals(menuItem)) Then
                previousSortMnuItem.Checked = False
            End If

            'Determine which menuItem was clicked and update the data grid accordingly
            Select Case menuItem.Text
                'Show only string instruments
                Case "String Instruments"
                    sqlStr = "Select " & frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & ", " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD &
                            " From " & frmDatabaseManager.INVENTORY_TABLE_NAME &
                            " Where " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD & "= 'Strings'"

                    UpdateGrid(sqlStr)

                'Show only brass instruments
                Case "Brass Instruments"
                    sqlStr = "Select " & frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & ", " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD &
                            " From " & frmDatabaseManager.INVENTORY_TABLE_NAME &
                            " Where " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD & "= 'Brass'"

                    UpdateGrid(sqlStr)

                'Show only woodwind instruments
                Case "Woodwind Instruments"
                    sqlStr = "Select " & frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & ", " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD &
                            " From " & frmDatabaseManager.INVENTORY_TABLE_NAME &
                            " Where " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD & "= 'Woodwind'"

                    UpdateGrid(sqlStr)

                'Show only percussion instruments
                Case "Percussion Instruments"
                    sqlStr = "Select " & frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & ", " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD &
                            " From " & frmDatabaseManager.INVENTORY_TABLE_NAME &
                            " Where " & frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD & "= 'Percussion'"

                    UpdateGrid(sqlStr)

                'Show all instruments
                Case "All Instruments"
                    UpdateGrid("Select " & frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & " From " & frmDatabaseManager.INVENTORY_TABLE_NAME)
            End Select

            'Check the menu item that was selected
            menuItem.Checked = True

            previousSortMnuItem = menuItem
        End If
    End Sub

    'Get the selected item from the cart
    Private Sub lstCart_Click(sender As Object, e As EventArgs) Handles lstCart.Click
        Dim cartSelection As String

        'Prevent error from clicking on nothing within the list box
        If Not IsNothing(lstCart.SelectedItem) Then
            cartSelection = lstCart.SelectedItem.ToString()

            'Only let the cusotmer delete entries, not the row header
            btnRemoveItem.Enabled = cartSelection.Contains("$")
        End If
    End Sub

    'Removes the selected item from the cart
    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        'Replenish the inventory
        UpdateInventoryStock(btnRemoveItem)

        lstCart.Items.Remove(lstCart.SelectedItem)

        btnRemoveItem.Enabled = False

        dgvInventory.Focus()

        'Disable the purchase button when all the items have been removed from the cart
        If (lstCart.Items.Count <= 1) Then
            btnPurchase.Enabled = False

            'To ensure there are no rounding errors, initialize cart details
            InitializeCartDetails()
        End If
    End Sub
End Class