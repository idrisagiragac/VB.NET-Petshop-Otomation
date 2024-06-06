<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoldAnimals
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoldAnimals))
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
        Me.btnFilterr = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnTemizlee = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SatılanHayvanGunBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SatılanHayvanSilBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SatılanHayvanEkleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.satisaciklamalbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ksırılastırmadurumulbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.alerjidurumulbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sonasitariihlbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.satisyaslbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.satiscinslbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.turlblsatis = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.hayvansatiscinsiyetlbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sahibinadılbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.hayvanadılbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.sonasitarihi = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.satisacıklamatxt = New Guna.UI.WinForms.GunaTextBox()
        Me.ksırılastırmatxt = New Guna.UI.WinForms.GunaTextBox()
        Me.alerjitxt = New Guna.UI.WinForms.GunaTextBox()
        Me.hayvanyastxt = New Guna.UI.WinForms.GunaTextBox()
        Me.hayvancintxt = New Guna.UI.WinForms.GunaTextBox()
        Me.HayvanTurTtx = New Guna.UI.WinForms.GunaTextBox()
        Me.hayvancinsiyettxt = New Guna.UI.WinForms.GunaTextBox()
        Me.sahibadıtxt = New Guna.UI.WinForms.GunaTextBox()
        Me.HayvanAdıSt = New Guna.UI.WinForms.GunaTextBox()
        Me.soldananimalsdata = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.satılanahyavanlarlbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.soldananimalsdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SoldBtn.TabIndex = 7
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
        Me.PanelDesktop.Controls.Add(Me.btnFilterr)
        Me.PanelDesktop.Controls.Add(Me.BtnTemizlee)
        Me.PanelDesktop.Controls.Add(Me.SatılanHayvanGunBtn)
        Me.PanelDesktop.Controls.Add(Me.SatılanHayvanSilBtn)
        Me.PanelDesktop.Controls.Add(Me.SatılanHayvanEkleBtn)
        Me.PanelDesktop.Controls.Add(Me.satisaciklamalbl)
        Me.PanelDesktop.Controls.Add(Me.ksırılastırmadurumulbl)
        Me.PanelDesktop.Controls.Add(Me.alerjidurumulbl)
        Me.PanelDesktop.Controls.Add(Me.sonasitariihlbl)
        Me.PanelDesktop.Controls.Add(Me.satisyaslbl)
        Me.PanelDesktop.Controls.Add(Me.satiscinslbl)
        Me.PanelDesktop.Controls.Add(Me.turlblsatis)
        Me.PanelDesktop.Controls.Add(Me.hayvansatiscinsiyetlbl)
        Me.PanelDesktop.Controls.Add(Me.sahibinadılbl)
        Me.PanelDesktop.Controls.Add(Me.hayvanadılbl)
        Me.PanelDesktop.Controls.Add(Me.sonasitarihi)
        Me.PanelDesktop.Controls.Add(Me.satisacıklamatxt)
        Me.PanelDesktop.Controls.Add(Me.ksırılastırmatxt)
        Me.PanelDesktop.Controls.Add(Me.alerjitxt)
        Me.PanelDesktop.Controls.Add(Me.hayvanyastxt)
        Me.PanelDesktop.Controls.Add(Me.hayvancintxt)
        Me.PanelDesktop.Controls.Add(Me.HayvanTurTtx)
        Me.PanelDesktop.Controls.Add(Me.hayvancinsiyettxt)
        Me.PanelDesktop.Controls.Add(Me.sahibadıtxt)
        Me.PanelDesktop.Controls.Add(Me.HayvanAdıSt)
        Me.PanelDesktop.Controls.Add(Me.soldananimalsdata)
        Me.PanelDesktop.Controls.Add(Me.btnClose)
        Me.PanelDesktop.Controls.Add(Me.btnMin)
        Me.PanelDesktop.Controls.Add(Me.satılanahyavanlarlbl)
        Me.PanelDesktop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PanelDesktop.Location = New System.Drawing.Point(248, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1615, 777)
        Me.PanelDesktop.TabIndex = 2
        '
        'btnFilterr
        '
        Me.btnFilterr.ActiveBorderThickness = 1
        Me.btnFilterr.ActiveCornerRadius = 20
        Me.btnFilterr.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilterr.ActiveForecolor = System.Drawing.Color.Ivory
        Me.btnFilterr.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFilterr.BackColor = System.Drawing.Color.Ivory
        Me.btnFilterr.BackgroundImage = CType(resources.GetObject("btnFilterr.BackgroundImage"), System.Drawing.Image)
        Me.btnFilterr.ButtonText = "Filtrele"
        Me.btnFilterr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFilterr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnFilterr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilterr.IdleBorderThickness = 1
        Me.btnFilterr.IdleCornerRadius = 20
        Me.btnFilterr.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFilterr.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilterr.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFilterr.Location = New System.Drawing.Point(782, 242)
        Me.btnFilterr.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFilterr.Name = "btnFilterr"
        Me.btnFilterr.Size = New System.Drawing.Size(85, 48)
        Me.btnFilterr.TabIndex = 75
        Me.btnFilterr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTemizlee
        '
        Me.BtnTemizlee.ActiveBorderThickness = 1
        Me.BtnTemizlee.ActiveCornerRadius = 20
        Me.BtnTemizlee.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizlee.ActiveForecolor = System.Drawing.Color.Ivory
        Me.BtnTemizlee.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTemizlee.BackColor = System.Drawing.Color.Ivory
        Me.BtnTemizlee.BackgroundImage = CType(resources.GetObject("BtnTemizlee.BackgroundImage"), System.Drawing.Image)
        Me.BtnTemizlee.ButtonText = "Temizle"
        Me.BtnTemizlee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTemizlee.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BtnTemizlee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizlee.IdleBorderThickness = 1
        Me.BtnTemizlee.IdleCornerRadius = 20
        Me.BtnTemizlee.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTemizlee.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizlee.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnTemizlee.Location = New System.Drawing.Point(656, 242)
        Me.BtnTemizlee.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnTemizlee.Name = "BtnTemizlee"
        Me.BtnTemizlee.Size = New System.Drawing.Size(85, 48)
        Me.BtnTemizlee.TabIndex = 74
        Me.BtnTemizlee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SatılanHayvanGunBtn
        '
        Me.SatılanHayvanGunBtn.ActiveBorderThickness = 1
        Me.SatılanHayvanGunBtn.ActiveCornerRadius = 20
        Me.SatılanHayvanGunBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanGunBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.SatılanHayvanGunBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SatılanHayvanGunBtn.BackColor = System.Drawing.Color.Ivory
        Me.SatılanHayvanGunBtn.BackgroundImage = CType(resources.GetObject("SatılanHayvanGunBtn.BackgroundImage"), System.Drawing.Image)
        Me.SatılanHayvanGunBtn.ButtonText = "Güncelle"
        Me.SatılanHayvanGunBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SatılanHayvanGunBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SatılanHayvanGunBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanGunBtn.IdleBorderThickness = 1
        Me.SatılanHayvanGunBtn.IdleCornerRadius = 20
        Me.SatılanHayvanGunBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SatılanHayvanGunBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanGunBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanGunBtn.Location = New System.Drawing.Point(534, 242)
        Me.SatılanHayvanGunBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SatılanHayvanGunBtn.Name = "SatılanHayvanGunBtn"
        Me.SatılanHayvanGunBtn.Size = New System.Drawing.Size(85, 48)
        Me.SatılanHayvanGunBtn.TabIndex = 73
        Me.SatılanHayvanGunBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SatılanHayvanSilBtn
        '
        Me.SatılanHayvanSilBtn.ActiveBorderThickness = 1
        Me.SatılanHayvanSilBtn.ActiveCornerRadius = 20
        Me.SatılanHayvanSilBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanSilBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.SatılanHayvanSilBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SatılanHayvanSilBtn.BackColor = System.Drawing.Color.Ivory
        Me.SatılanHayvanSilBtn.BackgroundImage = CType(resources.GetObject("SatılanHayvanSilBtn.BackgroundImage"), System.Drawing.Image)
        Me.SatılanHayvanSilBtn.ButtonText = "Sil"
        Me.SatılanHayvanSilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SatılanHayvanSilBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SatılanHayvanSilBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanSilBtn.IdleBorderThickness = 1
        Me.SatılanHayvanSilBtn.IdleCornerRadius = 20
        Me.SatılanHayvanSilBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SatılanHayvanSilBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanSilBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanSilBtn.Location = New System.Drawing.Point(406, 242)
        Me.SatılanHayvanSilBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SatılanHayvanSilBtn.Name = "SatılanHayvanSilBtn"
        Me.SatılanHayvanSilBtn.Size = New System.Drawing.Size(85, 48)
        Me.SatılanHayvanSilBtn.TabIndex = 72
        Me.SatılanHayvanSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SatılanHayvanEkleBtn
        '
        Me.SatılanHayvanEkleBtn.ActiveBorderThickness = 1
        Me.SatılanHayvanEkleBtn.ActiveCornerRadius = 20
        Me.SatılanHayvanEkleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanEkleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.SatılanHayvanEkleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SatılanHayvanEkleBtn.BackColor = System.Drawing.Color.Ivory
        Me.SatılanHayvanEkleBtn.BackgroundImage = CType(resources.GetObject("SatılanHayvanEkleBtn.BackgroundImage"), System.Drawing.Image)
        Me.SatılanHayvanEkleBtn.ButtonText = "Ekle"
        Me.SatılanHayvanEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SatılanHayvanEkleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SatılanHayvanEkleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanEkleBtn.IdleBorderThickness = 1
        Me.SatılanHayvanEkleBtn.IdleCornerRadius = 20
        Me.SatılanHayvanEkleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SatılanHayvanEkleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanEkleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.SatılanHayvanEkleBtn.Location = New System.Drawing.Point(282, 242)
        Me.SatılanHayvanEkleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SatılanHayvanEkleBtn.Name = "SatılanHayvanEkleBtn"
        Me.SatılanHayvanEkleBtn.Size = New System.Drawing.Size(85, 48)
        Me.SatılanHayvanEkleBtn.TabIndex = 71
        Me.SatılanHayvanEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'satisaciklamalbl
        '
        Me.satisaciklamalbl.BackColor = System.Drawing.Color.Ivory
        Me.satisaciklamalbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.satisaciklamalbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satisaciklamalbl.Location = New System.Drawing.Point(521, 161)
        Me.satisaciklamalbl.Name = "satisaciklamalbl"
        Me.satisaciklamalbl.Size = New System.Drawing.Size(182, 25)
        Me.satisaciklamalbl.TabIndex = 70
        Me.satisaciklamalbl.Text = "Açıklama"
        Me.satisaciklamalbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ksırılastırmadurumulbl
        '
        Me.ksırılastırmadurumulbl.BackColor = System.Drawing.Color.Ivory
        Me.ksırılastırmadurumulbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ksırılastırmadurumulbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ksırılastırmadurumulbl.Location = New System.Drawing.Point(279, 161)
        Me.ksırılastırmadurumulbl.Name = "ksırılastırmadurumulbl"
        Me.ksırılastırmadurumulbl.Size = New System.Drawing.Size(182, 25)
        Me.ksırılastırmadurumulbl.TabIndex = 69
        Me.ksırılastırmadurumulbl.Text = "Kışırlaştırma Durumu"
        Me.ksırılastırmadurumulbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'alerjidurumulbl
        '
        Me.alerjidurumulbl.BackColor = System.Drawing.Color.Ivory
        Me.alerjidurumulbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.alerjidurumulbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.alerjidurumulbl.Location = New System.Drawing.Point(40, 161)
        Me.alerjidurumulbl.Name = "alerjidurumulbl"
        Me.alerjidurumulbl.Size = New System.Drawing.Size(182, 25)
        Me.alerjidurumulbl.TabIndex = 68
        Me.alerjidurumulbl.Text = "Alerji Durumu"
        Me.alerjidurumulbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sonasitariihlbl
        '
        Me.sonasitariihlbl.BackColor = System.Drawing.Color.Ivory
        Me.sonasitariihlbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sonasitariihlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sonasitariihlbl.Location = New System.Drawing.Point(755, 161)
        Me.sonasitariihlbl.Name = "sonasitariihlbl"
        Me.sonasitariihlbl.Size = New System.Drawing.Size(182, 25)
        Me.sonasitariihlbl.TabIndex = 67
        Me.sonasitariihlbl.Text = "Son Aşı Tarihi"
        Me.sonasitariihlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'satisyaslbl
        '
        Me.satisyaslbl.BackColor = System.Drawing.Color.Ivory
        Me.satisyaslbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.satisyaslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satisyaslbl.Location = New System.Drawing.Point(1173, 81)
        Me.satisyaslbl.Name = "satisyaslbl"
        Me.satisyaslbl.Size = New System.Drawing.Size(182, 25)
        Me.satisyaslbl.TabIndex = 66
        Me.satisyaslbl.Text = "Yaş"
        Me.satisyaslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'satiscinslbl
        '
        Me.satiscinslbl.BackColor = System.Drawing.Color.Ivory
        Me.satiscinslbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.satiscinslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satiscinslbl.Location = New System.Drawing.Point(974, 81)
        Me.satiscinslbl.Name = "satiscinslbl"
        Me.satiscinslbl.Size = New System.Drawing.Size(182, 25)
        Me.satiscinslbl.TabIndex = 65
        Me.satiscinslbl.Text = "Cins"
        Me.satiscinslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'turlblsatis
        '
        Me.turlblsatis.BackColor = System.Drawing.Color.Ivory
        Me.turlblsatis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.turlblsatis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.turlblsatis.Location = New System.Drawing.Point(755, 81)
        Me.turlblsatis.Name = "turlblsatis"
        Me.turlblsatis.Size = New System.Drawing.Size(182, 25)
        Me.turlblsatis.TabIndex = 64
        Me.turlblsatis.Text = "Tür"
        Me.turlblsatis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hayvansatiscinsiyetlbl
        '
        Me.hayvansatiscinsiyetlbl.BackColor = System.Drawing.Color.Ivory
        Me.hayvansatiscinsiyetlbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hayvansatiscinsiyetlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvansatiscinsiyetlbl.Location = New System.Drawing.Point(521, 81)
        Me.hayvansatiscinsiyetlbl.Name = "hayvansatiscinsiyetlbl"
        Me.hayvansatiscinsiyetlbl.Size = New System.Drawing.Size(182, 25)
        Me.hayvansatiscinsiyetlbl.TabIndex = 63
        Me.hayvansatiscinsiyetlbl.Text = "Cinsiyet"
        Me.hayvansatiscinsiyetlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sahibinadılbl
        '
        Me.sahibinadılbl.BackColor = System.Drawing.Color.Ivory
        Me.sahibinadılbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sahibinadılbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sahibinadılbl.Location = New System.Drawing.Point(279, 79)
        Me.sahibinadılbl.Name = "sahibinadılbl"
        Me.sahibinadılbl.Size = New System.Drawing.Size(182, 25)
        Me.sahibinadılbl.TabIndex = 62
        Me.sahibinadılbl.Text = "Sahibin Adı"
        Me.sahibinadılbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hayvanadılbl
        '
        Me.hayvanadılbl.BackColor = System.Drawing.Color.Ivory
        Me.hayvanadılbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.hayvanadılbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanadılbl.Location = New System.Drawing.Point(40, 79)
        Me.hayvanadılbl.Name = "hayvanadılbl"
        Me.hayvanadılbl.Size = New System.Drawing.Size(182, 25)
        Me.hayvanadılbl.TabIndex = 61
        Me.hayvanadılbl.Text = "Hayvan Adı"
        Me.hayvanadılbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sonasitarihi
        '
        Me.sonasitarihi.BackColor = System.Drawing.Color.Ivory
        Me.sonasitarihi.BorderRadius = 0
        Me.sonasitarihi.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sonasitarihi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sonasitarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sonasitarihi.FormatCustom = Nothing
        Me.sonasitarihi.Location = New System.Drawing.Point(755, 189)
        Me.sonasitarihi.Margin = New System.Windows.Forms.Padding(4)
        Me.sonasitarihi.Name = "sonasitarihi"
        Me.sonasitarihi.Size = New System.Drawing.Size(182, 33)
        Me.sonasitarihi.TabIndex = 60
        Me.sonasitarihi.Tag = "Son Kullanma Tarihi"
        Me.sonasitarihi.Value = New Date(2024, 3, 26, 13, 21, 43, 258)
        '
        'satisacıklamatxt
        '
        Me.satisacıklamatxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.satisacıklamatxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satisacıklamatxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.satisacıklamatxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.satisacıklamatxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.satisacıklamatxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satisacıklamatxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.satisacıklamatxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satisacıklamatxt.Location = New System.Drawing.Point(521, 189)
        Me.satisacıklamatxt.Name = "satisacıklamatxt"
        Me.satisacıklamatxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.satisacıklamatxt.SelectedText = ""
        Me.satisacıklamatxt.Size = New System.Drawing.Size(182, 33)
        Me.satisacıklamatxt.TabIndex = 58
        Me.satisacıklamatxt.Tag = ""
        '
        'ksırılastırmatxt
        '
        Me.ksırılastırmatxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ksırılastırmatxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ksırılastırmatxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ksırılastırmatxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.ksırılastırmatxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ksırılastırmatxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ksırılastırmatxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ksırılastırmatxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.ksırılastırmatxt.Location = New System.Drawing.Point(279, 189)
        Me.ksırılastırmatxt.Name = "ksırılastırmatxt"
        Me.ksırılastırmatxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ksırılastırmatxt.SelectedText = ""
        Me.ksırılastırmatxt.Size = New System.Drawing.Size(182, 33)
        Me.ksırılastırmatxt.TabIndex = 57
        Me.ksırılastırmatxt.Tag = ""
        '
        'alerjitxt
        '
        Me.alerjitxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.alerjitxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.alerjitxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.alerjitxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.alerjitxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.alerjitxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.alerjitxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.alerjitxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.alerjitxt.Location = New System.Drawing.Point(40, 189)
        Me.alerjitxt.Name = "alerjitxt"
        Me.alerjitxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.alerjitxt.SelectedText = ""
        Me.alerjitxt.Size = New System.Drawing.Size(182, 33)
        Me.alerjitxt.TabIndex = 56
        Me.alerjitxt.Tag = ""
        '
        'hayvanyastxt
        '
        Me.hayvanyastxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvanyastxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanyastxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hayvanyastxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.hayvanyastxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvanyastxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanyastxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.hayvanyastxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanyastxt.Location = New System.Drawing.Point(1173, 109)
        Me.hayvanyastxt.Name = "hayvanyastxt"
        Me.hayvanyastxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.hayvanyastxt.SelectedText = ""
        Me.hayvanyastxt.Size = New System.Drawing.Size(182, 33)
        Me.hayvanyastxt.TabIndex = 55
        Me.hayvanyastxt.Tag = ""
        '
        'hayvancintxt
        '
        Me.hayvancintxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvancintxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvancintxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hayvancintxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.hayvancintxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvancintxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvancintxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.hayvancintxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvancintxt.Location = New System.Drawing.Point(974, 109)
        Me.hayvancintxt.Name = "hayvancintxt"
        Me.hayvancintxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.hayvancintxt.SelectedText = ""
        Me.hayvancintxt.Size = New System.Drawing.Size(182, 33)
        Me.hayvancintxt.TabIndex = 54
        Me.hayvancintxt.Tag = ""
        '
        'HayvanTurTtx
        '
        Me.HayvanTurTtx.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanTurTtx.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanTurTtx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayvanTurTtx.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayvanTurTtx.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanTurTtx.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanTurTtx.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayvanTurTtx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanTurTtx.Location = New System.Drawing.Point(755, 109)
        Me.HayvanTurTtx.Name = "HayvanTurTtx"
        Me.HayvanTurTtx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayvanTurTtx.SelectedText = ""
        Me.HayvanTurTtx.Size = New System.Drawing.Size(182, 33)
        Me.HayvanTurTtx.TabIndex = 53
        Me.HayvanTurTtx.Tag = ""
        '
        'hayvancinsiyettxt
        '
        Me.hayvancinsiyettxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvancinsiyettxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvancinsiyettxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hayvancinsiyettxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.hayvancinsiyettxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvancinsiyettxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvancinsiyettxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.hayvancinsiyettxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvancinsiyettxt.Location = New System.Drawing.Point(521, 109)
        Me.hayvancinsiyettxt.Name = "hayvancinsiyettxt"
        Me.hayvancinsiyettxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.hayvancinsiyettxt.SelectedText = ""
        Me.hayvancinsiyettxt.Size = New System.Drawing.Size(182, 33)
        Me.hayvancinsiyettxt.TabIndex = 52
        Me.hayvancinsiyettxt.Tag = ""
        '
        'sahibadıtxt
        '
        Me.sahibadıtxt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sahibadıtxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sahibadıtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sahibadıtxt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.sahibadıtxt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sahibadıtxt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sahibadıtxt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sahibadıtxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.sahibadıtxt.Location = New System.Drawing.Point(279, 109)
        Me.sahibadıtxt.Name = "sahibadıtxt"
        Me.sahibadıtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.sahibadıtxt.SelectedText = ""
        Me.sahibadıtxt.Size = New System.Drawing.Size(182, 33)
        Me.sahibadıtxt.TabIndex = 51
        Me.sahibadıtxt.Tag = ""
        '
        'HayvanAdıSt
        '
        Me.HayvanAdıSt.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanAdıSt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanAdıSt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayvanAdıSt.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayvanAdıSt.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanAdıSt.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanAdıSt.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayvanAdıSt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanAdıSt.Location = New System.Drawing.Point(40, 109)
        Me.HayvanAdıSt.Name = "HayvanAdıSt"
        Me.HayvanAdıSt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayvanAdıSt.SelectedText = ""
        Me.HayvanAdıSt.Size = New System.Drawing.Size(182, 33)
        Me.HayvanAdıSt.TabIndex = 50
        Me.HayvanAdıSt.Tag = ""
        '
        'soldananimalsdata
        '
        Me.soldananimalsdata.AllowUserToAddRows = False
        Me.soldananimalsdata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.soldananimalsdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.soldananimalsdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.soldananimalsdata.BackgroundColor = System.Drawing.Color.Ivory
        Me.soldananimalsdata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.soldananimalsdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.soldananimalsdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.soldananimalsdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.soldananimalsdata.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.soldananimalsdata.DefaultCellStyle = DataGridViewCellStyle3
        Me.soldananimalsdata.DoubleBuffered = True
        Me.soldananimalsdata.EnableHeadersVisualStyles = False
        Me.soldananimalsdata.GridColor = System.Drawing.Color.Ivory
        Me.soldananimalsdata.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.soldananimalsdata.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.soldananimalsdata.Location = New System.Drawing.Point(40, 316)
        Me.soldananimalsdata.Name = "soldananimalsdata"
        Me.soldananimalsdata.ReadOnly = True
        Me.soldananimalsdata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.soldananimalsdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.soldananimalsdata.RowHeadersVisible = False
        Me.soldananimalsdata.RowHeadersWidth = 51
        Me.soldananimalsdata.RowTemplate.DividerHeight = 1
        Me.soldananimalsdata.RowTemplate.Height = 25
        Me.soldananimalsdata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.soldananimalsdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.soldananimalsdata.Size = New System.Drawing.Size(1315, 418)
        Me.soldananimalsdata.TabIndex = 49
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
        Me.btnClose.TabIndex = 20
        Me.btnClose.TabStop = False
        Me.btnClose.Zoom = 10
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
        Me.btnMin.TabIndex = 19
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'satılanahyavanlarlbl
        '
        Me.satılanahyavanlarlbl.AutoEllipsis = True
        Me.satılanahyavanlarlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.satılanahyavanlarlbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.satılanahyavanlarlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.satılanahyavanlarlbl.Location = New System.Drawing.Point(0, 0)
        Me.satılanahyavanlarlbl.Name = "satılanahyavanlarlbl"
        Me.satılanahyavanlarlbl.Size = New System.Drawing.Size(1272, 48)
        Me.satılanahyavanlarlbl.TabIndex = 18
        Me.satılanahyavanlarlbl.Text = "Satılan Hayvanlar"
        Me.satılanahyavanlarlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SoldAnimals
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1615, 777)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SoldAnimals"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SoldAnimals"
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.soldananimalsdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SoldBtn As FontAwesome.Sharp.IconButton
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
    Friend WithEvents satılanahyavanlarlbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents soldananimalsdata As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents satisacıklamatxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents ksırılastırmatxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents alerjitxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents hayvanyastxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents hayvancintxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayvanTurTtx As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents hayvancinsiyettxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sahibadıtxt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayvanAdıSt As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sonasitarihi As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents ksırılastırmadurumulbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents alerjidurumulbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sonasitariihlbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents satisyaslbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents satiscinslbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents turlblsatis As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents hayvansatiscinsiyetlbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents sahibinadılbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents hayvanadılbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents satisaciklamalbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SatılanHayvanEkleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SatılanHayvanSilBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SatılanHayvanGunBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnTemizlee As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnFilterr As Bunifu.Framework.UI.BunifuThinButton2
End Class
