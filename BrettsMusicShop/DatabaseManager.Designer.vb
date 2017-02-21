<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabaseManager))
        Me.lblFind = New System.Windows.Forms.Label()
        Me.cboFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpbxCusInfo = New System.Windows.Forms.GroupBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtBirth = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtZipcode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.mtbSearch = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemSignOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemTotals = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCustomersFound = New System.Windows.Forms.Label()
        Me.txtCustomersFound = New System.Windows.Forms.TextBox()
        Me.grpbxCusInfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.BackColor = System.Drawing.Color.Transparent
        Me.lblFind.Location = New System.Drawing.Point(8, 79)
        Me.lblFind.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(181, 20)
        Me.lblFind.TabIndex = 8
        Me.lblFind.Text = "Find/Delete a Customer:"
        '
        'cboFilter
        '
        Me.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilter.FormattingEnabled = True
        Me.cboFilter.Items.AddRange(New Object() {"None", "Customer ID", "Customer Name", "Customer State", "Customer Zipcode", "Customer Phone", "Customer Gender", "Customer DOB"})
        Me.cboFilter.Location = New System.Drawing.Point(7, 138)
        Me.cboFilter.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cboFilter.Name = "cboFilter"
        Me.cboFilter.Size = New System.Drawing.Size(150, 28)
        Me.cboFilter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Search Filter:"
        '
        'grpbxCusInfo
        '
        Me.grpbxCusInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpbxCusInfo.Controls.Add(Me.txtGender)
        Me.grpbxCusInfo.Controls.Add(Me.txtBirth)
        Me.grpbxCusInfo.Controls.Add(Me.txtPhone)
        Me.grpbxCusInfo.Controls.Add(Me.txtZipcode)
        Me.grpbxCusInfo.Controls.Add(Me.txtState)
        Me.grpbxCusInfo.Controls.Add(Me.txtPassword)
        Me.grpbxCusInfo.Controls.Add(Me.txtEmail)
        Me.grpbxCusInfo.Controls.Add(Me.txtName)
        Me.grpbxCusInfo.Controls.Add(Me.txtID)
        Me.grpbxCusInfo.Controls.Add(Me.lblGender)
        Me.grpbxCusInfo.Controls.Add(Me.lblDOB)
        Me.grpbxCusInfo.Controls.Add(Me.lblPhone)
        Me.grpbxCusInfo.Controls.Add(Me.lblZip)
        Me.grpbxCusInfo.Controls.Add(Me.lblState)
        Me.grpbxCusInfo.Controls.Add(Me.lblPassword)
        Me.grpbxCusInfo.Controls.Add(Me.lblEmail)
        Me.grpbxCusInfo.Controls.Add(Me.lblName)
        Me.grpbxCusInfo.Controls.Add(Me.lblID)
        Me.grpbxCusInfo.Location = New System.Drawing.Point(188, 79)
        Me.grpbxCusInfo.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpbxCusInfo.Name = "grpbxCusInfo"
        Me.grpbxCusInfo.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpbxCusInfo.Size = New System.Drawing.Size(410, 339)
        Me.grpbxCusInfo.TabIndex = 11
        Me.grpbxCusInfo.TabStop = False
        Me.grpbxCusInfo.Text = "Customer Information:"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(202, 293)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(204, 26)
        Me.txtGender.TabIndex = 17
        Me.txtGender.TabStop = False
        '
        'txtBirth
        '
        Me.txtBirth.Location = New System.Drawing.Point(202, 259)
        Me.txtBirth.Name = "txtBirth"
        Me.txtBirth.ReadOnly = True
        Me.txtBirth.Size = New System.Drawing.Size(204, 26)
        Me.txtBirth.TabIndex = 16
        Me.txtBirth.TabStop = False
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(202, 225)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(204, 26)
        Me.txtPhone.TabIndex = 15
        Me.txtPhone.TabStop = False
        '
        'txtZipcode
        '
        Me.txtZipcode.Location = New System.Drawing.Point(202, 191)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.ReadOnly = True
        Me.txtZipcode.Size = New System.Drawing.Size(204, 26)
        Me.txtZipcode.TabIndex = 14
        Me.txtZipcode.TabStop = False
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(202, 157)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(204, 26)
        Me.txtState.TabIndex = 13
        Me.txtState.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(202, 123)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(204, 26)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(202, 89)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(204, 26)
        Me.txtEmail.TabIndex = 11
        Me.txtEmail.TabStop = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(202, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(204, 26)
        Me.txtName.TabIndex = 10
        Me.txtName.TabStop = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(202, 24)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(204, 26)
        Me.txtID.TabIndex = 9
        Me.txtID.TabStop = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(59, 294)
        Me.lblGender.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(136, 20)
        Me.lblGender.TabIndex = 8
        Me.lblGender.Text = "Customer Gender"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(25, 260)
        Me.lblDOB.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(172, 20)
        Me.lblDOB.TabIndex = 7
        Me.lblDOB.Text = "Customer Date of Birth"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(4, 226)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(188, 20)
        Me.lblPhone.TabIndex = 6
        Me.lblPhone.Text = "Customer Phone Number"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(57, 192)
        Me.lblZip.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(139, 20)
        Me.lblZip.TabIndex = 5
        Me.lblZip.Text = "Customer Zipcode"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(74, 158)
        Me.lblState.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(121, 20)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "Customer State"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(41, 124)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(151, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Customer Password"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(72, 90)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(121, 20)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Customer Email"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(72, 57)
        Me.lblName.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(124, 20)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Customer Name"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(95, 25)
        Me.lblID.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(99, 20)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Customer ID"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.ForeColor = System.Drawing.Color.Yellow
        Me.btnSearch.Location = New System.Drawing.Point(446, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(105, 33)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Find All"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.Yellow
        Me.btnDelete.Location = New System.Drawing.Point(7, 385)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 33)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        Me.btnDelete.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.ForeColor = System.Drawing.Color.Yellow
        Me.btnClear.Location = New System.Drawing.Point(7, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 33)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.ForeColor = System.Drawing.Color.Yellow
        Me.btnPrevious.Location = New System.Drawing.Point(7, 316)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(150, 33)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        Me.btnPrevious.Visible = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.Enabled = False
        Me.btnNext.ForeColor = System.Drawing.Color.Yellow
        Me.btnNext.Location = New System.Drawing.Point(7, 281)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 33)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        Me.btnNext.Visible = False
        '
        'mtbSearch
        '
        Me.mtbSearch.Location = New System.Drawing.Point(7, 41)
        Me.mtbSearch.Name = "mtbSearch"
        Me.mtbSearch.Size = New System.Drawing.Size(433, 26)
        Me.mtbSearch.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Stencil", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemSignOut, Me.menuItemTotals, Me.menuItemTransactions})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'menuItemSignOut
        '
        Me.menuItemSignOut.Name = "menuItemSignOut"
        Me.menuItemSignOut.Size = New System.Drawing.Size(160, 22)
        Me.menuItemSignOut.Text = "Sign out"
        '
        'menuItemTotals
        '
        Me.menuItemTotals.Name = "menuItemTotals"
        Me.menuItemTotals.Size = New System.Drawing.Size(160, 22)
        Me.menuItemTotals.Text = "Totals"
        '
        'menuItemTransactions
        '
        Me.menuItemTransactions.Name = "menuItemTransactions"
        Me.menuItemTransactions.Size = New System.Drawing.Size(160, 22)
        Me.menuItemTransactions.Text = "Transactions"
        '
        'lblCustomersFound
        '
        Me.lblCustomersFound.AutoSize = True
        Me.lblCustomersFound.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomersFound.Location = New System.Drawing.Point(8, 189)
        Me.lblCustomersFound.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCustomersFound.Name = "lblCustomersFound"
        Me.lblCustomersFound.Size = New System.Drawing.Size(140, 20)
        Me.lblCustomersFound.TabIndex = 13
        Me.lblCustomersFound.Text = "Customers Found:"
        '
        'txtCustomersFound
        '
        Me.txtCustomersFound.Location = New System.Drawing.Point(7, 213)
        Me.txtCustomersFound.Name = "txtCustomersFound"
        Me.txtCustomersFound.ReadOnly = True
        Me.txtCustomersFound.Size = New System.Drawing.Size(150, 26)
        Me.txtCustomersFound.TabIndex = 14
        Me.txtCustomersFound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmDatabaseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 421)
        Me.Controls.Add(Me.txtCustomersFound)
        Me.Controls.Add(Me.lblCustomersFound)
        Me.Controls.Add(Me.mtbSearch)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.grpbxCusInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFilter)
        Me.Controls.Add(Me.lblFind)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.MaximizeBox = False
        Me.Name = "frmDatabaseManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bretts Music Shop: Database Manager"
        Me.grpbxCusInfo.ResumeLayout(False)
        Me.grpbxCusInfo.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFind As Label
    Friend WithEvents cboFilter As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpbxCusInfo As GroupBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtBirth As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtZipcode As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents mtbSearch As MaskedTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemSignOut As ToolStripMenuItem
    Friend WithEvents menuItemTotals As ToolStripMenuItem
    Friend WithEvents menuItemTransactions As ToolStripMenuItem
    Friend WithEvents lblCustomersFound As Label
    Friend WithEvents txtCustomersFound As TextBox
End Class
