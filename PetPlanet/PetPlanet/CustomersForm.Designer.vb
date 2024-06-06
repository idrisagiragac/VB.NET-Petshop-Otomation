<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomersForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SoldBtn = New FontAwesome.Sharp.IconButton()
        Me.SaleBtn = New FontAwesome.Sharp.IconButton()
        Me.SupplierBtn = New FontAwesome.Sharp.IconButton()
        Me.PersonelBtn = New FontAwesome.Sharp.IconButton()
        Me.CustomerBtn = New FontAwesome.Sharp.IconButton()
        Me.PetsBtn = New FontAwesome.Sharp.IconButton()
        Me.ProductBtn = New FontAwesome.Sharp.IconButton()
        Me.HomeBtn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.btnFilter = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.musteridata = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BtnTemizle = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.MüsAdr = New Guna.UI.WinForms.GunaTextBox()
        Me.MusAdrLlb = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MüsEPos = New Guna.UI.WinForms.GunaTextBox()
        Me.MusEPosLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MüsTel = New Guna.UI.WinForms.GunaTextBox()
        Me.MusTelLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayvanAdıMus = New Guna.UI.WinForms.GunaTextBox()
        Me.MusHayvanAdıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MüsSoyadı = New Guna.UI.WinForms.GunaTextBox()
        Me.MusSoyadıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MüsAdı = New Guna.UI.WinForms.GunaTextBox()
        Me.MusAdıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.MüsGünBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.MüsSilBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.MüsEkleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.musteridata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel1.Controls.Add(Me.SoldBtn)
        Me.Panel1.Controls.Add(Me.SaleBtn)
        Me.Panel1.Controls.Add(Me.SupplierBtn)
        Me.Panel1.Controls.Add(Me.PersonelBtn)
        Me.Panel1.Controls.Add(Me.CustomerBtn)
        Me.Panel1.Controls.Add(Me.PetsBtn)
        Me.Panel1.Controls.Add(Me.ProductBtn)
        Me.Panel1.Controls.Add(Me.HomeBtn)
        Me.Panel1.Controls.Add(Me.PanelLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 777)
        Me.Panel1.TabIndex = 1
        '
        'SoldBtn
        '
        Me.SoldBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SoldBtn.FlatAppearance.BorderSize = 0
        Me.SoldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SoldBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SoldBtn.IconChar = FontAwesome.Sharp.IconChar.ShieldDog
        Me.SoldBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SoldBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SoldBtn.IconSize = 32
        Me.SoldBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SoldBtn.Location = New System.Drawing.Point(0, 527)
        Me.SoldBtn.Name = "SoldBtn"
        Me.SoldBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.SoldBtn.Size = New System.Drawing.Size(248, 61)
        Me.SoldBtn.TabIndex = 8
        Me.SoldBtn.Text = "Satılan Hayvanlar"
        Me.SoldBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SoldBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SoldBtn.UseVisualStyleBackColor = True
        '
        'SaleBtn
        '
        Me.SaleBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SaleBtn.FlatAppearance.BorderSize = 0
        Me.SaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaleBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SaleBtn.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd
        Me.SaleBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaleBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SaleBtn.IconSize = 32
        Me.SaleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaleBtn.Location = New System.Drawing.Point(0, 466)
        Me.SaleBtn.Name = "SaleBtn"
        Me.SaleBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.SaleBtn.Size = New System.Drawing.Size(248, 61)
        Me.SaleBtn.TabIndex = 6
        Me.SaleBtn.Text = "Alış ve Satış İşlemleri"
        Me.SaleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SaleBtn.UseVisualStyleBackColor = True
        '
        'SupplierBtn
        '
        Me.SupplierBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SupplierBtn.FlatAppearance.BorderSize = 0
        Me.SupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SupplierBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SupplierBtn.IconChar = FontAwesome.Sharp.IconChar.TruckFast
        Me.SupplierBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SupplierBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SupplierBtn.IconSize = 32
        Me.SupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SupplierBtn.Location = New System.Drawing.Point(0, 405)
        Me.SupplierBtn.Name = "SupplierBtn"
        Me.SupplierBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.SupplierBtn.Size = New System.Drawing.Size(248, 61)
        Me.SupplierBtn.TabIndex = 5
        Me.SupplierBtn.Text = "Tedarikçiler"
        Me.SupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SupplierBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SupplierBtn.UseVisualStyleBackColor = True
        '
        'PersonelBtn
        '
        Me.PersonelBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PersonelBtn.FlatAppearance.BorderSize = 0
        Me.PersonelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PersonelBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.PersonelBtn.IconChar = FontAwesome.Sharp.IconChar.UserGroup
        Me.PersonelBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PersonelBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PersonelBtn.IconSize = 32
        Me.PersonelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PersonelBtn.Location = New System.Drawing.Point(0, 344)
        Me.PersonelBtn.Name = "PersonelBtn"
        Me.PersonelBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.PersonelBtn.Size = New System.Drawing.Size(248, 61)
        Me.PersonelBtn.TabIndex = 4
        Me.PersonelBtn.Text = "Personeller"
        Me.PersonelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PersonelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PersonelBtn.UseVisualStyleBackColor = True
        '
        'CustomerBtn
        '
        Me.CustomerBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomerBtn.FlatAppearance.BorderSize = 0
        Me.CustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomerBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.CustomerBtn.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.CustomerBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomerBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.CustomerBtn.IconSize = 32
        Me.CustomerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomerBtn.Location = New System.Drawing.Point(0, 283)
        Me.CustomerBtn.Name = "CustomerBtn"
        Me.CustomerBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.CustomerBtn.Size = New System.Drawing.Size(248, 61)
        Me.CustomerBtn.TabIndex = 3
        Me.CustomerBtn.Text = "Müşteriler"
        Me.CustomerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CustomerBtn.UseVisualStyleBackColor = True
        '
        'PetsBtn
        '
        Me.PetsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.PetsBtn.FlatAppearance.BorderSize = 0
        Me.PetsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PetsBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.PetsBtn.IconChar = FontAwesome.Sharp.IconChar.Paw
        Me.PetsBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PetsBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.PetsBtn.IconSize = 32
        Me.PetsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PetsBtn.Location = New System.Drawing.Point(0, 222)
        Me.PetsBtn.Name = "PetsBtn"
        Me.PetsBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.PetsBtn.Size = New System.Drawing.Size(248, 61)
        Me.PetsBtn.TabIndex = 2
        Me.PetsBtn.Text = "Hayvanlar"
        Me.PetsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PetsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PetsBtn.UseVisualStyleBackColor = True
        '
        'ProductBtn
        '
        Me.ProductBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductBtn.FlatAppearance.BorderSize = 0
        Me.ProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.ProductBtn.IconChar = FontAwesome.Sharp.IconChar.Bone
        Me.ProductBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ProductBtn.IconSize = 32
        Me.ProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductBtn.Location = New System.Drawing.Point(0, 161)
        Me.ProductBtn.Name = "ProductBtn"
        Me.ProductBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.ProductBtn.Size = New System.Drawing.Size(248, 61)
        Me.ProductBtn.TabIndex = 1
        Me.ProductBtn.Text = "Ürünler"
        Me.ProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ProductBtn.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.HomeBtn.FlatAppearance.BorderSize = 0
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        Me.HomeBtn.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.HomeBtn.IconSize = 32
        Me.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBtn.Location = New System.Drawing.Point(0, 100)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Padding = New System.Windows.Forms.Padding(11, 0, 22, 0)
        Me.HomeBtn.Size = New System.Drawing.Size(248, 61)
        Me.HomeBtn.TabIndex = 0
        Me.HomeBtn.Text = "Ana Sayfa"
        Me.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.btnHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(248, 100)
        Me.PanelLogo.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(248, 104)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 0
        Me.btnHome.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.Ivory
        Me.PanelDesktop.Controls.Add(Me.btnFilter)
        Me.PanelDesktop.Controls.Add(Me.musteridata)
        Me.PanelDesktop.Controls.Add(Me.BtnTemizle)
        Me.PanelDesktop.Controls.Add(Me.MüsAdr)
        Me.PanelDesktop.Controls.Add(Me.MusAdrLlb)
        Me.PanelDesktop.Controls.Add(Me.MüsEPos)
        Me.PanelDesktop.Controls.Add(Me.MusEPosLbl)
        Me.PanelDesktop.Controls.Add(Me.MüsTel)
        Me.PanelDesktop.Controls.Add(Me.MusTelLbl)
        Me.PanelDesktop.Controls.Add(Me.HayvanAdıMus)
        Me.PanelDesktop.Controls.Add(Me.MusHayvanAdıLbl)
        Me.PanelDesktop.Controls.Add(Me.MüsSoyadı)
        Me.PanelDesktop.Controls.Add(Me.MusSoyadıLbl)
        Me.PanelDesktop.Controls.Add(Me.MüsAdı)
        Me.PanelDesktop.Controls.Add(Me.MusAdıLbl)
        Me.PanelDesktop.Controls.Add(Me.MüsGünBtn)
        Me.PanelDesktop.Controls.Add(Me.MüsSilBtn)
        Me.PanelDesktop.Controls.Add(Me.MüsEkleBtn)
        Me.PanelDesktop.Controls.Add(Me.PanelHeader)
        Me.PanelDesktop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PanelDesktop.Location = New System.Drawing.Point(248, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1615, 777)
        Me.PanelDesktop.TabIndex = 2
        '
        'btnFilter
        '
        Me.btnFilter.ActiveBorderThickness = 1
        Me.btnFilter.ActiveCornerRadius = 20
        Me.btnFilter.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilter.ActiveForecolor = System.Drawing.Color.Ivory
        Me.btnFilter.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFilter.BackColor = System.Drawing.Color.Ivory
        Me.btnFilter.BackgroundImage = CType(resources.GetObject("btnFilter.BackgroundImage"), System.Drawing.Image)
        Me.btnFilter.ButtonText = "Filtrele"
        Me.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilter.IdleBorderThickness = 1
        Me.btnFilter.IdleCornerRadius = 20
        Me.btnFilter.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFilter.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilter.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilter.Location = New System.Drawing.Point(1187, 161)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(85, 48)
        Me.btnFilter.TabIndex = 50
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'musteridata
        '
        Me.musteridata.AllowUserToAddRows = False
        Me.musteridata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.musteridata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.musteridata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.musteridata.BackgroundColor = System.Drawing.Color.Ivory
        Me.musteridata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.musteridata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.musteridata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.musteridata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.musteridata.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.musteridata.DefaultCellStyle = DataGridViewCellStyle3
        Me.musteridata.DoubleBuffered = True
        Me.musteridata.EnableHeadersVisualStyles = False
        Me.musteridata.GridColor = System.Drawing.Color.Ivory
        Me.musteridata.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.musteridata.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.musteridata.Location = New System.Drawing.Point(63, 250)
        Me.musteridata.Name = "musteridata"
        Me.musteridata.ReadOnly = True
        Me.musteridata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.musteridata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.musteridata.RowHeadersVisible = False
        Me.musteridata.RowHeadersWidth = 51
        Me.musteridata.RowTemplate.DividerHeight = 1
        Me.musteridata.RowTemplate.Height = 25
        Me.musteridata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.musteridata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.musteridata.Size = New System.Drawing.Size(1209, 436)
        Me.musteridata.TabIndex = 49
        '
        'BtnTemizle
        '
        Me.BtnTemizle.ActiveBorderThickness = 1
        Me.BtnTemizle.ActiveCornerRadius = 20
        Me.BtnTemizle.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizle.ActiveForecolor = System.Drawing.Color.Ivory
        Me.BtnTemizle.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTemizle.BackColor = System.Drawing.Color.Ivory
        Me.BtnTemizle.BackgroundImage = CType(resources.GetObject("BtnTemizle.BackgroundImage"), System.Drawing.Image)
        Me.BtnTemizle.ButtonText = "Temizle"
        Me.BtnTemizle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTemizle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnTemizle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizle.IdleBorderThickness = 1
        Me.BtnTemizle.IdleCornerRadius = 20
        Me.BtnTemizle.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTemizle.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizle.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizle.Location = New System.Drawing.Point(1075, 162)
        Me.BtnTemizle.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnTemizle.Name = "BtnTemizle"
        Me.BtnTemizle.Size = New System.Drawing.Size(85, 48)
        Me.BtnTemizle.TabIndex = 46
        Me.BtnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MüsAdr
        '
        Me.MüsAdr.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsAdr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsAdr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MüsAdr.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.MüsAdr.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsAdr.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsAdr.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsAdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsAdr.Location = New System.Drawing.Point(63, 176)
        Me.MüsAdr.Name = "MüsAdr"
        Me.MüsAdr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MüsAdr.SelectedText = ""
        Me.MüsAdr.Size = New System.Drawing.Size(182, 33)
        Me.MüsAdr.TabIndex = 38
        Me.MüsAdr.Tag = ""
        '
        'MusAdrLlb
        '
        Me.MusAdrLlb.BackColor = System.Drawing.Color.Ivory
        Me.MusAdrLlb.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MusAdrLlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MusAdrLlb.Location = New System.Drawing.Point(63, 148)
        Me.MusAdrLlb.Name = "MusAdrLlb"
        Me.MusAdrLlb.Size = New System.Drawing.Size(182, 25)
        Me.MusAdrLlb.TabIndex = 45
        Me.MusAdrLlb.Text = "Adres"
        Me.MusAdrLlb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MüsEPos
        '
        Me.MüsEPos.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsEPos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEPos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MüsEPos.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.MüsEPos.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsEPos.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEPos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsEPos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEPos.Location = New System.Drawing.Point(1090, 97)
        Me.MüsEPos.Name = "MüsEPos"
        Me.MüsEPos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MüsEPos.SelectedText = ""
        Me.MüsEPos.Size = New System.Drawing.Size(182, 33)
        Me.MüsEPos.TabIndex = 37
        Me.MüsEPos.Tag = ""
        '
        'MusEPosLbl
        '
        Me.MusEPosLbl.BackColor = System.Drawing.Color.Ivory
        Me.MusEPosLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MusEPosLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MusEPosLbl.Location = New System.Drawing.Point(1090, 69)
        Me.MusEPosLbl.Name = "MusEPosLbl"
        Me.MusEPosLbl.Size = New System.Drawing.Size(182, 25)
        Me.MusEPosLbl.TabIndex = 43
        Me.MusEPosLbl.Text = "EPosta"
        Me.MusEPosLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MüsTel
        '
        Me.MüsTel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsTel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MüsTel.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.MüsTel.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsTel.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsTel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsTel.Location = New System.Drawing.Point(827, 97)
        Me.MüsTel.Name = "MüsTel"
        Me.MüsTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MüsTel.SelectedText = ""
        Me.MüsTel.Size = New System.Drawing.Size(182, 33)
        Me.MüsTel.TabIndex = 36
        Me.MüsTel.Tag = ""
        '
        'MusTelLbl
        '
        Me.MusTelLbl.BackColor = System.Drawing.Color.Ivory
        Me.MusTelLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MusTelLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MusTelLbl.Location = New System.Drawing.Point(827, 69)
        Me.MusTelLbl.Name = "MusTelLbl"
        Me.MusTelLbl.Size = New System.Drawing.Size(182, 25)
        Me.MusTelLbl.TabIndex = 41
        Me.MusTelLbl.Text = "Telefon"
        Me.MusTelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayvanAdıMus
        '
        Me.HayvanAdıMus.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanAdıMus.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanAdıMus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayvanAdıMus.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayvanAdıMus.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanAdıMus.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanAdıMus.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayvanAdıMus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanAdıMus.Location = New System.Drawing.Point(589, 100)
        Me.HayvanAdıMus.Name = "HayvanAdıMus"
        Me.HayvanAdıMus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayvanAdıMus.SelectedText = ""
        Me.HayvanAdıMus.Size = New System.Drawing.Size(182, 33)
        Me.HayvanAdıMus.TabIndex = 35
        Me.HayvanAdıMus.Tag = ""
        '
        'MusHayvanAdıLbl
        '
        Me.MusHayvanAdıLbl.BackColor = System.Drawing.Color.Ivory
        Me.MusHayvanAdıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MusHayvanAdıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MusHayvanAdıLbl.Location = New System.Drawing.Point(589, 69)
        Me.MusHayvanAdıLbl.Name = "MusHayvanAdıLbl"
        Me.MusHayvanAdıLbl.Size = New System.Drawing.Size(182, 25)
        Me.MusHayvanAdıLbl.TabIndex = 39
        Me.MusHayvanAdıLbl.Text = "Hayvan Adı"
        Me.MusHayvanAdıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MüsSoyadı
        '
        Me.MüsSoyadı.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsSoyadı.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSoyadı.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MüsSoyadı.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.MüsSoyadı.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsSoyadı.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSoyadı.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsSoyadı.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSoyadı.Location = New System.Drawing.Point(336, 100)
        Me.MüsSoyadı.Name = "MüsSoyadı"
        Me.MüsSoyadı.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MüsSoyadı.SelectedText = ""
        Me.MüsSoyadı.Size = New System.Drawing.Size(182, 33)
        Me.MüsSoyadı.TabIndex = 34
        Me.MüsSoyadı.Tag = ""
        '
        'MusSoyadıLbl
        '
        Me.MusSoyadıLbl.BackColor = System.Drawing.Color.Ivory
        Me.MusSoyadıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MusSoyadıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MusSoyadıLbl.Location = New System.Drawing.Point(336, 69)
        Me.MusSoyadıLbl.Name = "MusSoyadıLbl"
        Me.MusSoyadıLbl.Size = New System.Drawing.Size(182, 25)
        Me.MusSoyadıLbl.TabIndex = 34
        Me.MusSoyadıLbl.Text = "Soyadı"
        Me.MusSoyadıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MüsAdı
        '
        Me.MüsAdı.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsAdı.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsAdı.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MüsAdı.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.MüsAdı.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsAdı.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsAdı.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsAdı.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsAdı.Location = New System.Drawing.Point(63, 100)
        Me.MüsAdı.Name = "MüsAdı"
        Me.MüsAdı.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MüsAdı.SelectedText = ""
        Me.MüsAdı.Size = New System.Drawing.Size(182, 33)
        Me.MüsAdı.TabIndex = 33
        Me.MüsAdı.Tag = ""
        '
        'MusAdıLbl
        '
        Me.MusAdıLbl.BackColor = System.Drawing.Color.Ivory
        Me.MusAdıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MusAdıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MusAdıLbl.Location = New System.Drawing.Point(63, 69)
        Me.MusAdıLbl.Name = "MusAdıLbl"
        Me.MusAdıLbl.Size = New System.Drawing.Size(182, 25)
        Me.MusAdıLbl.TabIndex = 32
        Me.MusAdıLbl.Text = "Adı"
        Me.MusAdıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MüsGünBtn
        '
        Me.MüsGünBtn.ActiveBorderThickness = 1
        Me.MüsGünBtn.ActiveCornerRadius = 20
        Me.MüsGünBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsGünBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.MüsGünBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsGünBtn.BackColor = System.Drawing.Color.Ivory
        Me.MüsGünBtn.BackgroundImage = CType(resources.GetObject("MüsGünBtn.BackgroundImage"), System.Drawing.Image)
        Me.MüsGünBtn.ButtonText = "Güncelle"
        Me.MüsGünBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MüsGünBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsGünBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsGünBtn.IdleBorderThickness = 1
        Me.MüsGünBtn.IdleCornerRadius = 20
        Me.MüsGünBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsGünBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsGünBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsGünBtn.Location = New System.Drawing.Point(957, 162)
        Me.MüsGünBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.MüsGünBtn.Name = "MüsGünBtn"
        Me.MüsGünBtn.Size = New System.Drawing.Size(85, 48)
        Me.MüsGünBtn.TabIndex = 22
        Me.MüsGünBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MüsSilBtn
        '
        Me.MüsSilBtn.ActiveBorderThickness = 1
        Me.MüsSilBtn.ActiveCornerRadius = 20
        Me.MüsSilBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSilBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.MüsSilBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsSilBtn.BackColor = System.Drawing.Color.Ivory
        Me.MüsSilBtn.BackgroundImage = CType(resources.GetObject("MüsSilBtn.BackgroundImage"), System.Drawing.Image)
        Me.MüsSilBtn.ButtonText = "Sil"
        Me.MüsSilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MüsSilBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsSilBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSilBtn.IdleBorderThickness = 1
        Me.MüsSilBtn.IdleCornerRadius = 20
        Me.MüsSilBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsSilBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSilBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsSilBtn.Location = New System.Drawing.Point(830, 162)
        Me.MüsSilBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.MüsSilBtn.Name = "MüsSilBtn"
        Me.MüsSilBtn.Size = New System.Drawing.Size(85, 48)
        Me.MüsSilBtn.TabIndex = 21
        Me.MüsSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MüsEkleBtn
        '
        Me.MüsEkleBtn.ActiveBorderThickness = 1
        Me.MüsEkleBtn.ActiveCornerRadius = 20
        Me.MüsEkleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEkleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.MüsEkleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsEkleBtn.BackColor = System.Drawing.Color.Ivory
        Me.MüsEkleBtn.BackgroundImage = CType(resources.GetObject("MüsEkleBtn.BackgroundImage"), System.Drawing.Image)
        Me.MüsEkleBtn.ButtonText = "Ekle"
        Me.MüsEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MüsEkleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MüsEkleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEkleBtn.IdleBorderThickness = 1
        Me.MüsEkleBtn.IdleCornerRadius = 20
        Me.MüsEkleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MüsEkleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEkleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.MüsEkleBtn.Location = New System.Drawing.Point(702, 161)
        Me.MüsEkleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.MüsEkleBtn.Name = "MüsEkleBtn"
        Me.MüsEkleBtn.Size = New System.Drawing.Size(85, 48)
        Me.MüsEkleBtn.TabIndex = 20
        Me.MüsEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.btnMin)
        Me.PanelHeader.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelHeader.Controls.Add(Me.btnClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1615, 48)
        Me.PanelHeader.TabIndex = 13
        '
        'btnMin
        '
        Me.btnMin.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.ImageActive = Nothing
        Me.btnMin.Location = New System.Drawing.Point(1270, 0)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(50, 48)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMin.TabIndex = 14
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoEllipsis = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(1272, 48)
        Me.BunifuCustomLabel1.TabIndex = 16
        Me.BunifuCustomLabel1.Text = "Müşteriler"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageActive = Nothing
        Me.btnClose.Location = New System.Drawing.Point(1317, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(50, 48)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 13
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.musteridata
        '
        'CustomersForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1615, 777)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomersForm"
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.musteridata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaleBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents SupplierBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PersonelBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents CustomerBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PetsBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents ProductBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents HomeBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents MüsEkleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents MüsSilBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents MüsGünBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MusAdıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MüsAdı As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MusSoyadıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MüsSoyadı As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayvanAdıMus As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MusHayvanAdıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MüsAdr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MusAdrLlb As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MüsEPos As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MusEPosLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MüsTel As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents MusTelLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents MüşteriTabloBindingSource As BindingSource
    Friend WithEvents HayvanAdıDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdıDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoyadıDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EPostaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BtnTemizle As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents musteridata As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnFilter As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SoldBtn As FontAwesome.Sharp.IconButton
End Class
