<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PetsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PetsForm))
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
        Me.yasaralıgılbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnFiltrele = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtMaxYas = New Guna.UI.WinForms.GunaTextBox()
        Me.txtMinYas = New Guna.UI.WinForms.GunaTextBox()
        Me.cbHayvanTür = New System.Windows.Forms.ComboBox()
        Me.cbHayCins = New System.Windows.Forms.ComboBox()
        Me.hayvanlardata = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BtnTemizle = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.HayAcikl = New Guna.UI.WinForms.GunaTextBox()
        Me.HayAciklLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayCinsi = New Guna.UI.WinForms.GunaTextBox()
        Me.HayCinsiLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayMal = New Guna.UI.WinForms.GunaTextBox()
        Me.HayMalLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayFiy = New Guna.UI.WinForms.GunaTextBox()
        Me.HayFiyLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayYas = New Guna.UI.WinForms.GunaTextBox()
        Me.HayYasLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayCinsLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayTurLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.HayvanGünBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.HayvanSilBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.HayvanEkleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.hayvanstok = New Guna.UI.WinForms.GunaTextBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.hayvanlardata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
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
        Me.PanelDesktop.Controls.Add(Me.BunifuCustomLabel2)
        Me.PanelDesktop.Controls.Add(Me.hayvanstok)
        Me.PanelDesktop.Controls.Add(Me.yasaralıgılbl)
        Me.PanelDesktop.Controls.Add(Me.btnFiltrele)
        Me.PanelDesktop.Controls.Add(Me.txtMaxYas)
        Me.PanelDesktop.Controls.Add(Me.txtMinYas)
        Me.PanelDesktop.Controls.Add(Me.cbHayvanTür)
        Me.PanelDesktop.Controls.Add(Me.cbHayCins)
        Me.PanelDesktop.Controls.Add(Me.hayvanlardata)
        Me.PanelDesktop.Controls.Add(Me.BtnTemizle)
        Me.PanelDesktop.Controls.Add(Me.HayAcikl)
        Me.PanelDesktop.Controls.Add(Me.HayAciklLbl)
        Me.PanelDesktop.Controls.Add(Me.HayCinsi)
        Me.PanelDesktop.Controls.Add(Me.HayCinsiLbl)
        Me.PanelDesktop.Controls.Add(Me.HayMal)
        Me.PanelDesktop.Controls.Add(Me.HayMalLbl)
        Me.PanelDesktop.Controls.Add(Me.HayFiy)
        Me.PanelDesktop.Controls.Add(Me.HayFiyLbl)
        Me.PanelDesktop.Controls.Add(Me.HayYas)
        Me.PanelDesktop.Controls.Add(Me.HayYasLbl)
        Me.PanelDesktop.Controls.Add(Me.HayCinsLbl)
        Me.PanelDesktop.Controls.Add(Me.HayTurLbl)
        Me.PanelDesktop.Controls.Add(Me.HayvanGünBtn)
        Me.PanelDesktop.Controls.Add(Me.HayvanSilBtn)
        Me.PanelDesktop.Controls.Add(Me.HayvanEkleBtn)
        Me.PanelDesktop.Controls.Add(Me.PanelHeader)
        Me.PanelDesktop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PanelDesktop.Location = New System.Drawing.Point(248, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1615, 777)
        Me.PanelDesktop.TabIndex = 2
        '
        'yasaralıgılbl
        '
        Me.yasaralıgılbl.BackColor = System.Drawing.Color.Ivory
        Me.yasaralıgılbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.yasaralıgılbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.yasaralıgılbl.Location = New System.Drawing.Point(855, 150)
        Me.yasaralıgılbl.Name = "yasaralıgılbl"
        Me.yasaralıgılbl.Size = New System.Drawing.Size(417, 25)
        Me.yasaralıgılbl.TabIndex = 78
        Me.yasaralıgılbl.Text = "Yaş Aralığı Giriniz"
        Me.yasaralıgılbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFiltrele
        '
        Me.btnFiltrele.ActiveBorderThickness = 1
        Me.btnFiltrele.ActiveCornerRadius = 20
        Me.btnFiltrele.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFiltrele.ActiveForecolor = System.Drawing.Color.Ivory
        Me.btnFiltrele.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFiltrele.BackColor = System.Drawing.Color.Ivory
        Me.btnFiltrele.BackgroundImage = CType(resources.GetObject("btnFiltrele.BackgroundImage"), System.Drawing.Image)
        Me.btnFiltrele.ButtonText = "Filtrele"
        Me.btnFiltrele.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrele.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnFiltrele.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFiltrele.IdleBorderThickness = 1
        Me.btnFiltrele.IdleCornerRadius = 20
        Me.btnFiltrele.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFiltrele.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFiltrele.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.btnFiltrele.Location = New System.Drawing.Point(952, 236)
        Me.btnFiltrele.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFiltrele.Name = "btnFiltrele"
        Me.btnFiltrele.Size = New System.Drawing.Size(85, 47)
        Me.btnFiltrele.TabIndex = 77
        Me.btnFiltrele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaxYas
        '
        Me.txtMaxYas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMaxYas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMaxYas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaxYas.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.txtMaxYas.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMaxYas.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMaxYas.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMaxYas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMaxYas.Location = New System.Drawing.Point(1090, 181)
        Me.txtMaxYas.Name = "txtMaxYas"
        Me.txtMaxYas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaxYas.SelectedText = ""
        Me.txtMaxYas.Size = New System.Drawing.Size(182, 33)
        Me.txtMaxYas.TabIndex = 76
        Me.txtMaxYas.Tag = ""
        '
        'txtMinYas
        '
        Me.txtMinYas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMinYas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMinYas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMinYas.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.txtMinYas.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMinYas.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMinYas.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtMinYas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.txtMinYas.Location = New System.Drawing.Point(855, 181)
        Me.txtMinYas.Name = "txtMinYas"
        Me.txtMinYas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMinYas.SelectedText = ""
        Me.txtMinYas.Size = New System.Drawing.Size(182, 33)
        Me.txtMinYas.TabIndex = 75
        Me.txtMinYas.Tag = ""
        '
        'cbHayvanTür
        '
        Me.cbHayvanTür.BackColor = System.Drawing.Color.Ivory
        Me.cbHayvanTür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHayvanTür.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbHayvanTür.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbHayvanTür.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.cbHayvanTür.FormattingEnabled = True
        Me.cbHayvanTür.IntegralHeight = False
        Me.cbHayvanTür.ItemHeight = 17
        Me.cbHayvanTür.Location = New System.Drawing.Point(91, 105)
        Me.cbHayvanTür.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbHayvanTür.Name = "cbHayvanTür"
        Me.cbHayvanTür.Size = New System.Drawing.Size(182, 25)
        Me.cbHayvanTür.TabIndex = 74
        '
        'cbHayCins
        '
        Me.cbHayCins.BackColor = System.Drawing.Color.Ivory
        Me.cbHayCins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbHayCins.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbHayCins.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.cbHayCins.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.cbHayCins.FormattingEnabled = True
        Me.cbHayCins.IntegralHeight = False
        Me.cbHayCins.ItemHeight = 17
        Me.cbHayCins.Location = New System.Drawing.Point(353, 104)
        Me.cbHayCins.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbHayCins.Name = "cbHayCins"
        Me.cbHayCins.Size = New System.Drawing.Size(182, 25)
        Me.cbHayCins.TabIndex = 73
        '
        'hayvanlardata
        '
        Me.hayvanlardata.AllowUserToAddRows = False
        Me.hayvanlardata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.hayvanlardata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.hayvanlardata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.hayvanlardata.BackgroundColor = System.Drawing.Color.Ivory
        Me.hayvanlardata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.hayvanlardata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.hayvanlardata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.hayvanlardata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.hayvanlardata.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.hayvanlardata.DefaultCellStyle = DataGridViewCellStyle3
        Me.hayvanlardata.DoubleBuffered = True
        Me.hayvanlardata.EnableHeadersVisualStyles = False
        Me.hayvanlardata.GridColor = System.Drawing.Color.Ivory
        Me.hayvanlardata.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanlardata.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvanlardata.Location = New System.Drawing.Point(91, 306)
        Me.hayvanlardata.Name = "hayvanlardata"
        Me.hayvanlardata.ReadOnly = True
        Me.hayvanlardata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.hayvanlardata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.hayvanlardata.RowHeadersVisible = False
        Me.hayvanlardata.RowHeadersWidth = 51
        Me.hayvanlardata.RowTemplate.DividerHeight = 1
        Me.hayvanlardata.RowTemplate.Height = 25
        Me.hayvanlardata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.hayvanlardata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.hayvanlardata.Size = New System.Drawing.Size(1181, 429)
        Me.hayvanlardata.TabIndex = 70
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
        Me.BtnTemizle.Location = New System.Drawing.Point(791, 236)
        Me.BtnTemizle.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnTemizle.Name = "BtnTemizle"
        Me.BtnTemizle.Size = New System.Drawing.Size(85, 47)
        Me.BtnTemizle.TabIndex = 48
        Me.BtnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HayAcikl
        '
        Me.HayAcikl.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayAcikl.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayAcikl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayAcikl.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayAcikl.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayAcikl.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayAcikl.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayAcikl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayAcikl.Location = New System.Drawing.Point(603, 179)
        Me.HayAcikl.Name = "HayAcikl"
        Me.HayAcikl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayAcikl.SelectedText = ""
        Me.HayAcikl.Size = New System.Drawing.Size(182, 33)
        Me.HayAcikl.TabIndex = 64
        Me.HayAcikl.Tag = ""
        '
        'HayAciklLbl
        '
        Me.HayAciklLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayAciklLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayAciklLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayAciklLbl.Location = New System.Drawing.Point(603, 150)
        Me.HayAciklLbl.Name = "HayAciklLbl"
        Me.HayAciklLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayAciklLbl.TabIndex = 69
        Me.HayAciklLbl.Text = "Açıklama"
        Me.HayAciklLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayCinsi
        '
        Me.HayCinsi.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayCinsi.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayCinsi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayCinsi.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayCinsi.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayCinsi.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayCinsi.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayCinsi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayCinsi.Location = New System.Drawing.Point(91, 179)
        Me.HayCinsi.Name = "HayCinsi"
        Me.HayCinsi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayCinsi.SelectedText = ""
        Me.HayCinsi.Size = New System.Drawing.Size(182, 33)
        Me.HayCinsi.TabIndex = 63
        Me.HayCinsi.Tag = ""
        '
        'HayCinsiLbl
        '
        Me.HayCinsiLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayCinsiLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayCinsiLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayCinsiLbl.Location = New System.Drawing.Point(91, 150)
        Me.HayCinsiLbl.Name = "HayCinsiLbl"
        Me.HayCinsiLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayCinsiLbl.TabIndex = 67
        Me.HayCinsiLbl.Text = "Cinsiyet"
        Me.HayCinsiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayMal
        '
        Me.HayMal.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayMal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayMal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayMal.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayMal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayMal.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayMal.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayMal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayMal.Location = New System.Drawing.Point(855, 100)
        Me.HayMal.Name = "HayMal"
        Me.HayMal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayMal.SelectedText = ""
        Me.HayMal.Size = New System.Drawing.Size(182, 33)
        Me.HayMal.TabIndex = 61
        Me.HayMal.Tag = ""
        '
        'HayMalLbl
        '
        Me.HayMalLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayMalLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayMalLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayMalLbl.Location = New System.Drawing.Point(855, 69)
        Me.HayMalLbl.Name = "HayMalLbl"
        Me.HayMalLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayMalLbl.TabIndex = 65
        Me.HayMalLbl.Text = "Maliyet"
        Me.HayMalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayFiy
        '
        Me.HayFiy.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayFiy.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayFiy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayFiy.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayFiy.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayFiy.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayFiy.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayFiy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayFiy.Location = New System.Drawing.Point(1090, 100)
        Me.HayFiy.Name = "HayFiy"
        Me.HayFiy.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayFiy.SelectedText = ""
        Me.HayFiy.Size = New System.Drawing.Size(182, 33)
        Me.HayFiy.TabIndex = 62
        Me.HayFiy.Tag = ""
        '
        'HayFiyLbl
        '
        Me.HayFiyLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayFiyLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayFiyLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayFiyLbl.Location = New System.Drawing.Point(1090, 69)
        Me.HayFiyLbl.Name = "HayFiyLbl"
        Me.HayFiyLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayFiyLbl.TabIndex = 63
        Me.HayFiyLbl.Text = "Fiyat"
        Me.HayFiyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayYas
        '
        Me.HayYas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayYas.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayYas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.HayYas.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.HayYas.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayYas.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayYas.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayYas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayYas.Location = New System.Drawing.Point(603, 101)
        Me.HayYas.Name = "HayYas"
        Me.HayYas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.HayYas.SelectedText = ""
        Me.HayYas.Size = New System.Drawing.Size(182, 33)
        Me.HayYas.TabIndex = 60
        Me.HayYas.Tag = ""
        '
        'HayYasLbl
        '
        Me.HayYasLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayYasLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayYasLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayYasLbl.Location = New System.Drawing.Point(603, 69)
        Me.HayYasLbl.Name = "HayYasLbl"
        Me.HayYasLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayYasLbl.TabIndex = 61
        Me.HayYasLbl.Text = "Yaş"
        Me.HayYasLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayCinsLbl
        '
        Me.HayCinsLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayCinsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayCinsLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayCinsLbl.Location = New System.Drawing.Point(353, 69)
        Me.HayCinsLbl.Name = "HayCinsLbl"
        Me.HayCinsLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayCinsLbl.TabIndex = 59
        Me.HayCinsLbl.Text = "Cins"
        Me.HayCinsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayTurLbl
        '
        Me.HayTurLbl.BackColor = System.Drawing.Color.Ivory
        Me.HayTurLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HayTurLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayTurLbl.Location = New System.Drawing.Point(91, 69)
        Me.HayTurLbl.Name = "HayTurLbl"
        Me.HayTurLbl.Size = New System.Drawing.Size(182, 25)
        Me.HayTurLbl.TabIndex = 47
        Me.HayTurLbl.Text = "Tür"
        Me.HayTurLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HayvanGünBtn
        '
        Me.HayvanGünBtn.ActiveBorderThickness = 1
        Me.HayvanGünBtn.ActiveCornerRadius = 20
        Me.HayvanGünBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanGünBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.HayvanGünBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanGünBtn.BackColor = System.Drawing.Color.Ivory
        Me.HayvanGünBtn.BackgroundImage = CType(resources.GetObject("HayvanGünBtn.BackgroundImage"), System.Drawing.Image)
        Me.HayvanGünBtn.ButtonText = "Güncelle"
        Me.HayvanGünBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HayvanGünBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayvanGünBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanGünBtn.IdleBorderThickness = 1
        Me.HayvanGünBtn.IdleCornerRadius = 20
        Me.HayvanGünBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanGünBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanGünBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanGünBtn.Location = New System.Drawing.Point(643, 236)
        Me.HayvanGünBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.HayvanGünBtn.Name = "HayvanGünBtn"
        Me.HayvanGünBtn.Size = New System.Drawing.Size(85, 47)
        Me.HayvanGünBtn.TabIndex = 67
        Me.HayvanGünBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HayvanSilBtn
        '
        Me.HayvanSilBtn.ActiveBorderThickness = 1
        Me.HayvanSilBtn.ActiveCornerRadius = 20
        Me.HayvanSilBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanSilBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.HayvanSilBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanSilBtn.BackColor = System.Drawing.Color.Ivory
        Me.HayvanSilBtn.BackgroundImage = CType(resources.GetObject("HayvanSilBtn.BackgroundImage"), System.Drawing.Image)
        Me.HayvanSilBtn.ButtonText = "Sil"
        Me.HayvanSilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HayvanSilBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayvanSilBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanSilBtn.IdleBorderThickness = 1
        Me.HayvanSilBtn.IdleCornerRadius = 20
        Me.HayvanSilBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanSilBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanSilBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanSilBtn.Location = New System.Drawing.Point(496, 236)
        Me.HayvanSilBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.HayvanSilBtn.Name = "HayvanSilBtn"
        Me.HayvanSilBtn.Size = New System.Drawing.Size(90, 47)
        Me.HayvanSilBtn.TabIndex = 66
        Me.HayvanSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HayvanEkleBtn
        '
        Me.HayvanEkleBtn.ActiveBorderThickness = 1
        Me.HayvanEkleBtn.ActiveCornerRadius = 20
        Me.HayvanEkleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanEkleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.HayvanEkleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanEkleBtn.BackColor = System.Drawing.Color.Ivory
        Me.HayvanEkleBtn.BackgroundImage = CType(resources.GetObject("HayvanEkleBtn.BackgroundImage"), System.Drawing.Image)
        Me.HayvanEkleBtn.ButtonText = "Ekle"
        Me.HayvanEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HayvanEkleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HayvanEkleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanEkleBtn.IdleBorderThickness = 1
        Me.HayvanEkleBtn.IdleCornerRadius = 20
        Me.HayvanEkleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HayvanEkleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanEkleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.HayvanEkleBtn.Location = New System.Drawing.Point(356, 236)
        Me.HayvanEkleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.HayvanEkleBtn.Name = "HayvanEkleBtn"
        Me.HayvanEkleBtn.Size = New System.Drawing.Size(82, 47)
        Me.HayvanEkleBtn.TabIndex = 65
        Me.HayvanEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.BunifuCustomLabel1)
        Me.PanelHeader.Controls.Add(Me.btnClose)
        Me.PanelHeader.Controls.Add(Me.btnMin)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(1615, 48)
        Me.PanelHeader.TabIndex = 14
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
        Me.BunifuCustomLabel1.Text = "Hayvanlar"
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
        Me.btnClose.TabIndex = 16
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
        Me.btnMin.TabIndex = 15
        Me.btnMin.TabStop = False
        Me.btnMin.Zoom = 10
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 7
        Me.BunifuElipse1.TargetControl = Me.hayvanlardata
        '
        'hayvanstok
        '
        Me.hayvanstok.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvanstok.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanstok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hayvanstok.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.hayvanstok.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.hayvanstok.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanstok.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.hayvanstok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.hayvanstok.Location = New System.Drawing.Point(353, 181)
        Me.hayvanstok.Name = "hayvanstok"
        Me.hayvanstok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.hayvanstok.SelectedText = ""
        Me.hayvanstok.Size = New System.Drawing.Size(182, 33)
        Me.hayvanstok.TabIndex = 79
        Me.hayvanstok.Tag = ""
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Ivory
        Me.BunifuCustomLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(353, 150)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(182, 25)
        Me.BunifuCustomLabel2.TabIndex = 80
        Me.BunifuCustomLabel2.Text = "Stok Sayısı"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PetsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1615, 777)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PetsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PetsForm"
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.hayvanlardata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents HayvanEkleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents HayvanSilBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents HayvanGünBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnMin As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayTurLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayCinsLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayAcikl As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayAciklLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayCinsi As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayCinsiLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayMal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayMalLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayFiy As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayFiyLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents HayYas As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents HayYasLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BtnTemizle As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents hayvanlardata As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents cbHayCins As ComboBox
    Friend WithEvents cbHayvanTür As ComboBox
    Friend WithEvents btnFiltrele As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtMaxYas As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtMinYas As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents yasaralıgılbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents SoldBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents hayvanstok As Guna.UI.WinForms.GunaTextBox
End Class
