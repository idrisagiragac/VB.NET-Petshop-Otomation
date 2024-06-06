Imports System.Data.SqlClient
Public Class PetsForm
    Dim connStr As String = "Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True"
    Private Sub PetsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetsData()
        FormDragHelper.AttachDragHandlers(Me)
    End Sub
    Private Sub LoadPetsData()
        Dim dtTür As New DataTable()
        Dim dtCins As New DataTable()

        Dim dt As New DataTable()
        ' Bağlantıyı oluştur
        Using conn As New SqlConnection(connStr), conn2 As New SqlConnection(connStr)
            ' SQL sorgusu
            Dim query As String = "SELECT HayvanSatisTablo.HayvanSatisID, HayvanTür.Adı AS [Tür], HayvanCins.Adı AS [Cins], HayvanSatisTablo.Yaş, HayvanSatisTablo.Maliyet, HayvanSatisTablo.Fiyat, HayvanSatisTablo.Cinsiyet,HayvanSatisTablo.StokSayısı, HayvanSatisTablo.Açıklama, HayvanSatisTablo.CinsID, HayvanSatisTablo.TürID FROM HayvanSatisTablo INNER JOIN HayvanTür ON HayvanSatisTablo.TürID = HayvanTür.TürID INNER JOIN HayvanCins ON HayvanSatisTablo.CinsID = HayvanCins.CinsID"
            ' Komut oluştur ve bağlantıyı aç
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                ' Veri adaptörü oluştur ve verileri DataTable'a doldur
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using

            ' Tür ve Cins için verileri yükle
            Dim queryTür As String = "SELECT TürID, Adı FROM HayvanTür ORDER BY Adı"
            Using cmdTür As New SqlCommand(queryTür, conn2)
                conn2.Open()
                ' Veri adaptörü oluştur ve verileri DataTable'a doldur
                Dim adapterTür As New SqlDataAdapter(cmdTür)
                adapterTür.Fill(dtTür)
            End Using

            Dim queryCins As String = "SELECT CinsID, Adı FROM HayvanCins ORDER BY Adı"
            Using cmdCins As New SqlCommand(queryCins, conn)
                ' Veri adaptörü oluştur ve verileri DataTable'a doldur
                Dim adapterCins As New SqlDataAdapter(cmdCins)
                adapterCins.Fill(dtCins)
            End Using
        End Using

        ' DataGridView'e veri kaynağını ata
        hayvanlardata.DataSource = dt

        ' ComboBox'ları doldur
        With cbHayvanTür
            .DataSource = dtTür
            .DisplayMember = "Adı"
            .ValueMember = "TürID"
            .SelectedIndex = -1
        End With

        With cbHayCins
            .DataSource = dtCins
            .DisplayMember = "Adı"
            .ValueMember = "CinsID"
            .SelectedIndex = -1
        End With
        hayvanlardata.Columns("CinsID").Visible = False
        hayvanlardata.Columns("TürID").Visible = False
    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim Form2Form As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ProductBtn_Click(sender As Object, e As EventArgs) Handles ProductBtn.Click
        Dim ProductForm As New ProductForm()
        ProductForm.Show()
        Me.Hide()
    End Sub
    Private Sub PetsBtn_Click(sender As Object, e As EventArgs) Handles PetsBtn.Click

    End Sub
    Private Sub CustomerBtn_Click(sender As Object, e As EventArgs) Handles CustomerBtn.Click
        Dim CustomerForm As New CustomersForm()
        CustomerForm.Show()
        Me.Hide()
    End Sub
    Private Sub PersonelBtn_Click(sender As Object, e As EventArgs) Handles PersonelBtn.Click
        Dim PersonelForm As New PersonelForm()
        PersonelForm.Show()
        Me.Hide()
    End Sub
    Private Sub SupplierBtn_Click(sender As Object, e As EventArgs) Handles SupplierBtn.Click
        Dim SuppliersForm As New SuppliersForm()
        SuppliersForm.Show()
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
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMin_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub hayvanlardata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles hayvanlardata.CellClick
        Try
            Dim index As Integer = e.RowIndex
            If index >= 0 Then ' Geçerli satır indeksi kontrolü
                Dim selectedRow As DataGridViewRow = hayvanlardata.Rows(index)

                ' Hayvan Türü ve Cinsi ComboBox'larını, DataGridView'den alınan ID değerlerine göre ayarla
                Dim türID As Integer = Convert.ToInt32(selectedRow.Cells("TürID").Value)
                Dim cinsID As Integer = Convert.ToInt32(selectedRow.Cells("CinsID").Value)

                ' ComboBox'ları, seçilen satırdaki değerlere göre ayarla
                cbHayvanTür.SelectedValue = türID
                cbHayCins.SelectedValue = cinsID

                ' Diğer alanları doldur
                HayYas.Text = selectedRow.Cells("Yaş").Value.ToString()
                HayMal.Text = selectedRow.Cells("Maliyet").Value.ToString()
                HayFiy.Text = selectedRow.Cells("Fiyat").Value.ToString()
                HayCinsi.Text = selectedRow.Cells("Cinsiyet").Value.ToString()
                hayvanstok.Text = selectedRow.Cells("StokSayısı").Value.ToString()
                HayAcikl.Text = selectedRow.Cells("Açıklama").Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub
    Private Sub HayvanEkleBtn_Click(sender As Object, e As EventArgs) Handles HayvanEkleBtn.Click
        Try
            ' Alanların doluluk kontrolü
            If cbHayvanTür.SelectedIndex = -1 OrElse
           cbHayCins.SelectedIndex = -1 OrElse
           String.IsNullOrEmpty(HayYas.Text) OrElse
           String.IsNullOrEmpty(HayMal.Text) OrElse
           String.IsNullOrEmpty(HayFiy.Text) OrElse
           String.IsNullOrEmpty(HayCinsi.Text) OrElse
           String.IsNullOrEmpty(hayvanstok.Text) OrElse
           String.IsNullOrEmpty(HayAcikl.Text) Then
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Hayvan bilgilerini al
            Dim yaş As Integer = Convert.ToInt32(HayYas.Text)
            Dim maliyet As Decimal = Convert.ToDecimal(HayMal.Text)
            Dim fiyat As Decimal = Convert.ToDecimal(HayFiy.Text)
            Dim cinsiyet As String = HayCinsi.Text
            Dim aciklama As String = HayAcikl.Text
            Dim stok As String = hayvanstok.Text

            ' TürID ve CinsID değerlerini ComboBox'tan al
            Dim turId As Integer = Convert.ToInt32(cbHayvanTür.SelectedValue)
            Dim cinsId As Integer = Convert.ToInt32(cbHayCins.SelectedValue)

            ' Bağlantıyı oluştur
            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' Ürünü HayvanSatisTablo tablosuna ekle
                Using urunCmd As New SqlCommand("INSERT INTO HayvanSatisTablo (TürID, CinsID, Yaş, Fiyat, Maliyet, Cinsiyet,StokSayısı, Açıklama) VALUES (@TürID, @CinsID, @Yaş, @Fiyat, @Maliyet, @Cinsiyet,@StokSayısı, @Açıklama);", connection)
                    urunCmd.Parameters.AddWithValue("@TürID", turId)
                    urunCmd.Parameters.AddWithValue("@CinsID", cinsId)
                    urunCmd.Parameters.AddWithValue("@Yaş", yaş)
                    urunCmd.Parameters.AddWithValue("@Fiyat", fiyat)
                    urunCmd.Parameters.AddWithValue("@Maliyet", maliyet)
                    urunCmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet)
                    urunCmd.Parameters.AddWithValue("@StokSayısı", stok)
                    urunCmd.Parameters.AddWithValue("@Açıklama", aciklama)
                    urunCmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Hayvan başarıyla eklendi.")

            ' Verileri yeniden yükle
            LoadPetsData()

            ' ComboBox ve TextBox'ları temizle
            cbHayvanTür.SelectedIndex = -1
            cbHayCins.SelectedIndex = -1
            HayYas.Text = ""
            HayMal.Text = ""
            HayFiy.Text = ""
            HayCinsi.Text = ""
            hayvanstok.Text = ""
            HayAcikl.Text = ""
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub
    Private Sub HayvanSilBtn_Click(sender As Object, e As EventArgs) Handles HayvanSilBtn.Click
        Try
            Dim selectedRowIndex As Integer = hayvanlardata.SelectedCells(0).RowIndex
            Dim selectedRow As DataGridViewRow = hayvanlardata.Rows(selectedRowIndex)
            Dim hayvanID As Integer = Convert.ToInt32(selectedRow.Cells("HayvanSatisID").Value)
            Dim cinsID As Integer = Convert.ToInt32(selectedRow.Cells("CinsID").Value)
            Dim turID As Integer = Convert.ToInt32(selectedRow.Cells("TürID").Value)

            Using connection As New SqlConnection(connStr)
                connection.Open()

                ' İlgili hayvanı HayvanSatisTablo'dan sil
                Using silHayvanSatisCmd As New SqlCommand("DELETE FROM HayvanSatisTablo WHERE HayvanSatisID = @HayvanSatisID", connection)
                    silHayvanSatisCmd.Parameters.AddWithValue("@HayvanSatisID", hayvanID)
                    silHayvanSatisCmd.ExecuteNonQuery()
                End Using

                ' Cins kontrolü ve silme işlemi
                Dim cinsReferansSayisi As Integer
                Using cmd As New SqlCommand("SELECT COUNT(*) FROM HayvanSatisTablo WHERE CinsID = @CinsID", connection)
                    cmd.Parameters.AddWithValue("@CinsID", cinsID)
                    cinsReferansSayisi = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If cinsReferansSayisi = 0 Then
                    Using silCinsCmd As New SqlCommand("DELETE FROM HayvanCins WHERE CinsID = @CinsID", connection)
                        silCinsCmd.Parameters.AddWithValue("@CinsID", cinsID)
                        silCinsCmd.ExecuteNonQuery()
                    End Using
                End If

                ' Tür kontrolü ve silme işlemi
                Dim turReferansSayisi As Integer
                Using cmd As New SqlCommand("SELECT COUNT(*) FROM HayvanSatisTablo WHERE TürID = @TürID", connection)
                    cmd.Parameters.AddWithValue("@TürID", turID)
                    turReferansSayisi = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                If turReferansSayisi = 0 Then
                    Using silTurCmd As New SqlCommand("DELETE FROM HayvanTür WHERE TürID = @TürID", connection)
                        silTurCmd.Parameters.AddWithValue("@TürID", turID)
                        silTurCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using

            MessageBox.Show("Hayvan başarıyla silindi.")
            LoadPetsData() ' DataGridView'i güncelleme metodu
            ' ComboBox ve TextBox'ları temizle
            cbHayvanTür.SelectedIndex = -1
            cbHayCins.SelectedIndex = -1
            HayYas.Text = ""
            HayMal.Text = ""
            HayFiy.Text = ""
            HayCinsi.Text = ""
            hayvanstok.Text = ""
            HayAcikl.Text = ""
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub
    Private Sub HayvanGünBtn_Click(sender As Object, e As EventArgs) Handles HayvanGünBtn.Click
        Try
            ' ComboBox ve TextBox alanlarının doluluk kontrolü
            If cbHayvanTür.SelectedIndex = -1 OrElse
           cbHayCins.SelectedIndex = -1 OrElse
           String.IsNullOrEmpty(HayYas.Text) OrElse
           String.IsNullOrEmpty(HayMal.Text) OrElse
           String.IsNullOrEmpty(HayFiy.Text) OrElse
           String.IsNullOrEmpty(HayCinsi.Text) OrElse
           String.IsNullOrEmpty(hayvanstok.Text) OrElse
           String.IsNullOrEmpty(HayAcikl.Text) Then
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Seçilen satırın HayvanSatisID'sini al
            If hayvanlardata.SelectedRows.Count > 0 Then
                Dim hayvansatisId As Integer = Convert.ToInt32(hayvanlardata.SelectedRows(0).Cells("HayvanSatisID").Value)

                ' TürID ve CinsID değerlerini ComboBox'tan al
                Dim turId As Integer = Convert.ToInt32(cbHayvanTür.SelectedValue)
                Dim cinsId As Integer = Convert.ToInt32(cbHayCins.SelectedValue)

                ' Değerleri al ve dönüştür
                Dim yas As Decimal = Convert.ToDecimal(HayYas.Text)
                Dim maliyet As Decimal = Convert.ToDecimal(HayMal.Text)
                Dim fiyat As Decimal = Convert.ToDecimal(HayFiy.Text)
                Dim cinsiyet As String = HayCinsi.Text
                Dim stok As String = hayvanstok.Text
                Dim aciklama As String = HayAcikl.Text

                ' Veritabanı bağlantısı oluştur
                Using connection As New SqlConnection(connStr)
                    connection.Open()

                    ' Hayvan satışını güncelle
                    Using urunCmd As New SqlCommand("UPDATE HayvanSatisTablo SET Yaş = @Yaş, Maliyet = @Maliyet, Fiyat = @Fiyat, Cinsiyet = @Cinsiyet, StokSayısı =@StokSayısı, Açıklama = @Açıklama, TürID = @TürID, CinsID = @CinsID WHERE HayvanSatisID = @HayvanSatisID;", connection)
                        urunCmd.Parameters.AddWithValue("@Yaş", yas)
                        urunCmd.Parameters.AddWithValue("@Maliyet", maliyet)
                        urunCmd.Parameters.AddWithValue("@Fiyat", fiyat)
                        urunCmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet)
                        urunCmd.Parameters.AddWithValue("@StokSayısı", stok)
                        urunCmd.Parameters.AddWithValue("@Açıklama", aciklama)
                        urunCmd.Parameters.AddWithValue("@TürID", turId)
                        urunCmd.Parameters.AddWithValue("@CinsID", cinsId)
                        urunCmd.Parameters.AddWithValue("@HayvanSatisID", hayvansatisId)
                        urunCmd.ExecuteNonQuery()
                    End Using

                    ' Başarıyla güncellendi mesajı göster
                    MessageBox.Show("Hayvan başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Verileri yeniden yükle
                    LoadPetsData()

                    ' ComboBox ve TextBox'ları temizle
                    cbHayvanTür.SelectedIndex = -1
                    cbHayCins.SelectedIndex = -1
                    HayYas.Text = ""
                    HayMal.Text = ""
                    HayFiy.Text = ""
                    HayCinsi.Text = ""
                    hayvanstok.Text = ""
                    HayAcikl.Text = ""
                End Using
            Else
                MessageBox.Show("Lütfen güncellenecek bir hayvan satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ' Hata durumunda hata mesajı göster
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BtnTemizle_Click(sender As Object, e As EventArgs) Handles BtnTemizle.Click
        cbHayvanTür.SelectedIndex = -1
        cbHayCins.SelectedIndex = -1
        HayYas.Text = ""
        HayMal.Text = ""
        HayFiy.Text = ""
        HayCinsi.Text = ""
        HayAcikl.Text = ""
        txtMinYas.Text = ""
        txtMaxYas.Text = ""
        hayvanstok.Text = ""
        LoadPetsData()
    End Sub
    Private Sub RefreshPetsData()
        Dim query As String = "SELECT HayvanSatisTablo.HayvanSatisID, HayvanTür.Adı AS [Tür], HayvanCins.Adı AS [Cins], HayvanSatisTablo.Yaş, HayvanSatisTablo.Maliyet, HayvanSatisTablo.Fiyat, HayvanSatisTablo.Cinsiyet,HayvanSatisTablo.StokSayısı, HayvanSatisTablo.Açıklama, HayvanSatisTablo.CinsID, HayvanSatisTablo.TürID FROM HayvanSatisTablo INNER JOIN HayvanTür ON HayvanSatisTablo.TürID = HayvanTür.TürID INNER JOIN HayvanCins ON HayvanSatisTablo.CinsID = HayvanCins.CinsID WHERE 1=1"

        If cbHayvanTür.SelectedIndex > -1 Then
            query += " AND HayvanTür.TürID = " + cbHayvanTür.SelectedValue.ToString()
        End If

        If cbHayCins.SelectedIndex > -1 Then
            query += " AND HayvanCins.CinsID = " + cbHayCins.SelectedValue.ToString()
        End If

        If Not String.IsNullOrWhiteSpace(txtMinYas.Text) AndAlso Not String.IsNullOrWhiteSpace(txtMaxYas.Text) Then
            query += " AND HayvanSatisTablo.Yaş BETWEEN " + txtMinYas.Text + " AND " + txtMaxYas.Text
        End If

        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    hayvanlardata.DataSource = dt
                End Using
            End Using
        End Using
    End Sub
    Private Sub btnFiltrele_Click(sender As Object, e As EventArgs) Handles btnFiltrele.Click
        ' Filtreleme metodunu çağır
        RefreshPetsData()
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
    Private Sub cbHayvanTür_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbHayvanTür.SelectedIndexChanged
        If cbHayvanTür.SelectedIndex <> -1 AndAlso TypeOf cbHayvanTür.SelectedValue Is Integer Then
            LoadCinsData(Convert.ToInt32(cbHayvanTür.SelectedValue))
        Else
            cbHayCins.DataSource = Nothing  ' 
        End If
    End Sub

    ' Verilen TürID'ye göre cins bilgilerini yükleyen metod, INNER JOIN ile
    Private Sub LoadCinsData(türID As Integer)
        Using conn As New SqlConnection(connStr)
            ' INNER JOIN ile HayvanSatisTablo ve HayvanCins tablolarını ilişkilendirerek cinsleri çekiyoruz
            Dim query As String = "SELECT DISTINCT HC.CinsID, HC.Adı FROM HayvanCins HC " &
                                  "INNER JOIN HayvanSatisTablo HST ON HC.CinsID = HST.CinsID " &
                                  "WHERE HST.TürID = @TürID ORDER BY HC.Adı"
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TürID", türID)
                conn.Open()
                Dim dtCins As New DataTable()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dtCins)

                cbHayCins.DataSource = dtCins
                cbHayCins.DisplayMember = "Adı"
                cbHayCins.ValueMember = "CinsID"
                cbHayCins.SelectedIndex = -1  ' Başlangıçta hiçbir şey seçilmemiş olacak
            End Using
        End Using
    End Sub
End Class