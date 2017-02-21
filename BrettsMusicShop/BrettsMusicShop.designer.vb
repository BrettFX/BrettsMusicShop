<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrettsMusicShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrettsMusicShop))
        Me.txtEmailSignUp = New System.Windows.Forms.TextBox()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.btnGuestLogin = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lnklblAdminSignIn = New System.Windows.Forms.LinkLabel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtEmailSignUp
        '
        Me.txtEmailSignUp.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailSignUp.ForeColor = System.Drawing.Color.Silver
        Me.txtEmailSignUp.Location = New System.Drawing.Point(299, 76)
        Me.txtEmailSignUp.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmailSignUp.Name = "txtEmailSignUp"
        Me.txtEmailSignUp.Size = New System.Drawing.Size(200, 25)
        Me.txtEmailSignUp.TabIndex = 1
        Me.txtEmailSignUp.Text = "Your e-mail address"
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignIn.ForeColor = System.Drawing.Color.Yellow
        Me.btnSignIn.Location = New System.Drawing.Point(208, 112)
        Me.btnSignIn.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(291, 30)
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "SIGN IN"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'btnGuestLogin
        '
        Me.btnGuestLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuestLogin.ForeColor = System.Drawing.Color.Yellow
        Me.btnGuestLogin.Location = New System.Drawing.Point(208, 152)
        Me.btnGuestLogin.Margin = New System.Windows.Forms.Padding(1)
        Me.btnGuestLogin.Name = "btnGuestLogin"
        Me.btnGuestLogin.Size = New System.Drawing.Size(291, 30)
        Me.btnGuestLogin.TabIndex = 3
        Me.btnGuestLogin.Text = "GUEST LOGIN"
        Me.btnGuestLogin.UseVisualStyleBackColor = False
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSignUp.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.Yellow
        Me.btnSignUp.Location = New System.Drawing.Point(208, 74)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(86, 30)
        Me.btnSignUp.TabIndex = 2
        Me.btnSignUp.Text = "SIGN UP"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(62, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(325, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Welcome to Brett's Music Shop!"
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblInformation.Location = New System.Drawing.Point(209, 210)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(298, 72)
        Me.lblInformation.TabIndex = 5
        Me.lblInformation.Text = "If you are not already a customer, we " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "encourage  you to sign up! As a customer " &
    "you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gain access to various elegant instruments" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with lifetime support!"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmin.Location = New System.Drawing.Point(209, 308)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(106, 18)
        Me.lblAdmin.TabIndex = 6
        Me.lblAdmin.Text = "Administrator?"
        '
        'lnklblAdminSignIn
        '
        Me.lnklblAdminSignIn.AutoSize = True
        Me.lnklblAdminSignIn.BackColor = System.Drawing.Color.Transparent
        Me.lnklblAdminSignIn.Location = New System.Drawing.Point(321, 308)
        Me.lnklblAdminSignIn.Name = "lnklblAdminSignIn"
        Me.lnklblAdminSignIn.Size = New System.Drawing.Size(52, 18)
        Me.lnklblAdminSignIn.TabIndex = 7
        Me.lnklblAdminSignIn.TabStop = True
        Me.lnklblAdminSignIn.Text = "Log in"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.ForeColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(208, 339)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(291, 30)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmBrettsMusicShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.BrettsMusicShop.My.Resources.Resources.MusicBackground00
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 380)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lnklblAdminSignIn)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnGuestLogin)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.txtEmailSignUp)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmBrettsMusicShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brett's Music Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmailSignUp As TextBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnGuestLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lnklblAdminSignIn As LinkLabel
    Friend WithEvents btnExit As Button
End Class
