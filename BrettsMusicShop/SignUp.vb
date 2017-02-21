Public Class frmSignUp

    'Setup components for the database table
    Dim dt As New DataTable()
    Dim rowIndex As Integer = 0
    Dim sqlstr As String = "select * from " & frmDatabaseManager.CUSTOMER_TABLE_NAME
    Dim dataAdapter As OleDb.OleDbDataAdapter

    'Make the customer's name public so that when he/she sign's up and is directed to the store,
    'the name can be referenced
    Public Shared cusName As String = ""

    'Make the cutomer's ID public so that when he/she sign's up and is directed to the store,
    'the ID can be referenced
    Public Shared cusID As String = ""

    Dim cusEmail As String = ""

    'Initialize customer email, data table, and data adapter
    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set customer email from a frmBrettsMusicShop form
        cusEmail = frmBrettsMusicShop.emailAddress

        dt.Clear()

        dataAdapter = New OleDb.OleDbDataAdapter(sqlstr, frmDatabaseManager.CONN_STR)

        dataAdapter.Fill(dt)
    End Sub

    'Close the form and navigate back to the main form
    Private Sub frmSignUp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Release memory allocated by dataAdapter
        dataAdapter.Dispose()
    End Sub

    'Close the form and navigate back to the main form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        frmBrettsMusicShop.Show()
    End Sub

    'Implementing reactive design by polymorphically applying behavior to typing in the textboxes
    Private Sub textFields_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyDown, txtMailingAddress.KeyDown, txtLastName.KeyDown,
            txtPassword.KeyDown, txtPasswordConfirmation.KeyDown

        'Create a temporary textField object to handle a type cast
        Dim textField As TextBox

        'Determine if the sender object is a textbox (should always be) and polymorphically set the Foregroud color to Black
        If TypeOf sender Is TextBox Then
            textField = DirectCast(sender, TextBox)
            textField.ForeColor = Color.Black
        End If
    End Sub

    'Implementing reactive design by polymorphically applying behavior when the textboxes gain focus
    Private Sub textFields_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus,
        txtMailingAddress.GotFocus, txtLastName.GotFocus, txtPassword.GotFocus, txtPasswordConfirmation.GotFocus

        'Create a temporary textField object to handle a type cast
        Dim textField As TextBox

        'Determine if the sender object is a textbox (should always be) and polymorphically manipulate the text
        If TypeOf sender Is TextBox Then
            textField = DirectCast(sender, TextBox)

            If (textField.ForeColor <> Color.Black) Then
                textField.Text = ""

                'Handle special case if txtPassword
                If (textField.Equals(txtPassword) Or textField.Equals(txtPasswordConfirmation)) Then
                    textField.PasswordChar = CChar("*")
                End If

            Else
                textField.SelectAll()
            End If
        End If
    End Sub

    'Initialize the textboxes based on the specified textbox
    Sub InitializeTextField(sender As Object)
        'Create a temporary textField object to handle a type cast
        Dim textField As TextBox

        'Determine if the sender object is a textbox (should always be) and polymorphically set the text fields back to their initial states if they are blank
        If (TypeOf sender Is TextBox) Then

            textField = DirectCast(sender, TextBox)

            'Determing if the text field was blank when it lost focus
            If (textField.Text = "") Then

                'Set fore color to silver
                textField.ForeColor = Color.Silver

                'Set the text fields back to their initial states if they are blank when they lose focus
                If (textField.Equals(txtFirstName)) Then
                    textField.Text = "First Name"
                ElseIf (textField.Equals(txtLastName)) Then
                    textField.Text = "Last Name"
                ElseIf (textField.Equals(txtMailingAddress)) Then
                    textField.Text = "Mailing Address"
                ElseIf (textField.Equals(txtPassword)) Then
                    textField.PasswordChar = CChar("")
                    textField.Text = "Password"
                ElseIf (textField.Equals(txtPasswordConfirmation)) Then
                    textField.PasswordChar = CChar("")
                    textField.Text = "Confirm Password"
                End If
            End If
        End If
    End Sub

    'Initialize textboxes when they lose focus
    Private Sub textFields_LostFocus(sender As Object, e As EventArgs) Handles txtFirstName.LostFocus, txtLastName.LostFocus, txtMailingAddress.LostFocus,
            txtPassword.LostFocus, txtPasswordConfirmation.LostFocus

        InitializeTextField(sender)
    End Sub

    'Navigate to the customer sign in form
    Private Sub lnklblSignIn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblSignIn.LinkClicked
        Close()
        frmBrettsMusicShop.Hide()
        frmCustomerSignIn.Show()
    End Sub

    'Add new customer to the Database
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If (txtPassword.Text = txtPasswordConfirmation.Text) Then
            Dim i As Integer
            Dim cusPassword, cusState, cusZip, cusPhone, cusDOB, cusGender As String
            Dim rw As DataRow
            Dim commandBuilder As New OleDb.OleDbCommandBuilder(dataAdapter)

            Dim random = New Random()
            Dim randID = random.Next(1, 999999)

            'Add a new row to the customers table
            rw = dt.NewRow
            cusID = randID
            cusName = txtFirstName.Text & " " & txtLastName.Text
            cusPassword = txtPassword.Text
            cusState = cboState.Text
            cusZip = mtbZip.Text
            cusPhone = mtbPhoneNumber.Text

            If (cboGender.Text <> "") Then
                cusGender = cboGender.Text
            Else
                cusGender = "Unspecified"
            End If

            cusDOB = mtbDOB.Text

            'Write the contents of the input fields to the repective row and columns of the database
            rw.Item(frmDatabaseManager.CUSTOMER_ID_FIELD) = cusID
            rw.Item(frmDatabaseManager.CUSTOMER_NAME_FIELD) = cusName
            rw.Item(frmDatabaseManager.CUSTOMER_EMAIL_FIELD) = cusEmail
            rw.Item(frmDatabaseManager.CUSTOMER_PASSWORD_FIELD) = cusPassword
            rw.Item(frmDatabaseManager.CUSTOMER_STATE_FIELD) = cusState
            rw.Item(frmDatabaseManager.CUSTOMER_ZIP_FIELD) = cusZip
            rw.Item(frmDatabaseManager.CUSTOMER_PHONE_FIELD) = cusPhone
            rw.Item(frmDatabaseManager.CUSTOMER_BIRTHDAY_FIELD) = cusDOB
            rw.Item(frmDatabaseManager.CUSTOMER_GENDER_FIELD) = cusGender

            'Try to add the row to the database
            Try
                dt.Rows.Add(rw)

                'Update the Student table in the testdb database
                i = dataAdapter.Update(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'Reset the input fields for future use
            Initialize()

            'Close the form and go to the 
            Close()
            frmStore.Show()

            MessageBox.Show("Thank you for signing up " & cusName & " (" & cusID & ")" & "! You are customer number " &
                            dt.Rows.Count & "!")
        Else
            InitializeTextField(txtPassword)
            InitializeTextField(txtPasswordConfirmation)
            MsgBox("Passwords do not match each other. Please choose a valid password.", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    'Reset all the text fields
    Private Sub Initialize()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtMailingAddress.Text = ""
        txtPassword.Text = ""
        txtPasswordConfirmation.Text = ""

        'Initialize text fields back to their beginning state
        InitializeTextField(txtFirstName)
        InitializeTextField(txtLastName)
        InitializeTextField(txtMailingAddress)
        InitializeTextField(txtPassword)

        cboState.Text = ""
        cboGender.Text = ""

        mtbDOB.Text = ""
        mtbPhoneNumber.Text = ""
        mtbZip.Text = ""
    End Sub

    'Forces the state characters to be uppercase
    Private Sub cboState_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboState.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class