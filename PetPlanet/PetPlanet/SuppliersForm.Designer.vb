<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuppliersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SuppliersForm))
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
        Me.tedarikcidata = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BtnTemizle = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.FirmTel = New Guna.UI.WinForms.GunaTextBox()
        Me.FirmTelLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.FirmAdr = New Guna.UI.WinForms.GunaTextBox()
        Me.FirmAdrLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.FirmAd = New Guna.UI.WinForms.GunaTextBox()
        Me.FirmaAdıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TedEkleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TedSilBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.TedGuncelleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.tedarikcidata, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SaleBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.SupplierBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.PersonelBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.CustomerBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.PetsBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.ProductBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.HomeBtn.Padding = New System.Windows.Forms.Padding(12, 0, 25, 0)
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
        Me.btnHome.Size = New System.Drawing.Size(245, 104)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 0
        Me.btnHome.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.Ivory
        Me.PanelDesktop.Controls.Add(Me.btnFilter)
        Me.PanelDesktop.Controls.Add(Me.tedarikcidata)
        Me.PanelDesktop.Controls.Add(Me.BtnTemizle)
        Me.PanelDesktop.Controls.Add(Me.FirmTel)
        Me.PanelDesktop.Controls.Add(Me.FirmTelLbl)
        Me.PanelDesktop.Controls.Add(Me.FirmAdr)
        Me.PanelDesktop.Controls.Add(Me.FirmAdrLbl)
        Me.PanelDesktop.Controls.Add(Me.FirmAd)
        Me.PanelDesktop.Controls.Add(Me.FirmaAdıLbl)
        Me.PanelDesktop.Controls.Add(Me.TedEkleBtn)
        Me.PanelDesktop.Controls.Add(Me.TedSilBtn)
        Me.PanelDesktop.Controls.Add(Me.TedGuncelleBtn)
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
        Me.btnFilter.Location = New System.Drawing.Point(978, 175)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(85, 47)
        Me.btnFilter.TabIndex = 50
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tedarikcidata
        '
        Me.tedarikcidata.AllowUserToAddRows = False
        Me.tedarikcidata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.tedarikcidata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.tedarikcidata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tedarikcidata.BackgroundColor = System.Drawing.Color.Ivory
        Me.tedarikcidata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tedarikcidata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.tedarikcidata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tedarikcidata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.tedarikcidata.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tedarikcidata.DefaultCellStyle = DataGridViewCellStyle3
        Me.tedarikcidata.DoubleBuffered = True
        Me.tedarikcidata.EnableHeadersVisualStyles = False
        Me.tedarikcidata.GridColor = System.Drawing.Color.Ivory
        Me.tedarikcidata.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.tedarikcidata.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.tedarikcidata.Location = New System.Drawing.Point(348, 240)
        Me.tedarikcidata.Name = "tedarikcidata"
        Me.tedarikcidata.ReadOnly = True
        Me.tedarikcidata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tedarikcidata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tedarikcidata.RowHeadersVisible = False
        Me.tedarikcidata.RowHeadersWidth = 51
        Me.tedarikcidata.RowTemplate.DividerHeight = 1
        Me.tedarikcidata.RowTemplate.Height = 25
        Me.tedarikcidata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tedarikcidata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tedarikcidata.Size = New System.Drawing.Size(759, 436)
        Me.tedarikcidata.TabIndex = 49
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
        Me.BtnTemizle.Location = New System.Drawing.Point(847, 175)
        Me.BtnTemizle.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnTemizle.Name = "BtnTemizle"
        Me.BtnTemizle.Size = New System.Drawing.Size(85, 47)
        Me.BtnTemizle.TabIndex = 44
        Me.BtnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FirmTel
        '
        Me.FirmTel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirmTel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirmTel.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.FirmTel.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirmTel.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmTel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FirmTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmTel.Location = New System.Drawing.Point(925, 109)
        Me.FirmTel.Name = "FirmTel"
        Me.FirmTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirmTel.SelectedText = ""
        Me.FirmTel.Size = New System.Drawing.Size(182, 33)
        Me.FirmTel.TabIndex = 42
        Me.FirmTel.Tag = ""
        '
        'FirmTelLbl
        '
        Me.FirmTelLbl.BackColor = System.Drawing.Color.Ivory
        Me.FirmTelLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FirmTelLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmTelLbl.Location = New System.Drawing.Point(925, 75)
        Me.FirmTelLbl.Name = "FirmTelLbl"
        Me.FirmTelLbl.Size = New System.Drawing.Size(182, 25)
        Me.FirmTelLbl.TabIndex = 41
        Me.FirmTelLbl.Text = "Telefon"
        Me.FirmTelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirmAdr
        '
        Me.FirmAdr.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirmAdr.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAdr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirmAdr.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.FirmAdr.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirmAdr.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAdr.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FirmAdr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAdr.Location = New System.Drawing.Point(646, 109)
        Me.FirmAdr.Name = "FirmAdr"
        Me.FirmAdr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirmAdr.SelectedText = ""
        Me.FirmAdr.Size = New System.Drawing.Size(182, 33)
        Me.FirmAdr.TabIndex = 40
        Me.FirmAdr.Tag = ""
        '
        'FirmAdrLbl
        '
        Me.FirmAdrLbl.BackColor = System.Drawing.Color.Ivory
        Me.FirmAdrLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FirmAdrLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAdrLbl.Location = New System.Drawing.Point(646, 75)
        Me.FirmAdrLbl.Name = "FirmAdrLbl"
        Me.FirmAdrLbl.Size = New System.Drawing.Size(182, 25)
        Me.FirmAdrLbl.TabIndex = 39
        Me.FirmAdrLbl.Text = "Adres"
        Me.FirmAdrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirmAd
        '
        Me.FirmAd.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirmAd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirmAd.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.FirmAd.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirmAd.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAd.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FirmAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmAd.Location = New System.Drawing.Point(348, 109)
        Me.FirmAd.Name = "FirmAd"
        Me.FirmAd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirmAd.SelectedText = ""
        Me.FirmAd.Size = New System.Drawing.Size(182, 33)
        Me.FirmAd.TabIndex = 38
        Me.FirmAd.Tag = ""
        '
        'FirmaAdıLbl
        '
        Me.FirmaAdıLbl.BackColor = System.Drawing.Color.Ivory
        Me.FirmaAdıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FirmaAdıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.FirmaAdıLbl.Location = New System.Drawing.Point(348, 75)
        Me.FirmaAdıLbl.Name = "FirmaAdıLbl"
        Me.FirmaAdıLbl.Size = New System.Drawing.Size(182, 25)
        Me.FirmaAdıLbl.TabIndex = 37
        Me.FirmaAdıLbl.Text = "Firma Adı"
        Me.FirmaAdıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TedEkleBtn
        '
        Me.TedEkleBtn.ActiveBorderThickness = 1
        Me.TedEkleBtn.ActiveCornerRadius = 20
        Me.TedEkleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedEkleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.TedEkleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TedEkleBtn.BackColor = System.Drawing.Color.Ivory
        Me.TedEkleBtn.BackgroundImage = CType(resources.GetObject("TedEkleBtn.BackgroundImage"), System.Drawing.Image)
        Me.TedEkleBtn.ButtonText = "Ekle"
        Me.TedEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TedEkleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TedEkleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedEkleBtn.IdleBorderThickness = 1
        Me.TedEkleBtn.IdleCornerRadius = 20
        Me.TedEkleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TedEkleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedEkleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedEkleBtn.Location = New System.Drawing.Point(431, 175)
        Me.TedEkleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.TedEkleBtn.Name = "TedEkleBtn"
        Me.TedEkleBtn.Size = New System.Drawing.Size(85, 47)
        Me.TedEkleBtn.TabIndex = 36
        Me.TedEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TedSilBtn
        '
        Me.TedSilBtn.ActiveBorderThickness = 1
        Me.TedSilBtn.ActiveCornerRadius = 20
        Me.TedSilBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedSilBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.TedSilBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TedSilBtn.BackColor = System.Drawing.Color.Ivory
        Me.TedSilBtn.BackgroundImage = CType(resources.GetObject("TedSilBtn.BackgroundImage"), System.Drawing.Image)
        Me.TedSilBtn.ButtonText = "Sil"
        Me.TedSilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TedSilBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TedSilBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedSilBtn.IdleBorderThickness = 1
        Me.TedSilBtn.IdleCornerRadius = 20
        Me.TedSilBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TedSilBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedSilBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedSilBtn.Location = New System.Drawing.Point(564, 175)
        Me.TedSilBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.TedSilBtn.Name = "TedSilBtn"
        Me.TedSilBtn.Size = New System.Drawing.Size(85, 47)
        Me.TedSilBtn.TabIndex = 34
        Me.TedSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TedGuncelleBtn
        '
        Me.TedGuncelleBtn.ActiveBorderThickness = 1
        Me.TedGuncelleBtn.ActiveCornerRadius = 20
        Me.TedGuncelleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedGuncelleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.TedGuncelleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TedGuncelleBtn.BackColor = System.Drawing.Color.Ivory
        Me.TedGuncelleBtn.BackgroundImage = CType(resources.GetObject("TedGuncelleBtn.BackgroundImage"), System.Drawing.Image)
        Me.TedGuncelleBtn.ButtonText = "Güncelle"
        Me.TedGuncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TedGuncelleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TedGuncelleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedGuncelleBtn.IdleBorderThickness = 1
        Me.TedGuncelleBtn.IdleCornerRadius = 20
        Me.TedGuncelleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TedGuncelleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedGuncelleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.TedGuncelleBtn.Location = New System.Drawing.Point(705, 175)
        Me.TedGuncelleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.TedGuncelleBtn.Name = "TedGuncelleBtn"
        Me.TedGuncelleBtn.Size = New System.Drawing.Size(85, 47)
        Me.TedGuncelleBtn.TabIndex = 32
        Me.TedGuncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelHeader.Controls.Add(Me.btnMin)
        Me.PanelHeader.Controls.Add(Me.btnClose)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1615, 48)
        Me.PanelHeader.TabIndex = 13
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
        Me.BunifuCustomLabel1.TabIndex = 17
        Me.BunifuCustomLabel1.Text = "Tedarikçiler"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuElipse1.TargetControl = Me.tedarikcidata
        '
        'SuppliersForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1615, 777)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuppliersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuppliersForm"
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.tedarikcidata, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TedGuncelleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TedEkleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents TedSilBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents FirmaAdıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FirmAd As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FirmAdrLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FirmAdr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents FirmTelLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents FirmTel As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents BtnTemizle As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents tedarikcidata As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnFilter As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SoldBtn As FontAwesome.Sharp.IconButton
End Class
