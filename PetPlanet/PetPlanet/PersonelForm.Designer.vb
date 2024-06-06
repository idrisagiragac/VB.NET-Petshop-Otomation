<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PersonelForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PersonelForm))
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
        Me.personeldata = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BtnTemizle = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PerEPosta = New Guna.UI.WinForms.GunaTextBox()
        Me.PerTel = New Guna.UI.WinForms.GunaTextBox()
        Me.PerSoyadı = New Guna.UI.WinForms.GunaTextBox()
        Me.PerPoz = New Guna.UI.WinForms.GunaTextBox()
        Me.PerEpostaLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PerTelLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PerPozisyonLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PerSoyadıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PerAdıLbl = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PerAdı = New Guna.UI.WinForms.GunaTextBox()
        Me.PerGünBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PerSilBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PerEkleBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMin = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.personeldata, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelDesktop.Controls.Add(Me.personeldata)
        Me.PanelDesktop.Controls.Add(Me.BtnTemizle)
        Me.PanelDesktop.Controls.Add(Me.PerEPosta)
        Me.PanelDesktop.Controls.Add(Me.PerTel)
        Me.PanelDesktop.Controls.Add(Me.PerSoyadı)
        Me.PanelDesktop.Controls.Add(Me.PerPoz)
        Me.PanelDesktop.Controls.Add(Me.PerEpostaLbl)
        Me.PanelDesktop.Controls.Add(Me.PerTelLbl)
        Me.PanelDesktop.Controls.Add(Me.PerPozisyonLbl)
        Me.PanelDesktop.Controls.Add(Me.PerSoyadıLbl)
        Me.PanelDesktop.Controls.Add(Me.PerAdıLbl)
        Me.PanelDesktop.Controls.Add(Me.PerAdı)
        Me.PanelDesktop.Controls.Add(Me.PerGünBtn)
        Me.PanelDesktop.Controls.Add(Me.PerSilBtn)
        Me.PanelDesktop.Controls.Add(Me.PerEkleBtn)
        Me.PanelDesktop.Controls.Add(Me.PanelHeader)
        Me.PanelDesktop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PanelDesktop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PanelDesktop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PanelDesktop.Location = New System.Drawing.Point(248, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1615, 777)
        Me.PanelDesktop.TabIndex = 3
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
        Me.btnFilter.Location = New System.Drawing.Point(1187, 150)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(5)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(85, 48)
        Me.btnFilter.TabIndex = 49
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'personeldata
        '
        Me.personeldata.AllowUserToAddRows = False
        Me.personeldata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.personeldata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.personeldata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.personeldata.BackgroundColor = System.Drawing.Color.Ivory
        Me.personeldata.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.personeldata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.personeldata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.personeldata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.personeldata.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.personeldata.DefaultCellStyle = DataGridViewCellStyle3
        Me.personeldata.DoubleBuffered = True
        Me.personeldata.EnableHeadersVisualStyles = False
        Me.personeldata.GridColor = System.Drawing.Color.Ivory
        Me.personeldata.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.personeldata.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.personeldata.Location = New System.Drawing.Point(74, 239)
        Me.personeldata.Name = "personeldata"
        Me.personeldata.ReadOnly = True
        Me.personeldata.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Ivory
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.personeldata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.personeldata.RowHeadersVisible = False
        Me.personeldata.RowHeadersWidth = 51
        Me.personeldata.RowTemplate.DividerHeight = 1
        Me.personeldata.RowTemplate.Height = 25
        Me.personeldata.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.personeldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.personeldata.Size = New System.Drawing.Size(1198, 436)
        Me.personeldata.TabIndex = 48
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
        Me.BtnTemizle.Location = New System.Drawing.Point(1054, 150)
        Me.BtnTemizle.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnTemizle.Name = "BtnTemizle"
        Me.BtnTemizle.Size = New System.Drawing.Size(85, 48)
        Me.BtnTemizle.TabIndex = 47
        Me.BtnTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerEPosta
        '
        Me.PerEPosta.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerEPosta.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEPosta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PerEPosta.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PerEPosta.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerEPosta.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEPosta.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerEPosta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEPosta.Location = New System.Drawing.Point(1090, 100)
        Me.PerEPosta.Name = "PerEPosta"
        Me.PerEPosta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PerEPosta.SelectedText = ""
        Me.PerEPosta.Size = New System.Drawing.Size(182, 33)
        Me.PerEPosta.TabIndex = 34
        Me.PerEPosta.Tag = ""
        '
        'PerTel
        '
        Me.PerTel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerTel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerTel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PerTel.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PerTel.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerTel.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerTel.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerTel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerTel.Location = New System.Drawing.Point(826, 100)
        Me.PerTel.Name = "PerTel"
        Me.PerTel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PerTel.SelectedText = ""
        Me.PerTel.Size = New System.Drawing.Size(182, 33)
        Me.PerTel.TabIndex = 33
        Me.PerTel.Tag = ""
        '
        'PerSoyadı
        '
        Me.PerSoyadı.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerSoyadı.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSoyadı.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PerSoyadı.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PerSoyadı.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerSoyadı.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSoyadı.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerSoyadı.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSoyadı.Location = New System.Drawing.Point(316, 100)
        Me.PerSoyadı.Name = "PerSoyadı"
        Me.PerSoyadı.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PerSoyadı.SelectedText = ""
        Me.PerSoyadı.Size = New System.Drawing.Size(182, 33)
        Me.PerSoyadı.TabIndex = 31
        Me.PerSoyadı.Tag = ""
        '
        'PerPoz
        '
        Me.PerPoz.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerPoz.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerPoz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PerPoz.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PerPoz.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerPoz.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerPoz.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerPoz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerPoz.Location = New System.Drawing.Point(570, 100)
        Me.PerPoz.Name = "PerPoz"
        Me.PerPoz.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PerPoz.SelectedText = ""
        Me.PerPoz.Size = New System.Drawing.Size(182, 33)
        Me.PerPoz.TabIndex = 32
        Me.PerPoz.Tag = ""
        '
        'PerEpostaLbl
        '
        Me.PerEpostaLbl.BackColor = System.Drawing.Color.Ivory
        Me.PerEpostaLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PerEpostaLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEpostaLbl.Location = New System.Drawing.Point(1090, 69)
        Me.PerEpostaLbl.Name = "PerEpostaLbl"
        Me.PerEpostaLbl.Size = New System.Drawing.Size(182, 25)
        Me.PerEpostaLbl.TabIndex = 35
        Me.PerEpostaLbl.Text = "EPosta"
        Me.PerEpostaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PerTelLbl
        '
        Me.PerTelLbl.BackColor = System.Drawing.Color.Ivory
        Me.PerTelLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PerTelLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerTelLbl.Location = New System.Drawing.Point(826, 72)
        Me.PerTelLbl.Name = "PerTelLbl"
        Me.PerTelLbl.Size = New System.Drawing.Size(182, 25)
        Me.PerTelLbl.TabIndex = 34
        Me.PerTelLbl.Text = "Telefon"
        Me.PerTelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PerPozisyonLbl
        '
        Me.PerPozisyonLbl.BackColor = System.Drawing.Color.Ivory
        Me.PerPozisyonLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PerPozisyonLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerPozisyonLbl.Location = New System.Drawing.Point(570, 69)
        Me.PerPozisyonLbl.Name = "PerPozisyonLbl"
        Me.PerPozisyonLbl.Size = New System.Drawing.Size(182, 25)
        Me.PerPozisyonLbl.TabIndex = 33
        Me.PerPozisyonLbl.Text = "Pozisyon"
        Me.PerPozisyonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PerSoyadıLbl
        '
        Me.PerSoyadıLbl.BackColor = System.Drawing.Color.Ivory
        Me.PerSoyadıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PerSoyadıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSoyadıLbl.Location = New System.Drawing.Point(316, 69)
        Me.PerSoyadıLbl.Name = "PerSoyadıLbl"
        Me.PerSoyadıLbl.Size = New System.Drawing.Size(182, 25)
        Me.PerSoyadıLbl.TabIndex = 32
        Me.PerSoyadıLbl.Text = "Soyadı"
        Me.PerSoyadıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PerAdıLbl
        '
        Me.PerAdıLbl.BackColor = System.Drawing.Color.Ivory
        Me.PerAdıLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PerAdıLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerAdıLbl.Location = New System.Drawing.Point(74, 69)
        Me.PerAdıLbl.Name = "PerAdıLbl"
        Me.PerAdıLbl.Size = New System.Drawing.Size(182, 25)
        Me.PerAdıLbl.TabIndex = 31
        Me.PerAdıLbl.Text = "Adı"
        Me.PerAdıLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PerAdı
        '
        Me.PerAdı.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerAdı.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerAdı.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PerAdı.FocusedBaseColor = System.Drawing.Color.Ivory
        Me.PerAdı.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerAdı.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerAdı.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerAdı.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerAdı.Location = New System.Drawing.Point(74, 100)
        Me.PerAdı.Name = "PerAdı"
        Me.PerAdı.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PerAdı.SelectedText = ""
        Me.PerAdı.Size = New System.Drawing.Size(182, 33)
        Me.PerAdı.TabIndex = 30
        Me.PerAdı.Tag = ""
        '
        'PerGünBtn
        '
        Me.PerGünBtn.ActiveBorderThickness = 1
        Me.PerGünBtn.ActiveCornerRadius = 20
        Me.PerGünBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerGünBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.PerGünBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerGünBtn.BackColor = System.Drawing.Color.Ivory
        Me.PerGünBtn.BackgroundImage = CType(resources.GetObject("PerGünBtn.BackgroundImage"), System.Drawing.Image)
        Me.PerGünBtn.ButtonText = "Güncelle"
        Me.PerGünBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PerGünBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerGünBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerGünBtn.IdleBorderThickness = 1
        Me.PerGünBtn.IdleCornerRadius = 20
        Me.PerGünBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerGünBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerGünBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerGünBtn.Location = New System.Drawing.Point(923, 150)
        Me.PerGünBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.PerGünBtn.Name = "PerGünBtn"
        Me.PerGünBtn.Size = New System.Drawing.Size(85, 48)
        Me.PerGünBtn.TabIndex = 28
        Me.PerGünBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerSilBtn
        '
        Me.PerSilBtn.ActiveBorderThickness = 1
        Me.PerSilBtn.ActiveCornerRadius = 20
        Me.PerSilBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSilBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.PerSilBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerSilBtn.BackColor = System.Drawing.Color.Ivory
        Me.PerSilBtn.BackgroundImage = CType(resources.GetObject("PerSilBtn.BackgroundImage"), System.Drawing.Image)
        Me.PerSilBtn.ButtonText = "Sil"
        Me.PerSilBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PerSilBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerSilBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSilBtn.IdleBorderThickness = 1
        Me.PerSilBtn.IdleCornerRadius = 20
        Me.PerSilBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerSilBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSilBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerSilBtn.Location = New System.Drawing.Point(793, 150)
        Me.PerSilBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.PerSilBtn.Name = "PerSilBtn"
        Me.PerSilBtn.Size = New System.Drawing.Size(85, 48)
        Me.PerSilBtn.TabIndex = 27
        Me.PerSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerEkleBtn
        '
        Me.PerEkleBtn.ActiveBorderThickness = 1
        Me.PerEkleBtn.ActiveCornerRadius = 20
        Me.PerEkleBtn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEkleBtn.ActiveForecolor = System.Drawing.Color.Ivory
        Me.PerEkleBtn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerEkleBtn.BackColor = System.Drawing.Color.Ivory
        Me.PerEkleBtn.BackgroundImage = CType(resources.GetObject("PerEkleBtn.BackgroundImage"), System.Drawing.Image)
        Me.PerEkleBtn.ButtonText = "Ekle"
        Me.PerEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PerEkleBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.PerEkleBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEkleBtn.IdleBorderThickness = 1
        Me.PerEkleBtn.IdleCornerRadius = 20
        Me.PerEkleBtn.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PerEkleBtn.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEkleBtn.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.PerEkleBtn.Location = New System.Drawing.Point(656, 150)
        Me.PerEkleBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.PerEkleBtn.Name = "PerEkleBtn"
        Me.PerEkleBtn.Size = New System.Drawing.Size(85, 48)
        Me.PerEkleBtn.TabIndex = 26
        Me.PerEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BunifuCustomLabel1.Text = "Personeller"
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
        Me.BunifuElipse1.TargetControl = Me.personeldata
        '
        'PersonelForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1615, 777)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PersonelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PersonelForm"
        Me.Panel1.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.personeldata, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PerEkleBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PerSilBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PerGünBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoyadiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PozisyonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EPostaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonelTabloBindingSource As BindingSource
    Friend WithEvents PersonelTabloBindingSource1 As BindingSource
    Friend WithEvents PerAdı As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PerAdıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PerEPosta As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PerTel As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PerSoyadı As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PerPoz As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PerEpostaLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PerTelLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PerPozisyonLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PerSoyadıLbl As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents AdıDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoyadıDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BtnTemizle As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents personeldata As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnFilter As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents SoldBtn As FontAwesome.Sharp.IconButton
End Class
