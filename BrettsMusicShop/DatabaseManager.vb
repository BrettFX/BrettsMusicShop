Public Class frmDatabaseManager
    'Field names within the Customer Table in the Database
    Public Const CUSTOMER_ID_FIELD As String = "CustomerID"
    Public Const CUSTOMER_NAME_FIELD As String = "CustomerName"
    Public Const CUSTOMER_EMAIL_FIELD As String = "CustomerEmail"
    Public Const CUSTOMER_PASSWORD_FIELD As String = "CustomerPassword"
    Public Const CUSTOMER_STATE_FIELD As String = "CustomerState"
    Public Const CUSTOMER_ZIP_FIELD As String = "CustomerZipcode"
    Public Const CUSTOMER_PHONE_FIELD As String = "CustomerPhone"
    Public Const CUSTOMER_BIRTHDAY_FIELD As String = "CustomerDOB"
    Public Const CUSTOMER_GENDER_FIELD As String = "CustomerGender"

    'Field names within the Inventory Tabe in the database
    Public Const INVENTORY_SKU_FIELD As String = "SKU"
    Public Const INVENTORY_ITEM_CATEGORY_FIELD As String = "ItemCategory"
    Public Const INVENTORY_ITEM_NAME_FIELD As String = "ItemName"
    Public Const INVENTORY_ITEM_PRICE_FIELD As String = "ItemPrice"
    Public Const INVENTORY_ITEM_WEIGHT_FIELD As String = "ItemWeight"
    Public Const INVENTORY_QTY_ON_HAND_FIELD As String = "QtyOnHand"
    Public Const INVENTORY_INITIAL_QTY_ON_HAND_FIELD As String = "InitialQtyOnHand"

    'Field names within the Transactions Table in the database
    Public Const TRANSACTION_DATE_FIELD As String = "TransactionDate"
    Public Const TRANSACTION_TIME_FIELD As String = "TransactionTime"
    Public Const TRANSACTION_SUBTOTAL_FIELD As String = "TransactionSubtotal"
    Public Const TRANSACTION_TAX_FIELD As String = "TransactionTax"
    Public Const TRANSACTION_TOTAL_FIELD As String = "TransactionTotal"

    'Database file path used to establish the connection for dataAdapters
    Public Const DATABASE_FILE_PATH As String = "Res/BrettsMusicShopDatabase.mdb"

    'Database connection string used to establish all connections to Brett's Music Shop Database
    Public Const CONN_STR As String = "Provider = microsoft.jet.oledb.4.0;" & "data source = " & DATABASE_FILE_PATH

    'Database table names
    Public Const CUSTOMER_TABLE_NAME As String = "Customers"
    Public Const INVENTORY_TABLE_NAME As String = "Inventory"
    Public Const TOTALS_TABLE_NAME As String = "Totals"
    Public Const TRANSACTIONS_TABLE_NAME As String = "Transactions"

    Dim dt As New DataTable()
    Dim rowIndex As Integer = 0

    Dim sqlstr As String = "select * from " & CUSTOMER_TABLE_NAME
    Dim dataAdapter As OleDb.OleDbDataAdapter

    'A string to store the rowIndex of multiple customers that are found and fulfill the same search criteria (i.e. share same zipcode)
    Dim customersFound As String

    'Integer to keep track of the customer that is currently displayed
    Dim currentCustomerIndex As Integer

    'Count the number of customers found in a search
    Dim numCustomers As Integer

    'Initialize variable when the form is loaded
    Private Sub frmDatabaseManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFilter.Text = "None"

        'Initialize search query based on current filter
        HandleFilter(cboFilter.Text)

        btnDelete.Visible = False

        dt.Clear()

        dataAdapter = New OleDb.OleDbDataAdapter(sqlstr, CONN_STR)

        dataAdapter.Fill(dt)

        customersFound = ""
        currentCustomerIndex = 0
        numCustomers = 0
    End Sub

    'Sign out once the customer has confirmed that they would like to sign out
    Private Sub menuItemSignOut_Click(sender As Object, e As EventArgs) Handles menuItemSignOut.Click
        'Determine choice
        Dim logOutConfirmed As Boolean
        logOutConfirmed = MessageBox.Show("Are you sure you would like to log out?", "Log out?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)

        'Confirm with user really wants to log out
        If (logOutConfirmed) Then
            Close()
        End If
    End Sub

    'Close the form and go back to the main form; dispose the dataAdapter and free memory
    Private Sub frmDatabaseManager_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Release memory allocated by dataAdapter
        dataAdapter.Dispose()

        frmBrettsMusicShop.Show()
    End Sub

    'Search through BrettsMusicShopDatabase using specified search filter and find the entry or entries
    'matching the search criteria
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim find As String
        Dim found As Boolean = False

        btnNext.Enabled = False
        btnPrevious.Enabled = False

        'Initialize numCustomers counter
        numCustomers = 0

        Dim customerField As String = ""

        find = mtbSearch.Text

        'Initialize customersFound
        customersFound = ""

        'Get the trimmed version of the search filter (matches the field names of the Customers Table)
        customerField = cboFilter.Text.Replace(" ", "")

        'Only search if there is a search filter and the search filter is not to display all customers from the database
        If (customerField <> "" And Not customerField.Contains("None")) Then

            'Query the database and find the item in question based on the search filter
            For i As Integer = 0 To (dt.Rows.Count - 1)
                If CStr(dt.Rows(i)(customerField)).Contains(find) Or CStr(dt.Rows(i)(customerField)).Contains(find.ToUpper) Then
                    found = True

                    numCustomers += 1

                    'Log the indecies of the customersFound
                    customersFound += i.ToString() + ","

                    rowIndex = i
                End If
            Next

            If Not found Then
                MsgBox("Cannot find " & customerField & ": " & find & " in the database", MsgBoxStyle.Critical)
            Else
                Console.WriteLine("Customer(s) matching search criteria found at: " & customersFound)

                'Enable the next and previous buttons to indicate that there is more than one customer found
                If (numCustomers > 1) Then
                    btnNext.Enabled = True
                    btnPrevious.Enabled = True
                End If

                'Display the number of customers found in the search
                txtCustomersFound.Text = numCustomers.ToString()

                'Display the customer(s) information
                'Ensure that if there are multiple customers found in a search query, the first one will be the one displayed
                'Until the user clicks the next button
                DisplayMemberInfo(CInt(customersFound.Split(",")(0)))

                'Show the buttons to give the user the option to manipulate the member's account
                ToggleButtonVisibilities(True)
            End If

            'Display all the customers in the database if the user has placed no filter on the search query
        ElseIf cboFilter.Text.Contains("None") Then
            findAll()
        End If
    End Sub

    'Find all the customers in the database and display their information
    Sub findAll()
        Dim found As Boolean = False

        For i As Integer = 0 To (dt.Rows.Count - 1)
            If dt.Rows(i)(CUSTOMER_ID_FIELD) > 0 Then
                found = True

                numCustomers += 1

                'Log the indecies of the customersFound
                customersFound += i.ToString() + ","

                rowIndex = i
            End If
        Next

        'Customers will not be found only if there are none in the database (all members' ID is greater than 0)
        If Not found Then
            MsgBox("There are no customers in the database")
        Else
            Console.WriteLine("Customer(s) matching search criteria found at: " & customersFound)

            'Enable the next button to indicate that there is more than one customer found
            If (numCustomers > 1) Then
                btnNext.Enabled = True
                btnPrevious.Enabled = True
            End If

            'Display the number of customers found in the search
            txtCustomersFound.Text = numCustomers.ToString()

            'Display the customer(s) information
            'Ensure that if there are multiple customers found in a search query, the first one will be the one displayed
            'Until the user clicks the next button
            DisplayMemberInfo(CInt(customersFound.Split(",")(0)))

            'Show the buttons to give the user the option to manipulate the member's account
            ToggleButtonVisibilities(True)
        End If
    End Sub

    'Displays the information of the member in question
    Sub DisplayMemberInfo(index As Integer)
        txtID.Text = CStr(dt.Rows(index)(CUSTOMER_ID_FIELD))
        txtName.Text = CStr(dt.Rows(index)(CUSTOMER_NAME_FIELD))
        txtEmail.Text = CStr(dt.Rows(index)(CUSTOMER_EMAIL_FIELD))
        txtPassword.Text = CStr(dt.Rows(index)(CUSTOMER_PASSWORD_FIELD))
        txtState.Text = CStr(dt.Rows(index)(CUSTOMER_STATE_FIELD))
        txtZipcode.Text = CStr(dt.Rows(index)(CUSTOMER_ZIP_FIELD))
        txtPhone.Text = CStr(dt.Rows(index)(CUSTOMER_PHONE_FIELD))
        txtBirth.Text = CStr(dt.Rows(index)(CUSTOMER_BIRTHDAY_FIELD))
        txtGender.Text = CStr(dt.Rows(index)(CUSTOMER_GENDER_FIELD))
    End Sub

    'Traverse forward through the customers that have been found matching the search criteria
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Determine which customer is already displayed by comparing to ID
        Dim cusID As Integer = CInt(txtID.Text)
        Dim cusToDisplay As Integer = 0

        Do While (dt.Rows(CInt(customersFound.Split(",")(currentCustomerIndex)))(CUSTOMER_ID_FIELD) = txtID.Text)

            currentCustomerIndex += 1

            If (currentCustomerIndex > numCustomers - 1) Then
                currentCustomerIndex = 0
            End If

            Console.WriteLine("currentCustomerIndex: " & currentCustomerIndex)
        Loop

        DisplayMemberInfo(CInt(customersFound.Split(",")(currentCustomerIndex)))
    End Sub

    'Traverse backward through the customers that have been found matching the search criteria
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'Determine which customer is already displayed by comparing to ID
        Dim cusID As Integer = CInt(txtID.Text)
        Dim cusToDisplay As Integer = 0

        Do While (dt.Rows(CInt(customersFound.Split(",")(currentCustomerIndex)))(CUSTOMER_ID_FIELD) = txtID.Text)

            currentCustomerIndex -= 1

            If (currentCustomerIndex < 0) Then
                currentCustomerIndex = numCustomers - 1
            End If

            Console.WriteLine("currentCustomerIndex: " & currentCustomerIndex)
        Loop

        DisplayMemberInfo(CInt(customersFound.Split(",")(currentCustomerIndex)))
    End Sub

    'Deletes the member that is currently being displayed
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deletionConfirmed As Boolean

        Dim commandBuilder As New OleDb.OleDbCommandBuilder(dataAdapter)

        'Get confirmation from the user if they really want to delete the member
        deletionConfirmed = MessageBox.Show("Are you sure you would like to delete this member?", "Confirm Deletion", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)

        'Only delete the member if the user confirms the deletion
        If (deletionConfirmed) Then
            Try
                'Delete the current customer by using the ID as a referece of which customer to delete from the database
                For i As Integer = 0 To (dt.Rows.Count - 1)
                    If (CStr(dt.Rows(i)(CUSTOMER_ID_FIELD).Equals(txtID.Text))) Then
                        dt.Rows(i).Delete()
                        Exit For
                    End If
                Next

                'Update the table in BrettsMusicShopDatabase
                dataAdapter.Update(dt)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Console.WriteLine("Deleted customer at index: " & currentCustomerIndex)

            'Notify the user that the member has been deleted
            MsgBox(txtName.Text & " has been successfully removed from the database.", MsgBoxStyle.Information, "Member Deleted")

            'Store the current search in a variable to research
            Dim search As String = mtbSearch.Text

            'Initialize text fields and search data
            Initialize()

            'Hide the buttons
            ToggleButtonVisibilities(False)

            'Retry the previous search. If there are still customers left matching the previous search criteria
            'They will appear. Else, an appropriate message will be displayed notifying there are no customers matching
            'the query
            AutoSearch(search)
        End If
    End Sub

    'Used to research a previous search when the user has deleted a customer
    Private Sub AutoSearch(previousSearch As String)
        mtbSearch.Text = previousSearch
        btnSearch.PerformClick()
    End Sub

    'Toggle the visibility of each of the buttons linked to the member that has been found
    Sub ToggleButtonVisibilities(b As Boolean)
        btnDelete.Visible = b
        btnClear.Visible = b
        btnPrevious.Visible = b
        btnNext.Visible = b
    End Sub

    'Initializes components when necessary
    Sub Initialize()
        'Initialize the text fields for the members information back to blank
        txtID.Text = ""
        txtName.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtState.Text = ""
        txtZipcode.Text = ""
        txtPhone.Text = ""
        txtBirth.Text = ""
        txtGender.Text = ""
        mtbSearch.Text = ""

        'Initialize query information variables
        customersFound = ""
        txtCustomersFound.Text = ""
        currentCustomerIndex = 0
        numCustomers = 0

        'Give the search box focus
        mtbSearch.Focus()
    End Sub

    'Initializes the search based on the filter provided
    Private Sub HandleFilter(filter As String)
        mtbSearch.Enabled = True

        Select Case filter
            Case "None"
                btnSearch.Text = "Find All"
                mtbSearch.Text = ""
                mtbSearch.Mask = ""
                mtbSearch.Enabled = False
            Case "Customer ID"
                mtbSearch.Mask = "00000"
            Case "Customer Name"
                mtbSearch.Mask = ""
            Case "Customer State"
                mtbSearch.Mask = "LL"
            Case "Customer Zipcode"
                mtbSearch.Mask = "00000"
            Case "Customer Phone"
                mtbSearch.Mask = "(999) 000-0000"
            Case "Customer Gender"
                mtbSearch.Mask = ""
            Case "Customer DOB"
                mtbSearch.Mask = "00/00/0000"
        End Select

        'Change the text of the search field back to 'search' when their is a search filter
        If (mtbSearch.Enabled) Then
            btnSearch.Text = "Search"
        End If

        'Clear everything as if the clear button was clicked
        Initialize()
        ToggleButtonVisibilities(False)

        mtbSearch.Focus()
    End Sub

    'Toggle the Enabled state of the search textbox based on the filter
    Private Sub cboFilter_TextChanged(sender As Object, e As EventArgs) Handles cboFilter.TextChanged
        mtbSearch.Enabled = True

        'Handle the current filter
        HandleFilter(cboFilter.Text)
    End Sub

    'Clear the search and initialize everything back to default
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        currentCustomerIndex = 0

        Initialize()
        ToggleButtonVisibilities(False)
    End Sub

    'Detect the Enter key and press the search button
    Private Sub msktbSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles mtbSearch.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearch.PerformClick()
        End If
    End Sub

    'Navigate to the database totals form
    Private Sub menuItemTotals_Click(sender As Object, e As EventArgs) Handles menuItemTotals.Click
        Hide()
        frmDatabaseTotals.Show()
    End Sub

    'Navigate to the database transactions form
    Private Sub menuItemTransactions_Click(sender As Object, e As EventArgs) Handles menuItemTransactions.Click
        Hide()
        frmDatabaseTransactions.Show()
    End Sub
End Class