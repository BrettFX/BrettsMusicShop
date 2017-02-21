<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseTotals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabaseTotals))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.gboSameState = New System.Windows.Forms.GroupBox()
        Me.txtStateTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalCustomers = New System.Windows.Forms.TextBox()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.lblTotalMales = New System.Windows.Forms.Label()
        Me.txtTotalMales = New System.Windows.Forms.TextBox()
        Me.lblTotalFemales = New System.Windows.Forms.Label()
        Me.txtTotalFemales = New System.Windows.Forms.TextBox()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.txtTotalTax = New System.Windows.Forms.TextBox()
        Me.lblTotalGrossRevenue = New System.Windows.Forms.Label()
        Me.txtTotalGrossRevenue = New System.Windows.Forms.TextBox()
        Me.lblTotalNetRevenue = New System.Windows.Forms.Label()
        Me.txtTotalNetRevenue = New System.Windows.Forms.TextBox()
        Me.gboDemographicTotals = New System.Windows.Forms.GroupBox()
        Me.txtOver21 = New System.Windows.Forms.TextBox()
        Me.lblOver21 = New System.Windows.Forms.Label()
        Me.txtUnder21 = New System.Windows.Forms.TextBox()
        Me.lblUnder21 = New System.Windows.Forms.Label()
        Me.txtAverageAge = New System.Windows.Forms.TextBox()
        Me.lblAverageAge = New System.Windows.Forms.Label()
        Me.txtTotalOtherGender = New System.Windows.Forms.TextBox()
        Me.lblTotalOtherGender = New System.Windows.Forms.Label()
        Me.gboFinancialTotals = New System.Windows.Forms.GroupBox()
        Me.lblInventoryInfo = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.gboSameState.SuspendLayout()
        Me.gboDemographicTotals.SuspendLayout()
        Me.gboFinancialTotals.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack.ForeColor = System.Drawing.Color.Yellow
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 33)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(2, 38)
        Me.lblState.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(101, 20)
        Me.lblState.TabIndex = 17
        Me.lblState.Text = "Select State:"
        '
        'cboState
        '
        Me.cboState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboState.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"Alabama - AL", "Alaska - AK", "Arizona - AZ", "Arkansas - AR", "California - CA", "Colorado - CO", "Connecticut - CT", "Delaware - DE", "Florida - FL", "Georgia - GA", "Hawaii - HI", "Idaho - ID", "Illinois - IL", "Indiana - IN", "Iowa - IA", "Kansas - KS", "Kentucky - KY", "Louisiana - LA", "Maine - ME", "Maryland - MD", "Massachusetts - MA", "Michigan - MI", "Minnesota - MN", "Mississippi - MS", "Missouri - MO", "Montana - MT", "Nebraska - NE", "Nevada - NV", "New Hampshire - NH", "New Jersey - NJ", "New Mexico - NM", "New York - NY", "North Carolina - NC", "North Dakota - ND", "Ohio - OH", "Oklahoma - OK", "Oregon - OR", "Pennsylvania - PA", "Rhode Island - RI", "South Carolina - SC", "South Dakota - SD", "Tennessee - TN", "Texas - TX", "Utah - UT", "Vermont - VT", "Virginia - VA", "Washington - WA", "West Virginia - WV", "Wisconsin - WI", "Wyoming - WY"})
        Me.cboState.Location = New System.Drawing.Point(102, 35)
        Me.cboState.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(245, 28)
        Me.cboState.TabIndex = 16
        '
        'gboSameState
        '
        Me.gboSameState.BackColor = System.Drawing.Color.Transparent
        Me.gboSameState.Controls.Add(Me.txtStateTotal)
        Me.gboSameState.Controls.Add(Me.cboState)
        Me.gboSameState.Controls.Add(Me.lblState)
        Me.gboSameState.Location = New System.Drawing.Point(13, 51)
        Me.gboSameState.Name = "gboSameState"
        Me.gboSameState.Size = New System.Drawing.Size(361, 137)
        Me.gboSameState.TabIndex = 18
        Me.gboSameState.TabStop = False
        Me.gboSameState.Text = "Total Customers Living in the Same State:"
        '
        'txtStateTotal
        '
        Me.txtStateTotal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtStateTotal.Location = New System.Drawing.Point(6, 82)
        Me.txtStateTotal.Name = "txtStateTotal"
        Me.txtStateTotal.ReadOnly = True
        Me.txtStateTotal.Size = New System.Drawing.Size(342, 26)
        Me.txtStateTotal.TabIndex = 18
        '
        'txtTotalCustomers
        '
        Me.txtTotalCustomers.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalCustomers.Location = New System.Drawing.Point(158, 32)
        Me.txtTotalCustomers.Name = "txtTotalCustomers"
        Me.txtTotalCustomers.ReadOnly = True
        Me.txtTotalCustomers.Size = New System.Drawing.Size(229, 26)
        Me.txtTotalCustomers.TabIndex = 20
        Me.txtTotalCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Location = New System.Drawing.Point(27, 33)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(129, 20)
        Me.lblTotalCustomers.TabIndex = 21
        Me.lblTotalCustomers.Text = "Total Customers:"
        '
        'lblTotalMales
        '
        Me.lblTotalMales.AutoSize = True
        Me.lblTotalMales.Location = New System.Drawing.Point(62, 64)
        Me.lblTotalMales.Name = "lblTotalMales"
        Me.lblTotalMales.Size = New System.Drawing.Size(94, 20)
        Me.lblTotalMales.TabIndex = 23
        Me.lblTotalMales.Text = "Total Males:"
        '
        'txtTotalMales
        '
        Me.txtTotalMales.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalMales.Location = New System.Drawing.Point(158, 63)
        Me.txtTotalMales.Name = "txtTotalMales"
        Me.txtTotalMales.ReadOnly = True
        Me.txtTotalMales.Size = New System.Drawing.Size(229, 26)
        Me.txtTotalMales.TabIndex = 22
        Me.txtTotalMales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalFemales
        '
        Me.lblTotalFemales.AutoSize = True
        Me.lblTotalFemales.Location = New System.Drawing.Point(41, 95)
        Me.lblTotalFemales.Name = "lblTotalFemales"
        Me.lblTotalFemales.Size = New System.Drawing.Size(113, 20)
        Me.lblTotalFemales.TabIndex = 25
        Me.lblTotalFemales.Text = "Total Females:"
        '
        'txtTotalFemales
        '
        Me.txtTotalFemales.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalFemales.Location = New System.Drawing.Point(158, 94)
        Me.txtTotalFemales.Name = "txtTotalFemales"
        Me.txtTotalFemales.ReadOnly = True
        Me.txtTotalFemales.Size = New System.Drawing.Size(229, 26)
        Me.txtTotalFemales.TabIndex = 24
        Me.txtTotalFemales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalTax
        '
        Me.lblTotalTax.AutoSize = True
        Me.lblTotalTax.Location = New System.Drawing.Point(66, 71)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(77, 20)
        Me.lblTotalTax.TabIndex = 27
        Me.lblTotalTax.Text = "Total Tax:"
        '
        'txtTotalTax
        '
        Me.txtTotalTax.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalTax.Location = New System.Drawing.Point(148, 68)
        Me.txtTotalTax.Name = "txtTotalTax"
        Me.txtTotalTax.ReadOnly = True
        Me.txtTotalTax.Size = New System.Drawing.Size(192, 26)
        Me.txtTotalTax.TabIndex = 26
        Me.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalGrossRevenue
        '
        Me.lblTotalGrossRevenue.AutoSize = True
        Me.lblTotalGrossRevenue.Location = New System.Drawing.Point(24, 40)
        Me.lblTotalGrossRevenue.Name = "lblTotalGrossRevenue"
        Me.lblTotalGrossRevenue.Size = New System.Drawing.Size(124, 20)
        Me.lblTotalGrossRevenue.TabIndex = 29
        Me.lblTotalGrossRevenue.Text = "Gross Revenue:"
        '
        'txtTotalGrossRevenue
        '
        Me.txtTotalGrossRevenue.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalGrossRevenue.Location = New System.Drawing.Point(148, 37)
        Me.txtTotalGrossRevenue.Name = "txtTotalGrossRevenue"
        Me.txtTotalGrossRevenue.ReadOnly = True
        Me.txtTotalGrossRevenue.Size = New System.Drawing.Size(192, 26)
        Me.txtTotalGrossRevenue.TabIndex = 28
        Me.txtTotalGrossRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalNetRevenue
        '
        Me.lblTotalNetRevenue.AutoSize = True
        Me.lblTotalNetRevenue.Location = New System.Drawing.Point(41, 100)
        Me.lblTotalNetRevenue.Name = "lblTotalNetRevenue"
        Me.lblTotalNetRevenue.Size = New System.Drawing.Size(106, 20)
        Me.lblTotalNetRevenue.TabIndex = 31
        Me.lblTotalNetRevenue.Text = "Net Revenue:"
        '
        'txtTotalNetRevenue
        '
        Me.txtTotalNetRevenue.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalNetRevenue.Location = New System.Drawing.Point(148, 99)
        Me.txtTotalNetRevenue.Name = "txtTotalNetRevenue"
        Me.txtTotalNetRevenue.ReadOnly = True
        Me.txtTotalNetRevenue.Size = New System.Drawing.Size(192, 26)
        Me.txtTotalNetRevenue.TabIndex = 30
        Me.txtTotalNetRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gboDemographicTotals
        '
        Me.gboDemographicTotals.BackColor = System.Drawing.Color.Transparent
        Me.gboDemographicTotals.Controls.Add(Me.txtOver21)
        Me.gboDemographicTotals.Controls.Add(Me.lblOver21)
        Me.gboDemographicTotals.Controls.Add(Me.txtUnder21)
        Me.gboDemographicTotals.Controls.Add(Me.lblUnder21)
        Me.gboDemographicTotals.Controls.Add(Me.txtAverageAge)
        Me.gboDemographicTotals.Controls.Add(Me.lblAverageAge)
        Me.gboDemographicTotals.Controls.Add(Me.txtTotalOtherGender)
        Me.gboDemographicTotals.Controls.Add(Me.lblTotalOtherGender)
        Me.gboDemographicTotals.Controls.Add(Me.lblTotalCustomers)
        Me.gboDemographicTotals.Controls.Add(Me.txtTotalCustomers)
        Me.gboDemographicTotals.Controls.Add(Me.txtTotalMales)
        Me.gboDemographicTotals.Controls.Add(Me.lblTotalMales)
        Me.gboDemographicTotals.Controls.Add(Me.txtTotalFemales)
        Me.gboDemographicTotals.Controls.Add(Me.lblTotalFemales)
        Me.gboDemographicTotals.Location = New System.Drawing.Point(380, 51)
        Me.gboDemographicTotals.Name = "gboDemographicTotals"
        Me.gboDemographicTotals.Size = New System.Drawing.Size(390, 300)
        Me.gboDemographicTotals.TabIndex = 32
        Me.gboDemographicTotals.TabStop = False
        Me.gboDemographicTotals.Text = "Demographics:"
        '
        'txtOver21
        '
        Me.txtOver21.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtOver21.Location = New System.Drawing.Point(158, 260)
        Me.txtOver21.Name = "txtOver21"
        Me.txtOver21.ReadOnly = True
        Me.txtOver21.Size = New System.Drawing.Size(229, 26)
        Me.txtOver21.TabIndex = 32
        Me.txtOver21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblOver21
        '
        Me.lblOver21.AutoSize = True
        Me.lblOver21.Location = New System.Drawing.Point(13, 261)
        Me.lblOver21.Name = "lblOver21"
        Me.lblOver21.Size = New System.Drawing.Size(140, 20)
        Me.lblOver21.TabIndex = 33
        Me.lblOver21.Text = "Total Over Age 21:"
        '
        'txtUnder21
        '
        Me.txtUnder21.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtUnder21.Location = New System.Drawing.Point(158, 229)
        Me.txtUnder21.Name = "txtUnder21"
        Me.txtUnder21.ReadOnly = True
        Me.txtUnder21.Size = New System.Drawing.Size(229, 26)
        Me.txtUnder21.TabIndex = 30
        Me.txtUnder21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUnder21
        '
        Me.lblUnder21.AutoSize = True
        Me.lblUnder21.Location = New System.Drawing.Point(3, 230)
        Me.lblUnder21.Name = "lblUnder21"
        Me.lblUnder21.Size = New System.Drawing.Size(151, 20)
        Me.lblUnder21.TabIndex = 31
        Me.lblUnder21.Text = "Total Under Age 21:"
        '
        'txtAverageAge
        '
        Me.txtAverageAge.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtAverageAge.Location = New System.Drawing.Point(158, 198)
        Me.txtAverageAge.Name = "txtAverageAge"
        Me.txtAverageAge.ReadOnly = True
        Me.txtAverageAge.Size = New System.Drawing.Size(229, 26)
        Me.txtAverageAge.TabIndex = 28
        Me.txtAverageAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAverageAge
        '
        Me.lblAverageAge.AutoSize = True
        Me.lblAverageAge.Location = New System.Drawing.Point(47, 199)
        Me.lblAverageAge.Name = "lblAverageAge"
        Me.lblAverageAge.Size = New System.Drawing.Size(105, 20)
        Me.lblAverageAge.TabIndex = 29
        Me.lblAverageAge.Text = "Average Age:"
        '
        'txtTotalOtherGender
        '
        Me.txtTotalOtherGender.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotalOtherGender.Location = New System.Drawing.Point(158, 125)
        Me.txtTotalOtherGender.Name = "txtTotalOtherGender"
        Me.txtTotalOtherGender.ReadOnly = True
        Me.txtTotalOtherGender.Size = New System.Drawing.Size(229, 26)
        Me.txtTotalOtherGender.TabIndex = 26
        Me.txtTotalOtherGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalOtherGender
        '
        Me.lblTotalOtherGender.AutoSize = True
        Me.lblTotalOtherGender.Location = New System.Drawing.Point(62, 128)
        Me.lblTotalOtherGender.Name = "lblTotalOtherGender"
        Me.lblTotalOtherGender.Size = New System.Drawing.Size(92, 20)
        Me.lblTotalOtherGender.TabIndex = 27
        Me.lblTotalOtherGender.Text = "Total Other:"
        '
        'gboFinancialTotals
        '
        Me.gboFinancialTotals.BackColor = System.Drawing.Color.Transparent
        Me.gboFinancialTotals.Controls.Add(Me.txtTotalTax)
        Me.gboFinancialTotals.Controls.Add(Me.lblTotalTax)
        Me.gboFinancialTotals.Controls.Add(Me.lblTotalNetRevenue)
        Me.gboFinancialTotals.Controls.Add(Me.txtTotalGrossRevenue)
        Me.gboFinancialTotals.Controls.Add(Me.txtTotalNetRevenue)
        Me.gboFinancialTotals.Controls.Add(Me.lblTotalGrossRevenue)
        Me.gboFinancialTotals.ForeColor = System.Drawing.Color.Black
        Me.gboFinancialTotals.Location = New System.Drawing.Point(13, 201)
        Me.gboFinancialTotals.Name = "gboFinancialTotals"
        Me.gboFinancialTotals.Size = New System.Drawing.Size(346, 150)
        Me.gboFinancialTotals.TabIndex = 33
        Me.gboFinancialTotals.TabStop = False
        Me.gboFinancialTotals.Text = "Financial Data:"
        '
        'lblInventoryInfo
        '
        Me.lblInventoryInfo.AutoSize = True
        Me.lblInventoryInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInventoryInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInventoryInfo.Location = New System.Drawing.Point(7, 363)
        Me.lblInventoryInfo.Name = "lblInventoryInfo"
        Me.lblInventoryInfo.Size = New System.Drawing.Size(163, 20)
        Me.lblInventoryInfo.TabIndex = 34
        Me.lblInventoryInfo.Text = "Inventory Information:"
        '
        'dgvInventory
        '
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(10, 393)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowTemplate.Height = 40
        Me.dgvInventory.Size = New System.Drawing.Size(760, 182)
        Me.dgvInventory.TabIndex = 35
        '
        'frmDatabaseTotals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(780, 582)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.lblInventoryInfo)
        Me.Controls.Add(Me.gboFinancialTotals)
        Me.Controls.Add(Me.gboDemographicTotals)
        Me.Controls.Add(Me.gboSameState)
        Me.Controls.Add(Me.btnBack)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDatabaseTotals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Totals"
        Me.gboSameState.ResumeLayout(False)
        Me.gboSameState.PerformLayout()
        Me.gboDemographicTotals.ResumeLayout(False)
        Me.gboDemographicTotals.PerformLayout()
        Me.gboFinancialTotals.ResumeLayout(False)
        Me.gboFinancialTotals.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblState As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents gboSameState As GroupBox
    Friend WithEvents txtStateTotal As TextBox
    Friend WithEvents txtTotalCustomers As TextBox
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents lblTotalMales As Label
    Friend WithEvents txtTotalMales As TextBox
    Friend WithEvents lblTotalFemales As Label
    Friend WithEvents txtTotalFemales As TextBox
    Friend WithEvents lblTotalTax As Label
    Friend WithEvents txtTotalTax As TextBox
    Friend WithEvents lblTotalGrossRevenue As Label
    Friend WithEvents txtTotalGrossRevenue As TextBox
    Friend WithEvents lblTotalNetRevenue As Label
    Friend WithEvents txtTotalNetRevenue As TextBox
    Friend WithEvents gboDemographicTotals As GroupBox
    Friend WithEvents gboFinancialTotals As GroupBox
    Friend WithEvents lblInventoryInfo As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents txtTotalOtherGender As TextBox
    Friend WithEvents lblTotalOtherGender As Label
    Friend WithEvents txtOver21 As TextBox
    Friend WithEvents lblOver21 As Label
    Friend WithEvents txtUnder21 As TextBox
    Friend WithEvents lblUnder21 As Label
    Friend WithEvents txtAverageAge As TextBox
    Friend WithEvents lblAverageAge As Label
End Class
