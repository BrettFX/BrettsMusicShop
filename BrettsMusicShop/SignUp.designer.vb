<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignUp))
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMailingAddress = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.mtbPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.mtbDOB = New System.Windows.Forms.MaskedTextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblHasAccount = New System.Windows.Forms.Label()
        Me.lnklblSignIn = New System.Windows.Forms.LinkLabel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.mtbZip = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtPasswordConfirmation = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.ForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.Location = New System.Drawing.Point(200, 53)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(143, 25)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.ForeColor = System.Drawing.Color.Silver
        Me.txtLastName.Location = New System.Drawing.Point(353, 53)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(153, 25)
        Me.txtLastName.TabIndex = 2
        Me.txtLastName.Text = "Last Name"
        '
        'txtMailingAddress
        '
        Me.txtMailingAddress.ForeColor = System.Drawing.Color.Silver
        Me.txtMailingAddress.Location = New System.Drawing.Point(201, 179)
        Me.txtMailingAddress.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtMailingAddress.Name = "txtMailingAddress"
        Me.txtMailingAddress.Size = New System.Drawing.Size(305, 25)
        Me.txtMailingAddress.TabIndex = 7
        Me.txtMailingAddress.Text = "Mailing Address"
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(200, 83)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(305, 25)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Text = "Password"
        '
        'mtbPhoneNumber
        '
        Me.mtbPhoneNumber.Location = New System.Drawing.Point(319, 213)
        Me.mtbPhoneNumber.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbPhoneNumber.Mask = "(999) 000-0000"
        Me.mtbPhoneNumber.Name = "mtbPhoneNumber"
        Me.mtbPhoneNumber.Size = New System.Drawing.Size(144, 25)
        Me.mtbPhoneNumber.TabIndex = 8
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblPhoneNumber.ForeColor = System.Drawing.Color.Black
        Me.lblPhoneNumber.Location = New System.Drawing.Point(201, 214)
        Me.lblPhoneNumber.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(109, 18)
        Me.lblPhoneNumber.TabIndex = 5
        Me.lblPhoneNumber.Text = "Phone Number:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.BackColor = System.Drawing.Color.Transparent
        Me.lblDOB.ForeColor = System.Drawing.Color.Black
        Me.lblDOB.Location = New System.Drawing.Point(201, 244)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(192, 18)
        Me.lblDOB.TabIndex = 6
        Me.lblDOB.Text = "Date of Birth (mm/dd/yyyy):"
        '
        'mtbDOB
        '
        Me.mtbDOB.Location = New System.Drawing.Point(400, 243)
        Me.mtbDOB.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbDOB.Mask = "00/00/0000"
        Me.mtbDOB.Name = "mtbDOB"
        Me.mtbDOB.Size = New System.Drawing.Size(107, 25)
        Me.mtbDOB.TabIndex = 9
        Me.mtbDOB.ValidatingType = GetType(Date)
        '
        'cboGender
        '
        Me.cboGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cboGender.Location = New System.Drawing.Point(337, 273)
        Me.cboGender.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(104, 26)
        Me.cboGender.TabIndex = 10
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(201, 274)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(131, 18)
        Me.lblGender.TabIndex = 9
        Me.lblGender.Text = "Gender (Optional):"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Yellow
        Me.btnSignUp.Location = New System.Drawing.Point(199, 304)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(305, 41)
        Me.btnSignUp.TabIndex = 11
        Me.btnSignUp.Text = "Sign up"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblHasAccount
        '
        Me.lblHasAccount.AutoSize = True
        Me.lblHasAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblHasAccount.ForeColor = System.Drawing.Color.Black
        Me.lblHasAccount.Location = New System.Drawing.Point(201, 359)
        Me.lblHasAccount.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblHasAccount.Name = "lblHasAccount"
        Me.lblHasAccount.Size = New System.Drawing.Size(172, 18)
        Me.lblHasAccount.TabIndex = 11
        Me.lblHasAccount.Text = "Already have an account?"
        '
        'lnklblSignIn
        '
        Me.lnklblSignIn.AutoSize = True
        Me.lnklblSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lnklblSignIn.Location = New System.Drawing.Point(377, 359)
        Me.lnklblSignIn.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lnklblSignIn.Name = "lnklblSignIn"
        Me.lnklblSignIn.Size = New System.Drawing.Size(56, 18)
        Me.lnklblSignIn.TabIndex = 12
        Me.lnklblSignIn.TabStop = True
        Me.lnklblSignIn.Text = "Sign in"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Yellow
        Me.btnBack.Location = New System.Drawing.Point(198, 9)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(305, 38)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'mtbZip
        '
        Me.mtbZip.Location = New System.Drawing.Point(373, 144)
        Me.mtbZip.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.mtbZip.Mask = "00000"
        Me.mtbZip.Name = "mtbZip"
        Me.mtbZip.Size = New System.Drawing.Size(66, 25)
        Me.mtbZip.TabIndex = 6
        Me.mtbZip.ValidatingType = GetType(Integer)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(311, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Zipcode:"
        '
        'cboState
        '
        Me.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cboState.Location = New System.Drawing.Point(254, 144)
        Me.cboState.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(51, 26)
        Me.cboState.TabIndex = 5
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(202, 146)
        Me.lblState.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(43, 18)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State:"
        '
        'txtPasswordConfirmation
        '
        Me.txtPasswordConfirmation.ForeColor = System.Drawing.Color.Silver
        Me.txtPasswordConfirmation.Location = New System.Drawing.Point(200, 113)
        Me.txtPasswordConfirmation.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPasswordConfirmation.Name = "txtPasswordConfirmation"
        Me.txtPasswordConfirmation.Size = New System.Drawing.Size(305, 25)
        Me.txtPasswordConfirmation.TabIndex = 4
        Me.txtPasswordConfirmation.Text = "Confirm Password"
        '
        'frmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.BrettsMusicShop.My.Resources.Resources.MusicBackground00
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 396)
        Me.Controls.Add(Me.txtPasswordConfirmation)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.cboState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtbZip)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lnklblSignIn)
        Me.Controls.Add(Me.lblHasAccount)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.mtbDOB)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.mtbPhoneNumber)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtMailingAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MaximizeBox = False
        Me.Name = "frmSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brett's Music Shop: Sign-up Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMailingAddress As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents mtbPhoneNumber As MaskedTextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents mtbDOB As MaskedTextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblHasAccount As Label
    Friend WithEvents lnklblSignIn As LinkLabel
    Friend WithEvents btnBack As Button
    Friend WithEvents mtbZip As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtPasswordConfirmation As TextBox
End Class
