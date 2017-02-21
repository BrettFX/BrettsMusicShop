Public Class frmAdminLogIn

    Const PASSWORD As String = "password"

    Dim loginClicked As Boolean

    'Each time the form is loaded, set the loginClicked variable to false
    Private Sub frmAdminLogIn_Load(sender As Object, e As EventArgs) Handles Me.Load
        loginClicked = False
    End Sub

    'Go back to the main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click, Me.Closed
        If (sender Is btnBack) Then
            Close()
        End If

        'Only show the main for when the form is closed or the back button was clicked
        If Not (loginClicked) Then
            frmBrettsMusicShop.Show()
        End If

    End Sub

    'Validate the password and proceed to the database manager form if successfully authenticated
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtPassword.Text <> PASSWORD) Then
            MsgBox("Invlaid Password!", MsgBoxStyle.Critical, "ERROR")
            txtPassword.Text = ""
        Else
            loginClicked = True

            frmDatabaseManager.Show()
            Close()
        End If
    End Sub

    'Used to perform the login click operation if the enter key is pressed
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class