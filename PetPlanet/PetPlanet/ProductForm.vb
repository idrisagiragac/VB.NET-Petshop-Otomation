Imports System.Data.SqlClient
Public Class ProductForm
    ' Bağlantı dizesi
    Dim connStr As String = "Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True"
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDragHelper.AttachDragHandlers(Me)
        UpdateDataGridView()
        FillComboBoxes()
    End Sub

    Private Sub FillComboBoxes()
        FillTürComboBox()
        FillMarkaComboBox()
    End Sub

    Private Sub FillTürComboBox()
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT TürID, Adı FROM ÜrünTür ORDER BY Adı"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

                cmbTür.DataSource = dt
                cmbTür.DisplayMember = "Adı"
                cmbTür.ValueMember = "TürID"
                cmbTür.SelectedIndex = -1
            End Using
        End Using
    End Sub

    Private Sub FillMarkaComboBox()
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT MarkaID, Adı FROM ÜrünMarka ORDER BY Adı"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbMarka.DataSource = dt
                cmbMarka.DisplayMember = "Adı"
                cmbMarka.ValueMember = "MarkaID"
                cmbMarka.SelectedIndex = -1  ' Başlangıçta hiçbir şey seçilmemiş olacak
            End Using
        End Using
    End Sub

    Private Sub UpdateDataGridView()
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT ÜrünlerTablo.ÜrünID, ÜrünlerTablo.Adı AS [Ürün Adı], ÜrünTür.Adı AS [Tür], " &
                                  "ÜrünMarka.Adı AS [Marka], ÜrünlerTablo.Maliyet, ÜrünlerTablo.Fiyat, " &
                                  "ÜrünlerTablo.Açıklama, ÜrünlerTablo.StokSayısı, ÜrünlerTablo.SonKullanmaTarihi, " &
                                  "ÜrünlerTablo.TürID, ÜrünlerTablo.MarkaID " &
                                  "FROM ÜrünlerTablo " &
                                  "INNER JOIN ÜrünTür ON ÜrünlerTablo.TürID = ÜrünTür.TürID " &
                                  "INNER JOIN ÜrünMarka ON ÜrünlerTablo.MarkaID = ÜrünMarka.MarkaID"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        urunlerdata.DataSource = dt
        ' TextBox'a ÜrünID'nin gelmemesi için ReadOnly özelliğini false olarak ayarla
        PrAdı.ReadOnly = False
        urunlerdata.Columns("MarkaID").Visible = False
        urunlerdata.Columns("TürID").Visible = False
        CheckExpirationDates()
    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ProductBtn_Click(sender As Object, e As EventArgs) Handles ProductBtn.Click

    End Sub
    Private Sub PetsBtn_Click(sender As Object, e As EventArgs) Handles PetsBtn.Click
        Dim PetsForm As New PetsForm()
        PetsForm.Show()
        Me.Hide()
    End Sub
    Private Sub CustomerBtn_Click(sender As Object, e As EventArgs) Handles CustomerBtn.Click
        Dim CustomerBtn As New CustomersForm()
        CustomersForm.Show()
        Me.Hide()
    End Sub
    Private Sub PersonelBtn_Click(sender As Object, e As EventArgs) Handles PersonelBtn.Click
        Dim PersonelForm As New PersonelForm()
        PersonelForm.Show()
        Me.Hide()
    End Sub
    Private Sub SupplierBtn_Click(sender As Object, e As EventArgs) Handles SupplierBtn.Click
        Dim SupplierForm As New SuppliersForm()
        SupplierForm.Show()
        Me.Hide()
    End Sub
    Private Sub SaleBtn_Click(sender As Object, e As EventArgs) Handles SaleBtn.Click
        Dim SaleForm As New SaleForm()
        SaleForm.Show()
        Me.Hide()
    End Sub
    Private Sub SoldBtn_Click(sender As Object, e As EventArgs) Handles SoldBtn.Click
        Dim SoldAnimals As New SoldAnimals()
        SoldAnimals.Show()
        Me.Hide()
    End Sub
    Private Sub btnMin_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub urunlerdata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles urunlerdata.CellClick
        Try
            Dim index As Integer = e.RowIndex
            If index >= 0 Then ' Geçerli satır indeksi kontrolü
                Dim selectedRow As DataGridViewRow = urunlerdata.Rows(index)

                ' Ürün bilgilerini form kontrollerine doldur
                PrAdı.Text = selectedRow.Cells("Ürün Adı").Value.ToString()
                PrMaliyet.Text = selectedRow.Cells("Maliyet").Value.ToString()
                PrFiyat.Text = selectedRow.Cells("Fiyat").Value.ToString()
                PrAciklama.Text = selectedRow.Cells("Açıklama").Value.ToString()
                PrStok.Text = selectedRow.Cells("StokSayısı").Value.ToString()

                ' ComboBox'lar için doğru ID'leri atayarak seçim yap
                cmbTür.SelectedValue = Convert.ToInt32(selectedRow.Cells("TürID").Value)
                cmbMarka.SelectedValue = Convert.ToInt32(selectedRow.Cells("MarkaID").Value)

                ' Son Kullanma Tarihi için güvenli atama
                Dim sonKullanmaTarihi As Date
                If Date.TryParse(selectedRow.Cells("SonKullanmaTarihi").Value.ToString(), sonKullanmaTarihi) Then
                    UrunSonKullanmaTarih.Value = sonKullanmaTarihi
                Else
                    UrunSonKullanmaTarih.Value = DateTime.Now
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Sub UrunEkleBtn_Click(sender As Object, e As EventArgs) Handles UrunEkleBtn.Click
        Try
            ' Alanların doluluk kontrolü
            If String.IsNullOrEmpty(PrAdı.Text) OrElse
           String.IsNullOrEmpty(PrMaliyet.Text) OrElse
           String.IsNullOrEmpty(PrFiyat.Text) OrElse
           String.IsNullOrEmpty(PrAciklama.Text) OrElse
           String.IsNullOrEmpty(PrStok.Text) Then
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Ürün bilgilerini al
            Dim adi As String = PrAdı.Text
            Dim maliyet As Decimal = Convert.ToDecimal(PrMaliyet.Text)
            Dim fiyat As Decimal = Convert.ToDecimal(PrFiyat.Text)
            Dim aciklama As String = PrAciklama.Text
            Dim stokSayisi As Integer = Convert.ToInt32(PrStok.Text)
            Dim sonKullanmaTarihi As Date = UrunSonKullanmaTarih.Value

            ' MarkaID ve TürID değerlerini ComboBox'tan al
            Dim turId As Integer = Convert.ToInt32(cmbTür.SelectedValue)
            Dim markaId As Integer = Convert.ToInt32(cmbMarka.SelectedValue)

            ' Bağlantıyı oluştur
            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' Ürünü Ürünler tablosuna ekle
                Using urunCmd As New SqlCommand("INSERT INTO ÜrünlerTablo (Adı, Maliyet, Fiyat, Açıklama, StokSayısı, SonKullanmaTarihi, MarkaID, TürID) VALUES (@Adi, @Maliyet, @Fiyat, @Aciklama, @StokSayisi, @SonKullanmaTarihi, @MarkaID, @TurID);", connection)
                    urunCmd.Parameters.AddWithValue("@Adi", adi)
                    urunCmd.Parameters.AddWithValue("@Maliyet", maliyet)
                    urunCmd.Parameters.AddWithValue("@Fiyat", fiyat)
                    urunCmd.Parameters.AddWithValue("@Aciklama", aciklama)
                    urunCmd.Parameters.AddWithValue("@StokSayisi", stokSayisi)
                    urunCmd.Parameters.AddWithValue("@SonKullanmaTarihi", sonKullanmaTarihi)
                    urunCmd.Parameters.AddWithValue("@MarkaID", markaId)
                    urunCmd.Parameters.AddWithValue("@TurID", turId)
                    urunCmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Ürün başarıyla eklendi.")

            ' Formdaki kontrol değerlerini temizle
            ClearFormControls()

            ' DataGridView'i güncelle
            UpdateDataGridView()
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFormControls()
        ' TextBox'ları temizle
        PrAdı.Text = ""
        PrMaliyet.Text = ""
        PrFiyat.Text = ""
        PrAciklama.Text = ""
        PrStok.Text = ""
        cmbMarka.SelectedIndex = -1
        cmbTür.SelectedIndex = -1
        UrunSonKullanmaTarih.Value = DateTime.Now
    End Sub

    Private Sub UrunGuncelleBtn_Click(sender As Object, e As EventArgs) Handles UrunGuncelleBtn.Click
        Try
            If urunlerdata.SelectedCells.Count = 0 Then
                MessageBox.Show("Lütfen güncellenecek bir ürün seçin.")
                Return
            End If

            Dim seciliSatirIndex As Integer = urunlerdata.SelectedCells(0).RowIndex
            If seciliSatirIndex < 0 Then
                MessageBox.Show("Geçerli bir ürün seçin.")
                Return
            End If

            Dim seciliSatir As DataGridViewRow = urunlerdata.Rows(seciliSatirIndex)
            Dim urunID As Integer = Convert.ToInt32(seciliSatir.Cells("ÜrünID").Value)

            ' Güncellenen ürün detaylarını formdan al
            Dim adi As String = PrAdı.Text
            Dim maliyet As Decimal = Convert.ToDecimal(PrMaliyet.Text)
            Dim fiyat As Decimal = Convert.ToDecimal(PrFiyat.Text)
            Dim aciklama As String = PrAciklama.Text
            Dim stokSayisi As Integer = Convert.ToInt32(PrStok.Text)
            Dim sonKullanmaTarihi As Date = UrunSonKullanmaTarih.Value

            ' ComboBox'tan seçilen Tür ve Marka ID'leri al
            Dim markaID As Integer = Convert.ToInt32(cmbMarka.SelectedValue)
            Dim turID As Integer = Convert.ToInt32(cmbTür.SelectedValue)

            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' Ürün bilgilerini güncelle
                Dim updateQuery As String = "UPDATE ÜrünlerTablo SET Adı = @Adi, Maliyet = @Maliyet, Fiyat = @Fiyat, Açıklama = @Aciklama, StokSayısı = @StokSayisi, SonKullanmaTarihi = @SonKullanmaTarihi, MarkaID = @MarkaID, TürID = @TurID WHERE ÜrünID = @UrunID"
                Using cmd As New SqlCommand(updateQuery, connection)
                    cmd.Parameters.AddWithValue("@Adi", adi)
                    cmd.Parameters.AddWithValue("@Maliyet", maliyet)
                    cmd.Parameters.AddWithValue("@Fiyat", fiyat)
                    cmd.Parameters.AddWithValue("@Aciklama", aciklama)
                    cmd.Parameters.AddWithValue("@StokSayisi", stokSayisi)
                    cmd.Parameters.AddWithValue("@SonKullanmaTarihi", sonKullanmaTarihi)
                    cmd.Parameters.AddWithValue("@MarkaID", markaID)
                    cmd.Parameters.AddWithValue("@TurID", turID)
                    cmd.Parameters.AddWithValue("@UrunID", urunID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Ürün başarıyla güncellendi.")
            UpdateDataGridView() ' Verileri yeniden yükleyin
            ClearFormControls() ' Formdaki kontrol değerlerini temizle
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Sub UrunSilBtn_Click(sender As Object, e As EventArgs) Handles UrunSilBtn.Click
        Try
            Dim selectedRowIndex As Integer = urunlerdata.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = urunlerdata.Rows(selectedRowIndex)
            Dim urunID As Integer = Convert.ToInt32(selectedRow.Cells("ÜrünID").Value)
            Dim markaID As Integer = Convert.ToInt32(selectedRow.Cells("MarkaID").Value) ' Sütun adları veritabanınıza göre ayarlanmalıdır
            Dim turID As Integer = Convert.ToInt32(selectedRow.Cells("TürID").Value)

            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' İlgili ürünü ÜrünlerTablo'dan sil
                Using silUrunCmd As New SqlCommand("DELETE FROM ÜrünlerTablo WHERE ÜrünID = @UrunID", connection)
                    silUrunCmd.Parameters.AddWithValue("@UrunID", urunID)
                    silUrunCmd.ExecuteNonQuery()
                End Using

                ' Marka kontrolü ve silme işlemi
                Dim markaReferansSayisi As Integer
                Using cmd As New SqlCommand("SELECT COUNT(*) FROM ÜrünlerTablo WHERE MarkaID = @MarkaID", connection)
                    cmd.Parameters.AddWithValue("@MarkaID", markaID)
                    markaReferansSayisi = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If markaReferansSayisi = 0 Then
                    Using silMarkaCmd As New SqlCommand("DELETE FROM ÜrünMarka WHERE MarkaID = @MarkaID", connection)
                        silMarkaCmd.Parameters.AddWithValue("@MarkaID", markaID)
                        silMarkaCmd.ExecuteNonQuery()
                    End Using
                End If

                ' Tür kontrolü ve silme işlemi
                Dim turReferansSayisi As Integer
                Using cmd As New SqlCommand("SELECT COUNT(*) FROM ÜrünlerTablo WHERE TürID = @TürID", connection)
                    cmd.Parameters.AddWithValue("@TürID", turID)
                    turReferansSayisi = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If turReferansSayisi = 0 Then
                    Using silTurCmd As New SqlCommand("DELETE FROM ÜrünTür WHERE TürID = @TürID", connection)
                        silTurCmd.Parameters.AddWithValue("@TürID", turID)
                        silTurCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
            MessageBox.Show("Ürün başarıyla silindi.")
            UpdateDataGridView() ' Verileri yeniden yükleme metodu
            ClearFormControls() ' Formdaki kontrol değerlerini temizle
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnTemizle_Click(sender As Object, e As EventArgs) Handles BtnTemizle.Click
        ' Metin kutularını ve diğer kontrolleri temizle
        ClearFormControls()

        ' Tüm ürünleri yükleyerek DataGridView'i güncelle
        UpdateDataGridView()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "SELECT ÜrünlerTablo.ÜrünID, ÜrünlerTablo.Adı AS [Ürün Adı], ÜrünTür.Adı AS [Tür], ÜrünMarka.Adı AS [Marka], ÜrünlerTablo.Fiyat, ÜrünlerTablo.Maliyet, ÜrünlerTablo.Açıklama, ÜrünlerTablo.StokSayısı, ÜrünlerTablo.SonKullanmaTarihi, ÜrünlerTablo.TürID, ÜrünMarka.MarkaID " &
            "FROM ÜrünlerTablo " &
            "INNER JOIN ÜrünTür ON ÜrünlerTablo.TürID = ÜrünTür.TürID " &
            "INNER JOIN ÜrünMarka ON ÜrünlerTablo.MarkaID = ÜrünMarka.MarkaID WHERE 1=1"

            Using command As New SqlCommand(sql, conn)
                ' Ürün adı kontrolü
                If Not String.IsNullOrWhiteSpace(PrAdı.Text) Then
                    sql += " AND ÜrünlerTablo.Adı LIKE '%' + @ProductName + '%'"
                    command.Parameters.AddWithValue("@ProductName", PrAdı.Text)
                End If

                ' Fiyat aralığı kontrolü
                If Not String.IsNullOrWhiteSpace(txtMinPrice.Text) AndAlso Not String.IsNullOrWhiteSpace(txtMaxPrice.Text) Then
                    Dim minPrice As Decimal
                    Dim maxPrice As Decimal
                    If Decimal.TryParse(txtMinPrice.Text, minPrice) AndAlso Decimal.TryParse(txtMaxPrice.Text, maxPrice) Then
                        sql += " AND ÜrünlerTablo.Fiyat BETWEEN @minPrice AND @maxPrice"
                        command.Parameters.AddWithValue("@minPrice", minPrice)
                        command.Parameters.AddWithValue("@maxPrice", maxPrice)
                    End If
                End If

                ' Tür kontrolü
                If cmbTür.SelectedIndex > -1 Then
                    sql += " AND ÜrünTür.TürID = @TürID"
                    command.Parameters.AddWithValue("@TürID", Convert.ToInt32(cmbTür.SelectedValue))
                End If

                ' Marka kontrolü
                If cmbMarka.SelectedIndex > -1 Then
                    sql += " AND ÜrünMarka.MarkaID = @MarkaID"
                    command.Parameters.AddWithValue("@MarkaID", Convert.ToInt32(cmbMarka.SelectedValue))
                End If

                ' SQL komutunun CommandText özelliğini güncelle
                command.CommandText = sql

                ' Veritabanı bağlantısını aç ve veriyi oku
                conn.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)
                    urunlerdata.DataSource = dataTable
                End Using
            End Using
        End Using
    End Sub
    Public Class FormDragHelper
        Private Shared dragging As Boolean = False
        Private Shared dragCursorPoint As Point
        Private Shared dragFormPoint As Point
        Public Shared Sub AttachDragHandlers(form As Form)
            AddHandler form.MouseDown, AddressOf OnMouseDown
            AddHandler form.MouseMove, AddressOf OnMouseMove
            AddHandler form.MouseUp, AddressOf OnMouseUp

            ' Formdaki tüm kontrollere olay işleyicilerini ekleyin
            For Each ctrl As Control In form.Controls
                AddHandler ctrl.MouseDown, AddressOf OnMouseDown
                AddHandler ctrl.MouseMove, AddressOf OnMouseMove
                AddHandler ctrl.MouseUp, AddressOf OnMouseUp
            Next
        End Sub
        Private Shared Sub OnMouseDown(sender As Object, e As MouseEventArgs)
            If e.Button = MouseButtons.Left Then
                dragging = True
                dragCursorPoint = Cursor.Position
                dragFormPoint = CType(sender, Control).FindForm().Location
            End If
        End Sub
        Private Shared Sub OnMouseMove(sender As Object, e As MouseEventArgs)
            If dragging Then
                Dim currentScreenPos = Cursor.Position
                Dim form = CType(sender, Control).FindForm()
                form.Location = New Point(dragFormPoint.X + currentScreenPos.X - dragCursorPoint.X,
                                          dragFormPoint.Y + currentScreenPos.Y - dragCursorPoint.Y)
            End If
        End Sub
        Private Shared Sub OnMouseUp(sender As Object, e As MouseEventArgs)
            dragging = False
        End Sub
    End Class

    Private Sub CheckExpirationDates()
        Dim expiringProducts As New List(Of String)
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT ÜrünID, Adı FROM ÜrünlerTablo WHERE SonKullanmaTarihi <= DATEADD(month, 3, GETDATE())"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        expiringProducts.Add(String.Format("ID: {0} - {1}", reader("ÜrünID").ToString(), reader("Adı").ToString()))
                    End While
                End Using
            End Using
        End Using
        If expiringProducts.Count > 0 Then
            Dim message As String = "Dikkat! Aşağıdaki ürünlerin son kullanma tarihi 3 ay içinde doluyor:" & Environment.NewLine & String.Join(Environment.NewLine, expiringProducts)
            MessageBox.Show(message, "Son Kullanma Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
    Private Sub cmbTür_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTür.SelectedIndexChanged
        If cmbTür.SelectedValue IsNot Nothing AndAlso TypeOf cmbTür.SelectedValue Is Integer Then
            LoadMarkaData(Convert.ToInt32(cmbTür.SelectedValue))
        Else
            cmbMarka.DataSource = Nothing  ' Tür seçimi kaldırıldığında ya da geçerli değilse marka listesini temizle
        End If
    End Sub
    '' Verilen TürID'ye göre Marka bilgilerini yükleyen metod
    Private Sub LoadMarkaData(türID As Integer)
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT DISTINCT UM.MarkaID, UM.Adı FROM ÜrünMarka UM " &
                              "INNER JOIN ÜrünlerTablo UT ON UM.MarkaID = UT.MarkaID " &
                              "WHERE UT.TürID = @TürID ORDER BY UM.Adı"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.Add("@TürID", SqlDbType.Int).Value = türID
                conn.Open()
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)

                ' ComboBox için veri kaynağını temizleyip yeniden yüklüyoruz
                cmbMarka.DataSource = Nothing
                cmbMarka.Items.Clear()
                cmbMarka.DataSource = dt
                cmbMarka.DisplayMember = "Adı"
                cmbMarka.ValueMember = "MarkaID"
                cmbMarka.SelectedIndex = -1

            End Using
        End Using
    End Sub
End Class