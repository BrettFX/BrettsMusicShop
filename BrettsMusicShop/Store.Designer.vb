<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStore))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemSignOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemInstructions = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuItemSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrass = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWoodwind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPercussion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAllInstruments = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.gboItemDetails = New System.Windows.Forms.GroupBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.nudQty = New System.Windows.Forms.NumericUpDown()
        Me.txtItemCategory = New System.Windows.Forms.TextBox()
        Me.lblItemCategory = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemWeight = New System.Windows.Forms.TextBox()
        Me.lblItemWeight = New System.Windows.Forms.Label()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.lblItemPrice = New System.Windows.Forms.Label()
        Me.txtItemSKU = New System.Windows.Forms.TextBox()
        Me.lblItemSKU = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblStringInstruments = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.txtNumItems = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblNumItems = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gboItemDetails.SuspendLayout()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Stencil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem, Me.menuItemSort})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(15, 5, 0, 5)
        Me.MenuStrip1.Size = New System.Drawing.Size(2155, 49)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemSignOut})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(90, 39)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'menuItemSignOut
        '
        Me.menuItemSignOut.Name = "menuItemSignOut"
        Me.menuItemSignOut.Size = New System.Drawing.Size(260, 46)
        Me.menuItemSignOut.Text = "&Sign out"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemInstructions})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(103, 39)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'menuItemInstructions
        '
        Me.menuItemInstructions.Name = "menuItemInstructions"
        Me.menuItemInstructions.Size = New System.Drawing.Size(339, 46)
        Me.menuItemInstructions.Text = "&Instructions"
        '
        'menuItemSort
        '
        Me.menuItemSort.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStrings, Me.mnuBrass, Me.mnuWoodwind, Me.mnuPercussion, Me.mnuAllInstruments})
        Me.menuItemSort.Name = "menuItemSort"
        Me.menuItemSort.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuItemSort.ShowShortcutKeys = False
        Me.menuItemSort.Size = New System.Drawing.Size(148, 39)
        Me.menuItemSort.Text = "&Sort By"
        '
        'mnuStrings
        '
        Me.mnuStrings.Name = "mnuStrings"
        Me.mnuStrings.Size = New System.Drawing.Size(520, 46)
        Me.mnuStrings.Text = "String Instruments"
        '
        'mnuBrass
        '
        Me.mnuBrass.Name = "mnuBrass"
        Me.mnuBrass.Size = New System.Drawing.Size(520, 46)
        Me.mnuBrass.Text = "Brass Instruments"
        '
        'mnuWoodwind
        '
        Me.mnuWoodwind.Name = "mnuWoodwind"
        Me.mnuWoodwind.Size = New System.Drawing.Size(520, 46)
        Me.mnuWoodwind.Text = "Woodwind Instruments"
        '
        'mnuPercussion
        '
        Me.mnuPercussion.Name = "mnuPercussion"
        Me.mnuPercussion.Size = New System.Drawing.Size(520, 46)
        Me.mnuPercussion.Text = "Percussion Instruments"
        '
        'mnuAllInstruments
        '
        Me.mnuAllInstruments.Checked = True
        Me.mnuAllInstruments.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAllInstruments.Name = "mnuAllInstruments"
        Me.mnuAllInstruments.Size = New System.Drawing.Size(520, 46)
        Me.mnuAllInstruments.Text = "All Instruments"
        '
        'lstCart
        '
        Me.lstCart.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lstCart.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 42
        Me.lstCart.Location = New System.Drawing.Point(770, 122)
        Me.lstCart.Margin = New System.Windows.Forms.Padding(8)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(1349, 550)
        Me.lstCart.TabIndex = 14
        Me.lstCart.TabStop = False
        '
        'btnPurchase
        '
        Me.btnPurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.ForeColor = System.Drawing.Color.Yellow
        Me.btnPurchase.Location = New System.Drawing.Point(1415, 1300)
        Me.btnPurchase.Margin = New System.Windows.Forms.Padding(8)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(710, 80)
        Me.btnPurchase.TabIndex = 15
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = False
        '
        'gboItemDetails
        '
        Me.gboItemDetails.Controls.Add(Me.lblQty)
        Me.gboItemDetails.Controls.Add(Me.nudQty)
        Me.gboItemDetails.Controls.Add(Me.txtItemCategory)
        Me.gboItemDetails.Controls.Add(Me.lblItemCategory)
        Me.gboItemDetails.Controls.Add(Me.btnAddToCart)
        Me.gboItemDetails.Controls.Add(Me.txtOnHand)
        Me.gboItemDetails.Controls.Add(Me.Label1)
        Me.gboItemDetails.Controls.Add(Me.txtItemWeight)
        Me.gboItemDetails.Controls.Add(Me.lblItemWeight)
        Me.gboItemDetails.Controls.Add(Me.txtItemPrice)
        Me.gboItemDetails.Controls.Add(Me.lblItemPrice)
        Me.gboItemDetails.Controls.Add(Me.txtItemSKU)
        Me.gboItemDetails.Controls.Add(Me.lblItemSKU)
        Me.gboItemDetails.Controls.Add(Me.txtItemName)
        Me.gboItemDetails.Controls.Add(Me.lblItemName)
        Me.gboItemDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboItemDetails.Location = New System.Drawing.Point(32, 70)
        Me.gboItemDetails.Margin = New System.Windows.Forms.Padding(8)
        Me.gboItemDetails.Name = "gboItemDetails"
        Me.gboItemDetails.Padding = New System.Windows.Forms.Padding(8)
        Me.gboItemDetails.Size = New System.Drawing.Size(715, 860)
        Me.gboItemDetails.TabIndex = 16
        Me.gboItemDetails.TabStop = False
        Me.gboItemDetails.Text = "Item Details"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(92, 630)
        Me.lblQty.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(179, 46)
        Me.lblQty.TabIndex = 29
        Me.lblQty.Text = "Quantity:"
        '
        'nudQty
        '
        Me.nudQty.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.nudQty.Location = New System.Drawing.Point(278, 625)
        Me.nudQty.Margin = New System.Windows.Forms.Padding(8)
        Me.nudQty.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.ReadOnly = True
        Me.nudQty.Size = New System.Drawing.Size(388, 53)
        Me.nudQty.TabIndex = 28
        Me.nudQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItemCategory
        '
        Me.txtItemCategory.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtItemCategory.Location = New System.Drawing.Point(278, 162)
        Me.txtItemCategory.Margin = New System.Windows.Forms.Padding(8)
        Me.txtItemCategory.Name = "txtItemCategory"
        Me.txtItemCategory.ReadOnly = True
        Me.txtItemCategory.Size = New System.Drawing.Size(382, 53)
        Me.txtItemCategory.TabIndex = 27
        Me.txtItemCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemCategory
        '
        Me.lblItemCategory.AutoSize = True
        Me.lblItemCategory.Location = New System.Drawing.Point(5, 170)
        Me.lblItemCategory.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblItemCategory.Name = "lblItemCategory"
        Me.lblItemCategory.Size = New System.Drawing.Size(280, 46)
        Me.lblItemCategory.TabIndex = 26
        Me.lblItemCategory.Text = "Item Category:"
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddToCart.Enabled = False
        Me.btnAddToCart.ForeColor = System.Drawing.Color.Yellow
        Me.btnAddToCart.Location = New System.Drawing.Point(35, 762)
        Me.btnAddToCart.Margin = New System.Windows.Forms.Padding(8)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(630, 82)
        Me.btnAddToCart.TabIndex = 17
        Me.btnAddToCart.Text = "Add to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'txtOnHand
        '
        Me.txtOnHand.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtOnHand.Location = New System.Drawing.Point(278, 522)
        Me.txtOnHand.Margin = New System.Windows.Forms.Padding(8)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.ReadOnly = True
        Me.txtOnHand.Size = New System.Drawing.Size(382, 53)
        Me.txtOnHand.TabIndex = 24
        Me.txtOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 540)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 46)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "On Hand:"
        '
        'txtItemWeight
        '
        Me.txtItemWeight.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtItemWeight.Location = New System.Drawing.Point(278, 432)
        Me.txtItemWeight.Margin = New System.Windows.Forms.Padding(8)
        Me.txtItemWeight.Name = "txtItemWeight"
        Me.txtItemWeight.ReadOnly = True
        Me.txtItemWeight.Size = New System.Drawing.Size(382, 53)
        Me.txtItemWeight.TabIndex = 22
        Me.txtItemWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemWeight
        '
        Me.lblItemWeight.AutoSize = True
        Me.lblItemWeight.Location = New System.Drawing.Point(28, 440)
        Me.lblItemWeight.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblItemWeight.Name = "lblItemWeight"
        Me.lblItemWeight.Size = New System.Drawing.Size(242, 46)
        Me.lblItemWeight.TabIndex = 21
        Me.lblItemWeight.Text = "Item Weight:"
        '
        'txtItemPrice
        '
        Me.txtItemPrice.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtItemPrice.Location = New System.Drawing.Point(278, 342)
        Me.txtItemPrice.Margin = New System.Windows.Forms.Padding(8)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.ReadOnly = True
        Me.txtItemPrice.Size = New System.Drawing.Size(382, 53)
        Me.txtItemPrice.TabIndex = 20
        Me.txtItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemPrice
        '
        Me.lblItemPrice.AutoSize = True
        Me.lblItemPrice.Location = New System.Drawing.Point(62, 350)
        Me.lblItemPrice.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblItemPrice.Name = "lblItemPrice"
        Me.lblItemPrice.Size = New System.Drawing.Size(210, 46)
        Me.lblItemPrice.TabIndex = 19
        Me.lblItemPrice.Text = "Item Price:"
        '
        'txtItemSKU
        '
        Me.txtItemSKU.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtItemSKU.Location = New System.Drawing.Point(278, 68)
        Me.txtItemSKU.Margin = New System.Windows.Forms.Padding(8)
        Me.txtItemSKU.Name = "txtItemSKU"
        Me.txtItemSKU.ReadOnly = True
        Me.txtItemSKU.Size = New System.Drawing.Size(382, 53)
        Me.txtItemSKU.TabIndex = 18
        Me.txtItemSKU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemSKU
        '
        Me.lblItemSKU.AutoSize = True
        Me.lblItemSKU.Location = New System.Drawing.Point(80, 75)
        Me.lblItemSKU.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblItemSKU.Name = "lblItemSKU"
        Me.lblItemSKU.Size = New System.Drawing.Size(200, 46)
        Me.lblItemSKU.TabIndex = 17
        Me.lblItemSKU.Text = "Item SKU:"
        '
        'txtItemName
        '
        Me.txtItemName.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtItemName.Location = New System.Drawing.Point(278, 252)
        Me.txtItemName.Margin = New System.Windows.Forms.Padding(8)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(382, 53)
        Me.txtItemName.TabIndex = 1
        Me.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(55, 260)
        Me.lblItemName.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(224, 46)
        Me.lblItemName.TabIndex = 0
        Me.lblItemName.Text = "Item Name:"
        '
        'lblStringInstruments
        '
        Me.lblStringInstruments.AutoSize = True
        Me.lblStringInstruments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStringInstruments.Location = New System.Drawing.Point(25, 938)
        Me.lblStringInstruments.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblStringInstruments.Name = "lblStringInstruments"
        Me.lblStringInstruments.Size = New System.Drawing.Size(193, 46)
        Me.lblStringInstruments.TabIndex = 18
        Me.lblStringInstruments.Text = "Inventory:"
        '
        'dgvInventory
        '
        Me.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvInventory.Location = New System.Drawing.Point(32, 992)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInventory.MultiSelect = False
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowTemplate.Height = 40
        Me.dgvInventory.Size = New System.Drawing.Size(1338, 385)
        Me.dgvInventory.TabIndex = 23
        '
        'lblCart
        '
        Me.lblCart.AutoSize = True
        Me.lblCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.Location = New System.Drawing.Point(762, 70)
        Me.lblCart.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(106, 46)
        Me.lblCart.TabIndex = 24
        Me.lblCart.Text = "Cart:"
        '
        'txtNumItems
        '
        Me.txtNumItems.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtNumItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumItems.Location = New System.Drawing.Point(1875, 905)
        Me.txtNumItems.Margin = New System.Windows.Forms.Padding(8)
        Me.txtNumItems.Name = "txtNumItems"
        Me.txtNumItems.ReadOnly = True
        Me.txtNumItems.Size = New System.Drawing.Size(244, 53)
        Me.txtNumItems.TabIndex = 25
        Me.txtNumItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(1875, 998)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(8)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(244, 53)
        Me.txtSubTotal.TabIndex = 26
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1875, 1180)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(8)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(244, 53)
        Me.txtTotal.TabIndex = 27
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumItems
        '
        Me.lblNumItems.AutoSize = True
        Me.lblNumItems.BackColor = System.Drawing.Color.Transparent
        Me.lblNumItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumItems.Location = New System.Drawing.Point(1725, 912)
        Me.lblNumItems.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblNumItems.Name = "lblNumItems"
        Me.lblNumItems.Size = New System.Drawing.Size(127, 46)
        Me.lblNumItems.TabIndex = 28
        Me.lblNumItems.Text = "Items:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(1682, 1005)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(178, 46)
        Me.lblSubTotal.TabIndex = 29
        Me.lblSubTotal.Text = "Subtotal:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(1732, 1185)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 46)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "Total:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.BackColor = System.Drawing.Color.Transparent
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(1680, 1092)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(192, 46)
        Me.lblTax.TabIndex = 32
        Me.lblTax.Text = "Tax (6%):"
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(1875, 1090)
        Me.txtTax.Margin = New System.Windows.Forms.Padding(8)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(244, 53)
        Me.txtTax.TabIndex = 31
        Me.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRemoveItem.Enabled = False
        Me.btnRemoveItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.Yellow
        Me.btnRemoveItem.Location = New System.Drawing.Point(770, 695)
        Me.btnRemoveItem.Margin = New System.Windows.Forms.Padding(8)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(1350, 82)
        Me.btnRemoveItem.TabIndex = 30
        Me.btnRemoveItem.Text = "Remove Item(s)"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'frmStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(240.0!, 240.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2155, 1408)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblNumItems)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.txtNumItems)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.lblStringInstruments)
        Me.Controls.Add(Me.gboItemDetails)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.Name = "frmStore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Brett's Music Shop!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gboItemDetails.ResumeLayout(False)
        Me.gboItemDetails.PerformLayout()
        CType(Me.nudQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemSignOut As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuItemInstructions As ToolStripMenuItem
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnPurchase As Button
    Friend WithEvents gboItemDetails As GroupBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents txtOnHand As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemWeight As TextBox
    Friend WithEvents lblItemWeight As Label
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents lblItemPrice As Label
    Friend WithEvents txtItemSKU As TextBox
    Friend WithEvents lblItemSKU As Label
    Friend WithEvents lblStringInstruments As Label
    Friend WithEvents txtItemCategory As TextBox
    Friend WithEvents lblItemCategory As Label
    Friend WithEvents menuItemSort As ToolStripMenuItem
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents mnuStrings As ToolStripMenuItem
    Friend WithEvents mnuBrass As ToolStripMenuItem
    Friend WithEvents mnuWoodwind As ToolStripMenuItem
    Friend WithEvents mnuPercussion As ToolStripMenuItem
    Friend WithEvents mnuAllInstruments As ToolStripMenuItem
    Friend WithEvents lblCart As Label
    Friend WithEvents txtNumItems As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblNumItems As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents btnRemoveItem As Button
End Class
