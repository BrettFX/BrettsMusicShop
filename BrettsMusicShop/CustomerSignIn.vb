Public Class frmCustomerSignIn

    'Public cusName to share with the store
    Public Shared cusName As String = ""

    'Public cusID to share with the store
    Public Shared cusID As String = ""

    'Go back to the main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
    End Sub

    'Go back to the main form
    Private Sub frmCustomerSignIn_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmBrettsMusicShop.Show()
    End Sub

    'Authenticate the customer by searching through the database to find a matching email and password using sql
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'To determine if the customer is in the database
        Dim isUser As Boolean = False

        'Used to search for the user in the database
        Dim find As String = ""

        Dim dt As New DataTable()

        'Select the customer name, password, and id fields from the database
        Dim sqlStr As String = "Select " & frmDatabaseManager.CUSTOMER_EMAIL_FIELD & ", " &
                                frmDatabaseManager.CUSTOMER_NAME_FIELD & ", " &
                                frmDatabaseManager.CUSTOMER_PASSWORD_FIELD & ", " &
                                frmDatabaseManager.CUSTOMER_ID_FIELD &
                                " From " & frmDatabaseManager.CUSTOMER_TABLE_NAME

        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, frmDatabaseManager.CONN_STR)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()

        find = txtEmail.Text

        'Query the database to find a matching username/id and password
        For i As Integer = 0 To (dt.Rows.Count - 1)
            If CStr(dt.Rows(i)(frmDatabaseManager.CUSTOMER_EMAIL_FIELD)) = find Then
                If CStr(dt.Rows(i)(frmDatabaseManager.CUSTOMER_PASSWORD_FIELD)) = txtPassword.Text Then
                    isUser = True

                    'Set the cusName and cusID
                    cusName = CStr(dt.Rows(i)(frmDatabaseManager.CUSTOMER_NAME_FIELD))
                    cusID = CStr(dt.Rows(i)(frmDatabaseManager.CUSTOMER_ID_FIELD))

                    'Break out of the loop
                    i = dt.Rows.Count - 1
                End If
            End If
        Next

        'If is a customer, go to the store. Otherwise, let the user try again
        If (isUser) Then
            Close()
            frmBrettsMusicShop.Hide()
            frmStore.Show()

            Console.WriteLine("cusName: " & cusName & " cusID: " & cusID)
        Else
            txtEmail.Text = ""
            txtPassword.Text = ""
            MsgBox("Invalid Username and/or Password!", MsgBoxStyle.Critical)
            txtEmail.Focus()
        End If
    End Sub

    'Used to perform the login click operation if the enter key is pressed
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class