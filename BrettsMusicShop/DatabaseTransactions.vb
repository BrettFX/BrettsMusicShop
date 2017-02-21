Public Class frmDatabaseTransactions

    'Load the transactions table into the transactions datagrid view
    Private Sub DatabaseTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlStr As String = "Select * From " & frmDatabaseManager.TRANSACTIONS_TABLE_NAME

        Dim dt As New DataTable()
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()

        dgvTransactions.DataSource = dt
    End Sub

    'Navigate back to the database manager form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    'Navigate back to the database manager form
    Private Sub frmDatabaseTransactions_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmDatabaseManager.Show()
    End Sub
End Class