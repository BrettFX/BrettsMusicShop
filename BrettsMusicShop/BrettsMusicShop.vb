Public Class frmBrettsMusicShop

    'Public email to share across forms
    Public emailAddress As String = ""

    'Reactively handle the click event of the email textbox
    Private Sub txtEmailSignUp_Click(sender As Object, e As EventArgs) Handles txtEmailSignUp.Click
        'If the user is about to sign up and it is the first time that they have clicked the
        'txtEmailSignUp field then erase the initial text for the user
        If (txtEmailSignUp.ForeColor <> Color.Black) Then
            txtEmailSignUp.Text = ""
        Else
            txtEmailSignUp.SelectAll()
        End If
    End Sub

    'Reactively handle the KeyDown event of the email textbox
    Private Sub txtEmailSignUp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmailSignUp.KeyDown
        txtEmailSignUp.ForeColor = Color.Black
    End Sub

    'Load the sign-up page if the user has entered their email address and wishes to sign up
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        'Only proceed if the user has entered their email
        If txtEmailSignUp.Text.Contains("@") Then
            'Save the email address in a variable
            emailAddress = txtEmailSignUp.Text

            Hide()
            frmSignUp.Show()

            InitializeEmailField()
        Else
            MsgBox("In order to sign up, you must first provide your email address!", MsgBoxStyle.Critical, "ERROR")
        End If

    End Sub

    'Navigate to the customer sign-in form in order to sign-in to the store as an existing customer
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Hide()
        frmCustomerSignIn.Show()
    End Sub

    'Login to the store as a guest and navigate to the store form
    Private Sub btnGuestLogin_Click(sender As Object, e As EventArgs) Handles btnGuestLogin.Click
        Hide()
        frmStore.Show()
    End Sub

    'Navigate to the administrator sign-in form access the database manager form
    Private Sub lnklblAdminSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblAdminSignIn.LinkClicked
        Hide()
        frmAdminLogIn.Show()
    End Sub

    'Set the email textbox to it's initial state
    Sub InitializeEmailField()
        txtEmailSignUp.ForeColor = Color.Silver
        txtEmailSignUp.Text = "Your e-mail address"
    End Sub

    'Exit the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class