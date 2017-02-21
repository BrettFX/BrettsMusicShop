<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminLogIn))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.ForeColor = System.Drawing.Color.Yellow
        Me.btnBack.Location = New System.Drawing.Point(30, 30)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(222, 82)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Location = New System.Drawing.Point(32, 345)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(331, 46)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Admin Password:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtPassword.Location = New System.Drawing.Point(368, 338)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(589, 53)
        Me.txtPassword.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLogin.ForeColor = System.Drawing.Color.Yellow
        Me.btnLogin.Location = New System.Drawing.Point(38, 468)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(925, 82)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Location = New System.Drawing.Point(25, 150)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(945, 138)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "Log in as an administrator to find and/or delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "members from the database, view" &
    " inventory records," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and look at totals from the database."
        '
        'frmAdminLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(240.0!, 240.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 588)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Name = "frmAdminLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminLogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblInfo As Label
End Class
