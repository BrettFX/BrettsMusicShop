Public Class frmDatabaseTotals

    'Initialize all data containers from the database tables
    Private Sub frmDatabaseTotals_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeInventoryDataGrid("Select " & frmDatabaseManager.INVENTORY_SKU_FIELD & ", " &
                                                frmDatabaseManager.INVENTORY_ITEM_CATEGORY_FIELD & ", " &
                                                frmDatabaseManager.INVENTORY_ITEM_NAME_FIELD & ", " &
                                                frmDatabaseManager.INVENTORY_ITEM_PRICE_FIELD & ", " &
                                                frmDatabaseManager.INVENTORY_ITEM_WEIGHT_FIELD & ", " &
                                                frmDatabaseManager.INVENTORY_QTY_ON_HAND_FIELD &
                                    " From " & frmDatabaseManager.INVENTORY_TABLE_NAME)

        InitializeFinancialData("Select " & frmDatabaseManager.TRANSACTION_SUBTOTAL_FIELD & ", " &
                                          frmDatabaseManager.TRANSACTION_TAX_FIELD & ", " &
                                          frmDatabaseManager.TRANSACTION_TOTAL_FIELD &
                              " From " & frmDatabaseManager.TRANSACTIONS_TABLE_NAME)

        GetCustomerDemographics("Select " & frmDatabaseManager.CUSTOMER_STATE_FIELD & ", " &
                                          frmDatabaseManager.CUSTOMER_ZIP_FIELD & ", " &
                                          frmDatabaseManager.CUSTOMER_BIRTHDAY_FIELD & ", " &
                                          frmDatabaseManager.CUSTOMER_GENDER_FIELD &
                              " From " & frmDatabaseManager.CUSTOMER_TABLE_NAME)
    End Sub

    'Extrapolate customer information from the customer data in the customer table
    Private Sub GetCustomerDemographics(sqlStr As String)
        Dim dt As New DataTable()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()

        'Get the total number of customers
        Dim totalCustomers As Integer = dt.Rows.Count

        'Tally the total number of male, female, and other customers
        Dim totalMale As Integer = 0, totalFemale As Integer = 0, totalOther As Integer = 0

        'Accumulator of all the ages to determine an average age of all the customers
        Dim averageAge As Double = 0.0

        'Keep track of the total number of customer over and under the age of 21
        Dim totalUnder21 As Integer = 0, totalOver21 As Integer = 0

        'Temporarily store the gender of the customer in question
        Dim customerGender As String = ""

        'Temporarily store the customer year of birth in question
        Dim customerYOB As String = ""

        'Temporarily store the customers' age
        Dim customerAge As Integer = 0

        'Get the total number of male and female customers
        For i As Integer = 0 To dt.Rows.Count - 1
            customerGender = dt.Rows(i)(frmDatabaseManager.CUSTOMER_GENDER_FIELD)
            customerYOB = dt.Rows(i)(frmDatabaseManager.CUSTOMER_BIRTHDAY_FIELD)

            'Truncate the customerYOB to only the birth year
            customerYOB = customerYOB.Substring(6)

            customerAge = DateTime.Now.Year - CInt(customerYOB)

            averageAge += customerAge

            If (customerAge >= 21) Then
                totalOver21 += 1
            Else
                totalUnder21 += 1
            End If

            'Determine if male, female, or other
            If (customerGender.ToUpper = "MALE") Then
                totalMale += 1
            ElseIf (customerGender.ToUpper = "FEMALE") Then
                totalFemale += 1
            Else
                totalOther += 1
            End If
        Next

        'Determine the average age of the customers by dividing the sum of all the ages by the total number of customers
        averageAge /= dt.Rows.Count

        'Display the totals
        txtTotalCustomers.Text = totalCustomers.ToString()
        txtTotalMales.Text = totalMale.ToString()
        txtTotalFemales.Text = totalFemale.ToString()
        txtTotalOtherGender.Text = totalOther.ToString()

        txtAverageAge.Text = averageAge.ToString("F")
        txtOver21.Text = totalOver21.ToString()
        txtUnder21.Text = totalUnder21.ToString()
    End Sub

    'Loads data from Inventory table into the inventory data grid
    Private Sub InitializeInventoryDataGrid(sqlStr As String)
        Dim dt As New DataTable()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()
        dgvInventory.DataSource = dt
    End Sub

    'Extrapolate financial information from the financial data in the transactions table
    Private Sub InitializeFinancialData(sqlStr As String)
        Dim dt As New DataTable()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()

        'Keep track of the gross revenue
        Dim grossRevenue As Double = 0.0

        Dim netRevenue As Double = 0.0

        'Keep track of the total tax
        Dim totalTax As Double = 0.0

        'Accumulate the grossRevenue and totalTax
        For i As Integer = 0 To dt.Rows.Count - 1
            grossRevenue += CDbl(dt.Rows(i)(frmDatabaseManager.TRANSACTION_SUBTOTAL_FIELD))
            totalTax += CDbl(dt.Rows(i)(frmDatabaseManager.TRANSACTION_TAX_FIELD))
        Next

        netRevenue = grossRevenue - totalTax

        txtTotalGrossRevenue.Text = grossRevenue.ToString("C")
        txtTotalTax.Text = totalTax.ToString("C")
        txtTotalNetRevenue.Text = netRevenue.ToString("C")
    End Sub

    'Go back to the database manager form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    'Go back to the database manager form
    Private Sub frmDatabaseTotals_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmDatabaseManager.Show()
    End Sub

    'Search for customers living in the same specified state
    Private Sub cboState_TextChanged(sender As Object, e As EventArgs) Handles cboState.TextChanged
        Dim dt As New DataTable()

        Dim sqlStr As String = "Select " & frmDatabaseManager.CUSTOMER_STATE_FIELD &
                              " From " & frmDatabaseManager.CUSTOMER_TABLE_NAME

        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()

        'Keep track of the total number of customers living in the same state
        Dim totalSameState As Integer = 0

        'Count the total number of customers living in the same state
        For i As Integer = 0 To dt.Rows.Count - 1
            If (cboState.Text.Contains(dt.Rows(i)(frmDatabaseManager.CUSTOMER_STATE_FIELD))) Then
                totalSameState += 1
            End If
        Next

        'Display the total number of customer living in the specified state
        txtStateTotal.Text = totalSameState.ToString() & " customer(s) live in " & cboState.Text.Split("-")(0).Trim() & "."
    End Sub
End Class