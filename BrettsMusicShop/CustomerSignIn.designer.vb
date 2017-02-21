<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSignIn))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.ForeColor = System.Drawing.Color.Yellow
        Me.btnBack.Location = New System.Drawing.Point(30, 30)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(720, 82)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.ForeColor = System.Drawing.Color.Yellow
        Me.btnLogin.Location = New System.Drawing.Point(35, 290)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(715, 82)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Location = New System.Drawing.Point(30, 205)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(207, 46)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtPassword.Location = New System.Drawing.Point(240, 200)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(504, 53)
        Me.txtPassword.TabIndex = 1
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.BackColor = System.Drawing.Color.Transparent
        Me.lblUserName.Location = New System.Drawing.Point(80, 130)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(131, 46)
        Me.lblUserName.TabIndex = 8
        Me.lblUserName.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtEmail.Location = New System.Drawing.Point(240, 122)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(504, 53)
        Me.txtEmail.TabIndex = 0
        '
        'frmCustomerSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(240.0!, 240.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(782, 415)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.MaximizeBox = False
        Me.Name = "frmCustomerSignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerSignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtEmail As TextBox
End Class
