<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductForm))
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
        Me.fiyataralıgılbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnFilter = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtMaxPrice = New Guna.UI.WinForms.GunaTextBox()
        Me.txtMinPrice = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbMarka = New System.Windows.Forms.ComboBox()
        Me.cmbTür = New System.Windows.Forms.ComboBox()
        Me.urunlerdata = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BtnTemizle = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SonKullanmaLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrStok = New Guna.UI.WinForms.GunaTextBox()
        Me.PrStokLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrAciklama = New Guna.UI.WinForms.GunaTextBox()
        Me.PrAciklamaLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrFiyat = New Guna.UI.WinForms.GunaTextBox()
        Me.PrFiyatLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrMaliyet = New Guna.UI.WinForms.GunaTextBox()
        Me.PrMaliyetLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrUrunMarkLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrTurLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PrAdı = New Guna.UI.WinForms.GunaTextBox()
        Me.PrUrunAdıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.UrunSonKullanmaTarih = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.UrunSilBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.UrunGuncelleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.UrunEkleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.urunlerdata, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelDesktop.Controls.Add(Me.fiyataralıgılbl)
        Me.PanelDesktop.Controls.Add(Me.btnFilter)
        Me.PanelDesktop.Controls.Add(Me.txtMaxPrice)
        Me.PanelDesktop.Controls.Add(Me.txtMinPrice)
        Me.PanelDesktop.Controls.Add(Me.cmbMarka)
        Me.PanelDesktop.Controls.Add(Me.cmbTür)
        Me.PanelDesktop.Controls.Add(Me.urunlerdata)
        Me.PanelDesktop.Controls.Add(Me.BtnTemizle)
        Me.PanelDesktop.Controls.Add(Me.SonKullanmaLbl)
        Me.PanelDesktop.Controls.Add(Me.PrStok)
        Me.PanelDesktop.Controls.Add(Me.PrStokLbl)
        Me.PanelDesktop.Controls.Add(Me.PrAciklama)
        Me.PanelDesktop.Controls.Add(Me.PrAciklamaLbl)
        Me.PanelDesktop.Controls.Add(Me.PrFiyat)
        Me.PanelDesktop.Controls.Add(Me.PrFiyatLbl)
        Me.PanelDesktop.Controls.Add(Me.PrMaliyet)
        Me.PanelDesktop.Controls.Add(Me.PrMaliyetLbl)
        Me.PanelDesktop.Controls.Add(Me.PrUrunMarkLbl)
        Me.PanelDesktop.Controls.Add(Me.PrTurLbl)
        Me.PanelDesktop.Controls.Add(Me.PrAdı)
        Me.PanelDesktop.Controls.Add(Me.PrUrunAdıLbl)
        Me.PanelDesktop.Controls.Add(Me.UrunSonKullanmaTarih)
        Me.PanelDesktop.Controls.Add(Me.UrunSilBtn)
        Me.PanelDesktop.Controls.Add(Me.UrunGuncelleBtn)
        Me.PanelDesktop.Controls.Add(Me.UrunEkleBtn)
        Me.PanelDesktop.Controls.Add(Me.PanelHeader)
        Me.PanelDesktop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PanelDesktop.Location = New System.Drawing.Point(248, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1615, 777)
        Me.PanelDesktop.TabIndex = 2
        '
        'fiyataralıgılbl
        '
        Me.fiyataralıgılbl.BackColor = System.Drawing.Color.Ivory
        Me.fiyataralıgılbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.fiyataralıgılbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.fiyataralıgılbl.Location = New System.Drawing.Point(843, 149)
        Me.fiyataralıgılbl.Name = "fiyataralıgılbl"
        Me.fiyataralıgılbl.Size = New System.Drawing.Size(426, 25)
        Me.fiyataralıgılbl.TabIndex = 77
        Me.fiyataralıgılbl.Text = "Fiyat Aralığı Giriniz"
        Me.fiyataralıgılbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnFilter.Location = New System.Drawing.Point(920, 236)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(85, 47)
        Me.btnFilter.TabIndex = 76
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaxPrice
        '
        Me.txtMaxPrice.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMaxPrice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMaxPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaxPrice.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.txtMaxPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMaxPrice.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMaxPrice.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMaxPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMaxPrice.Location = New System.Drawing.Point(1090, 177)
        Me.txtMaxPrice.Name = "txtMaxPrice"
        Me.txtMaxPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaxPrice.SelectedText = ""
        Me.txtMaxPrice.Size = New System.Drawing.Size(182, 33)
        Me.txtMaxPrice.TabIndex = 75
        Me.txtMaxPrice.Tag = ""
        '
        'txtMinPrice
        '
        Me.txtMinPrice.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMinPrice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMinPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinPrice.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.txtMinPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMinPrice.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMinPrice.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMinPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMinPrice.Location = New System.Drawing.Point(846, 177)
        Me.txtMinPrice.Name = "txtMinPrice"
        Me.txtMinPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMinPrice.SelectedText = ""
        Me.txtMinPrice.Size = New System.Drawing.Size(182, 33)
        Me.txtMinPrice.TabIndex = 74
        Me.txtMinPrice.Tag = ""
        '
        'cmbMarka
        '
        Me.cmbMarka.BackColor = System.Drawing.Color.Ivory
        Me.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarka.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbMarka.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.cmbMarka.FormattingEnabled = True
        Me.cmbMarka.IntegralHeight = False
        Me.cmbMarka.ItemHeight = 17
        Me.cmbMarka.Location = New System.Drawing.Point(602, 104)
        Me.cmbMarka.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbMarka.Name = "cmbMarka"
        Me.cmbMarka.Size = New System.Drawing.Size(182, 25)
        Me.cmbMarka.TabIndex = 72
        '
        'cmbTür
        '
        Me.cmbTür.BackColor = System.Drawing.Color.Ivory
        Me.cmbTür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTür.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTür.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.cmbTür.FormattingEnabled = True
        Me.cmbTür.IntegralHeight = False
        Me.cmbTür.ItemHeight = 17
        Me.cmbTür.Location = New System.Drawing.Point(342, 104)
        Me.cmbTür.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbTür.Name = "cmbTür"
        Me.cmbTür.Size = New System.Drawing.Size(182, 25)
        Me.cmbTür.TabIndex = 71
        '
        'urunlerdata
        '
        Me.urunlerdata.AllowUserToAddRows = False
        Me.urunlerdata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.urunlerdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.urunlerdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.urunlerdata.BackgroundColor = System.Drawing.Color.Ivory
        Me.urunlerdata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.urunlerdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.urunlerdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.urunlerdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.urunlerdata.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.urunlerdata.DefaultCellStyle = DataGridViewCellStyle3
        Me.urunlerdata.DoubleBuffered = True
        Me.urunlerdata.EnableHeadersVisualStyles = False
        Me.urunlerdata.GridColor = System.Drawing.Color.Ivory
        Me.urunlerdata.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.urunlerdata.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.urunlerdata.Location = New System.Drawing.Point(85, 319)
        Me.urunlerdata.Name = "urunlerdata"
        Me.urunlerdata.ReadOnly = True
        Me.urunlerdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.urunlerdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.urunlerdata.RowHeadersVisible = False
        Me.urunlerdata.RowHeadersWidth = 51
        Me.urunlerdata.RowTemplate.DividerHeight = 1
        Me.urunlerdata.RowTemplate.Height = 25
        Me.urunlerdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.urunlerdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.urunlerdata.Size = New System.Drawing.Size(1187, 429)
        Me.urunlerdata.TabIndex = 58
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
        Me.BtnTemizle.Location = New System.Drawing.Point(783, 236)
        Me.BtnTemizle.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnTemizle.Name = "BtnTemizle"
        Me.BtnTemizle.Size = New System.Drawing.Size(85, 47)
        Me.BtnTemizle.TabIndex = 57
        Me.BtnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SonKullanmaLbl
        '
        Me.SonKullanmaLbl.BackColor = System.Drawing.Color.Ivory
        Me.SonKullanmaLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SonKullanmaLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SonKullanmaLbl.Location = New System.Drawing.Point(602, 149)
        Me.SonKullanmaLbl.Name = "SonKullanmaLbl"
        Me.SonKullanmaLbl.Size = New System.Drawing.Size(182, 25)
        Me.SonKullanmaLbl.TabIndex = 56
        Me.SonKullanmaLbl.Text = "Son Kullanma Tarihi"
        Me.SonKullanmaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrStok
        '
        Me.PrStok.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrStok.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrStok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrStok.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PrStok.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrStok.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrStok.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PrStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrStok.Location = New System.Drawing.Point(342, 177)
        Me.PrStok.Name = "PrStok"
        Me.PrStok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrStok.SelectedText = ""
        Me.PrStok.Size = New System.Drawing.Size(182, 33)
        Me.PrStok.TabIndex = 51
        Me.PrStok.Tag = ""
        '
        'PrStokLbl
        '
        Me.PrStokLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrStokLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrStokLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrStokLbl.Location = New System.Drawing.Point(342, 149)
        Me.PrStokLbl.Name = "PrStokLbl"
        Me.PrStokLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrStokLbl.TabIndex = 54
        Me.PrStokLbl.Text = "Stok Sayısı"
        Me.PrStokLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrAciklama
        '
        Me.PrAciklama.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrAciklama.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAciklama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrAciklama.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PrAciklama.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrAciklama.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAciklama.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PrAciklama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAciklama.Location = New System.Drawing.Point(85, 177)
        Me.PrAciklama.Name = "PrAciklama"
        Me.PrAciklama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrAciklama.SelectedText = ""
        Me.PrAciklama.Size = New System.Drawing.Size(182, 33)
        Me.PrAciklama.TabIndex = 50
        Me.PrAciklama.Tag = ""
        '
        'PrAciklamaLbl
        '
        Me.PrAciklamaLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrAciklamaLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrAciklamaLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAciklamaLbl.Location = New System.Drawing.Point(85, 149)
        Me.PrAciklamaLbl.Name = "PrAciklamaLbl"
        Me.PrAciklamaLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrAciklamaLbl.TabIndex = 52
        Me.PrAciklamaLbl.Text = "Açıklama"
        Me.PrAciklamaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrFiyat
        '
        Me.PrFiyat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrFiyat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrFiyat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrFiyat.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PrFiyat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrFiyat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrFiyat.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PrFiyat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrFiyat.Location = New System.Drawing.Point(1090, 100)
        Me.PrFiyat.Name = "PrFiyat"
        Me.PrFiyat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrFiyat.SelectedText = ""
        Me.PrFiyat.Size = New System.Drawing.Size(182, 33)
        Me.PrFiyat.TabIndex = 49
        Me.PrFiyat.Tag = ""
        '
        'PrFiyatLbl
        '
        Me.PrFiyatLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrFiyatLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrFiyatLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrFiyatLbl.Location = New System.Drawing.Point(1090, 75)
        Me.PrFiyatLbl.Name = "PrFiyatLbl"
        Me.PrFiyatLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrFiyatLbl.TabIndex = 50
        Me.PrFiyatLbl.Text = "Fiyat"
        Me.PrFiyatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrMaliyet
        '
        Me.PrMaliyet.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrMaliyet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrMaliyet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrMaliyet.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PrMaliyet.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrMaliyet.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrMaliyet.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PrMaliyet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrMaliyet.Location = New System.Drawing.Point(843, 100)
        Me.PrMaliyet.Name = "PrMaliyet"
        Me.PrMaliyet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrMaliyet.SelectedText = ""
        Me.PrMaliyet.Size = New System.Drawing.Size(182, 33)
        Me.PrMaliyet.TabIndex = 48
        Me.PrMaliyet.Tag = ""
        '
        'PrMaliyetLbl
        '
        Me.PrMaliyetLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrMaliyetLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrMaliyetLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrMaliyetLbl.Location = New System.Drawing.Point(843, 72)
        Me.PrMaliyetLbl.Name = "PrMaliyetLbl"
        Me.PrMaliyetLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrMaliyetLbl.TabIndex = 48
        Me.PrMaliyetLbl.Text = "Maliyet"
        Me.PrMaliyetLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrUrunMarkLbl
        '
        Me.PrUrunMarkLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrUrunMarkLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrUrunMarkLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrUrunMarkLbl.Location = New System.Drawing.Point(602, 69)
        Me.PrUrunMarkLbl.Name = "PrUrunMarkLbl"
        Me.PrUrunMarkLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrUrunMarkLbl.TabIndex = 47
        Me.PrUrunMarkLbl.Text = "Marka"
        Me.PrUrunMarkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrTurLbl
        '
        Me.PrTurLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrTurLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrTurLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrTurLbl.Location = New System.Drawing.Point(342, 69)
        Me.PrTurLbl.Name = "PrTurLbl"
        Me.PrTurLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrTurLbl.TabIndex = 46
        Me.PrTurLbl.Text = "Tür"
        Me.PrTurLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrAdı
        '
        Me.PrAdı.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrAdı.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAdı.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrAdı.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PrAdı.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PrAdı.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAdı.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PrAdı.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrAdı.Location = New System.Drawing.Point(85, 100)
        Me.PrAdı.Name = "PrAdı"
        Me.PrAdı.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PrAdı.SelectedText = ""
        Me.PrAdı.Size = New System.Drawing.Size(182, 33)
        Me.PrAdı.TabIndex = 45
        Me.PrAdı.Tag = ""
        '
        'PrUrunAdıLbl
        '
        Me.PrUrunAdıLbl.BackColor = System.Drawing.Color.Ivory
        Me.PrUrunAdıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PrUrunAdıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PrUrunAdıLbl.Location = New System.Drawing.Point(85, 69)
        Me.PrUrunAdıLbl.Name = "PrUrunAdıLbl"
        Me.PrUrunAdıLbl.Size = New System.Drawing.Size(182, 25)
        Me.PrUrunAdıLbl.TabIndex = 44
        Me.PrUrunAdıLbl.Text = "Ürün Adı"
        Me.PrUrunAdıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UrunSonKullanmaTarih
        '
        Me.UrunSonKullanmaTarih.BackColor = System.Drawing.Color.Ivory
        Me.UrunSonKullanmaTarih.BorderRadius = 0
        Me.UrunSonKullanmaTarih.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.UrunSonKullanmaTarih.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunSonKullanmaTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UrunSonKullanmaTarih.FormatCustom = Nothing
        Me.UrunSonKullanmaTarih.Location = New System.Drawing.Point(602, 177)
        Me.UrunSonKullanmaTarih.Margin = New System.Windows.Forms.Padding(4)
        Me.UrunSonKullanmaTarih.Name = "UrunSonKullanmaTarih"
        Me.UrunSonKullanmaTarih.Size = New System.Drawing.Size(182, 33)
        Me.UrunSonKullanmaTarih.TabIndex = 52
        Me.UrunSonKullanmaTarih.Tag = "Son Kullanma Tarihi"
        Me.UrunSonKullanmaTarih.Value = New Date(2024, 3, 26, 13, 21, 43, 258)
        '
        'UrunSilBtn
        '
        Me.UrunSilBtn.ActiveBorderThickness = 1
        Me.UrunSilBtn.ActiveCornerRadius = 20
        Me.UrunSilBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunSilBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.UrunSilBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UrunSilBtn.BackColor = System.Drawing.Color.Ivory
        Me.UrunSilBtn.BackgroundImage = CType(resources.GetObject("UrunSilBtn.BackgroundImage"), System.Drawing.Image)
        Me.UrunSilBtn.ButtonText = "Sil"
        Me.UrunSilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UrunSilBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.UrunSilBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunSilBtn.IdleBorderThickness = 1
        Me.UrunSilBtn.IdleCornerRadius = 20
        Me.UrunSilBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UrunSilBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunSilBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunSilBtn.Location = New System.Drawing.Point(636, 236)
        Me.UrunSilBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.UrunSilBtn.Name = "UrunSilBtn"
        Me.UrunSilBtn.Size = New System.Drawing.Size(90, 47)
        Me.UrunSilBtn.TabIndex = 17
        Me.UrunSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UrunGuncelleBtn
        '
        Me.UrunGuncelleBtn.ActiveBorderThickness = 1
        Me.UrunGuncelleBtn.ActiveCornerRadius = 20
        Me.UrunGuncelleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunGuncelleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.UrunGuncelleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UrunGuncelleBtn.BackColor = System.Drawing.Color.Ivory
        Me.UrunGuncelleBtn.BackgroundImage = CType(resources.GetObject("UrunGuncelleBtn.BackgroundImage"), System.Drawing.Image)
        Me.UrunGuncelleBtn.ButtonText = "Güncelle"
        Me.UrunGuncelleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UrunGuncelleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.UrunGuncelleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunGuncelleBtn.IdleBorderThickness = 1
        Me.UrunGuncelleBtn.IdleCornerRadius = 20
        Me.UrunGuncelleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UrunGuncelleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunGuncelleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunGuncelleBtn.Location = New System.Drawing.Point(499, 236)
        Me.UrunGuncelleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.UrunGuncelleBtn.Name = "UrunGuncelleBtn"
        Me.UrunGuncelleBtn.Size = New System.Drawing.Size(85, 47)
        Me.UrunGuncelleBtn.TabIndex = 16
        Me.UrunGuncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UrunEkleBtn
        '
        Me.UrunEkleBtn.ActiveBorderThickness = 1
        Me.UrunEkleBtn.ActiveCornerRadius = 20
        Me.UrunEkleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunEkleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.UrunEkleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UrunEkleBtn.BackColor = System.Drawing.Color.Ivory
        Me.UrunEkleBtn.BackgroundImage = CType(resources.GetObject("UrunEkleBtn.BackgroundImage"), System.Drawing.Image)
        Me.UrunEkleBtn.ButtonText = "Ekle"
        Me.UrunEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UrunEkleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.UrunEkleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunEkleBtn.IdleBorderThickness = 1
        Me.UrunEkleBtn.IdleCornerRadius = 20
        Me.UrunEkleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UrunEkleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunEkleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.UrunEkleBtn.Location = New System.Drawing.Point(345, 236)
        Me.UrunEkleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.UrunEkleBtn.Name = "UrunEkleBtn"
        Me.UrunEkleBtn.Size = New System.Drawing.Size(82, 47)
        Me.UrunEkleBtn.TabIndex = 15
        Me.UrunEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuCustomLabel1.Text = "Ürünler"
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
        Me.BunifuElipse1.TargetControl = Me.urunlerdata
        '
        'ProductForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1615, 777)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.urunlerdata, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents UrunEkleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents UrunSilBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents UrunGuncelleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents UrunSonKullanmaTarih As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents PrUrunAdıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrTurLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrAdı As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PrStok As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PrStokLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrAciklama As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PrAciklamaLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrFiyat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PrFiyatLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrMaliyet As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PrMaliyetLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PrUrunMarkLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SonKullanmaLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ÜrünlerTabloBindingSource As BindingSource
    Friend WithEvents BtnTemizle As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents urunlerdata As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cmbMarka As ComboBox
    Friend WithEvents cmbTür As ComboBox
    Friend WithEvents txtMaxPrice As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtMinPrice As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnFilter As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents fiyataralıgılbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SoldBtn As FontAwesome.Sharp.IconButton
End Class
