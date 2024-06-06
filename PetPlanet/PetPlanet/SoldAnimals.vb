Imports System.Data.SqlClient
Public Class SoldAnimals
    Dim connStr As String = "Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True"

    Private Sub SoldAnimals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSoldAnimalsData()
    End Sub
    Private Sub LoadSoldAnimalsData()
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            Dim query As String = "SELECT HayvanID, HayvanAdı AS [Hayvan Adı], SahibinAdı AS [Sahibin Adı], " &
                              "Cinsiyet, Tür, Cins, Yaş, SonAşıTarihi AS [Son Aşı Tarihi], " &
                              "AlerjiDurumu AS [Alerji Durumu], KısırlaştırmaDurumu AS [Kısırlaştırma Durumu], " &
                              "Açıklama " &
                              "FROM SatılanHayvanlar"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        soldananimalsdata.DataSource = dt
        CheckVaccinationExpiration()
    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub ProductBtn_Click(sender As Object, e As EventArgs) Handles ProductBtn.Click
        Dim ProductForm As New ProductForm()
        ProductForm.Show()
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
    Private Sub PetsBtn_Click(sender As Object, e As EventArgs) Handles PetsBtn.Click
        Dim PetsForm As New PetsForm()
        PetsForm.Show()
        Me.Hide()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMin_Click_1(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub soldananimalsdata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles soldananimalsdata.CellClick
        Try
            Dim index As Integer = e.RowIndex
            If index >= 0 Then ' Geçerli satır indeksi kontrolü
                Dim selectedRow As DataGridViewRow = soldananimalsdata.Rows(index)

                ' Hayvan bilgilerini form kontrollerine doldur
                HayvanAdıSt.Text = selectedRow.Cells("Hayvan Adı").Value.ToString()
                sahibadıtxt.Text = selectedRow.Cells("Sahibin Adı").Value.ToString()
                hayvancinsiyettxt.Text = selectedRow.Cells("Cinsiyet").Value.ToString()
                HayvanTurTtx.Text = selectedRow.Cells("Tür").Value.ToString()
                hayvancintxt.Text = selectedRow.Cells("Cins").Value.ToString()
                hayvanyastxt.Text = selectedRow.Cells("Yaş").Value.ToString()
                alerjitxt.Text = selectedRow.Cells("Alerji Durumu").Value.ToString()
                ksırılastırmatxt.Text = selectedRow.Cells("Kısırlaştırma Durumu").Value.ToString()
                satisacıklamatxt.Text = selectedRow.Cells("Açıklama").Value.ToString()
                Dim sonKullanmaTarihi As Date
                If Date.TryParse(selectedRow.Cells("Son Aşı Tarihi").Value.ToString(), sonKullanmaTarihi) Then
                    sonasitarihi.Value = sonKullanmaTarihi ' DateTimePicker kontrolü
                Else
                    sonasitarihi.Value = DateTime.Now ' Eğer geçerli bir tarih yoksa, güncel tarihi ata
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message)
        End Try
    End Sub
    Private Sub SatılanHayvanEkleBtn_Click(sender As Object, e As EventArgs) Handles SatılanHayvanEkleBtn.Click
        Using conn As New SqlConnection(connStr)
            ' SQL INSERT sorgusu
            Dim query As String = "INSERT INTO SatılanHayvanlar (HayvanAdı, SahibinAdı, Cinsiyet, Tür, Cins, Yaş, SonAşıTarihi, AlerjiDurumu, KısırlaştırmaDurumu, Açıklama) " &
                              "VALUES (@HayvanAdı, @SahibinAdı, @Cinsiyet, @Tür, @Cins, @Yaş, @SonAşıTarihi, @AlerjiDurumu, @KısırlaştırmaDurumu, @Açıklama)"

            Using cmd As New SqlCommand(query, conn)
                ' Parametreleri ekleyin
                cmd.Parameters.AddWithValue("@HayvanAdı", HayvanAdıSt.Text)
                cmd.Parameters.AddWithValue("@SahibinAdı", sahibadıtxt.Text)
                cmd.Parameters.AddWithValue("@Cinsiyet", hayvancinsiyettxt.Text)
                cmd.Parameters.AddWithValue("@Tür", HayvanTurTtx.Text)
                cmd.Parameters.AddWithValue("@Cins", hayvancintxt.Text)
                cmd.Parameters.AddWithValue("@Yaş", Convert.ToInt32(hayvanyastxt.Text))
                cmd.Parameters.AddWithValue("@SonAşıTarihi", sonasitarihi.Value)
                cmd.Parameters.AddWithValue("@AlerjiDurumu", alerjitxt.Text)
                cmd.Parameters.AddWithValue("@KısırlaştırmaDurumu", ksırılastırmatxt.Text)
                cmd.Parameters.AddWithValue("@Açıklama", satisacıklamatxt.Text)

                ' Veritabanı bağlantısını aç
                conn.Open()

                ' SQL komutunu çalıştır
                cmd.ExecuteNonQuery()

                ' İşlem tamamlandı mesajı
                MessageBox.Show("Hayvan başarıyla kaydedildi.")
            End Using
        End Using
        ClearFormControls()
        ' Veri listesini yenile
        LoadSoldAnimalsData()
    End Sub
    Private Sub SatılanHayvanSilBtn_Click(sender As Object, e As EventArgs) Handles SatılanHayvanSilBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If soldananimalsdata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen silmek için bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan ID bilgisini al
        Dim selectedID As Integer = Convert.ToInt32(soldananimalsdata.SelectedRows(0).Cells("HayvanID").Value)

        ' Veritabanından hayvanı silmek için SQL sorgusu
        Dim sql As String = "DELETE FROM SatılanHayvanlar WHERE HayvanID = @HayvanID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Using conn As New SqlConnection(connStr),
          cmd As New SqlCommand(sql, conn)

            ' Parametreleri ekle
            cmd.Parameters.AddWithValue("@HayvanID", selectedID)

            Try
                ' Bağlantıyı aç
                conn.Open()

                ' Komutu çalıştır
                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Hayvan başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Silme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                ClearFormControls()
                ' DataGridView'i güncelle
                LoadSoldAnimalsData()

            Catch ex As Exception
                MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                ' Bağlantıyı kapat
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub
    Private Sub SatılanHayvanGunBtn_Click(sender As Object, e As EventArgs) Handles SatılanHayvanGunBtn.Click
        ' Metin kutuları kontrolü
        If String.IsNullOrWhiteSpace(HayvanAdıSt.Text) OrElse String.IsNullOrWhiteSpace(sahibadıtxt.Text) OrElse
           String.IsNullOrWhiteSpace(hayvancinsiyettxt.Text) OrElse String.IsNullOrWhiteSpace(HayvanTurTtx.Text) OrElse
           String.IsNullOrWhiteSpace(hayvancintxt.Text) OrElse String.IsNullOrWhiteSpace(hayvanyastxt.Text) OrElse
           String.IsNullOrWhiteSpace(alerjitxt.Text) OrElse String.IsNullOrWhiteSpace(ksırılastırmatxt.Text) OrElse
           String.IsNullOrWhiteSpace(satisacıklamatxt.Text) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırın doğruluğunu kontrol et
        If soldananimalsdata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen güncellemek için bir hayvan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan ID bilgisini al
        Dim selectedID As Integer = Convert.ToInt32(soldananimalsdata.SelectedRows(0).Cells("HayvanID").Value)

        ' Veritabanında hayvanı güncellemek için SQL sorgusu
        Dim sql As String = "UPDATE SatılanHayvanlar SET HayvanAdı = @HayvanAdı, SahibinAdı = @SahibinAdı, Cinsiyet = @Cinsiyet, Tür = @Tür, " &
                            "Cins = @Cins, Yaş = @Yaş, SonAşıTarihi = @SonAşıTarihi, AlerjiDurumu = @AlerjiDurumu, " &
                            "KısırlaştırmaDurumu = @KısırlaştırmaDurumu, Açıklama = @Açıklama WHERE HayvanID = @HayvanID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Using conn As New SqlConnection(connStr),
              cmd As New SqlCommand(sql, conn)

            ' Parametreleri ekle
            cmd.Parameters.AddWithValue("@HayvanAdı", HayvanAdıSt.Text)
            cmd.Parameters.AddWithValue("@SahibinAdı", sahibadıtxt.Text)
            cmd.Parameters.AddWithValue("@Cinsiyet", hayvancinsiyettxt.Text)
            cmd.Parameters.AddWithValue("@Tür", HayvanTurTtx.Text)
            cmd.Parameters.AddWithValue("@Cins", hayvancintxt.Text)
            cmd.Parameters.AddWithValue("@Yaş", Convert.ToInt32(hayvanyastxt.Text))
            cmd.Parameters.AddWithValue("@SonAşıTarihi", sonasitarihi.Value)
            cmd.Parameters.AddWithValue("@AlerjiDurumu", alerjitxt.Text)
            cmd.Parameters.AddWithValue("@KısırlaştırmaDurumu", ksırılastırmatxt.Text)
            cmd.Parameters.AddWithValue("@Açıklama", satisacıklamatxt.Text)
            cmd.Parameters.AddWithValue("@HayvanID", selectedID)

            Try
                ' Bağlantıyı aç
                conn.Open()

                ' Komutu çalıştır
                Dim result As Integer = cmd.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Hayvan bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Güncelleme işlemi başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ClearFormControls()
                ' DataGridView'i güncelle
                LoadSoldAnimalsData()

            Catch ex As Exception
                MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                ' Bağlantıyı kapat
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub
    Private Sub BtnTemizlee_Click(sender As Object, e As EventArgs) Handles BtnTemizlee.Click
        ClearFormControls()
        LoadSoldAnimalsData()
    End Sub
    Private Sub ClearFormControls()
        ' TextBox'ları temizle
        HayvanAdıSt.Text = ""
        sahibadıtxt.Text = ""
        hayvancinsiyettxt.Text = ""
        HayvanTurTtx.Text = ""
        hayvancintxt.Text = ""
        hayvanyastxt.Text = ""
        alerjitxt.Text = ""
        satisacıklamatxt.Text = ""
        ksırılastırmatxt.Text = ""
        sonasitarihi.Value = DateTime.Now
    End Sub
    Private Sub btnFilterr_Click(sender As Object, e As EventArgs) Handles btnFilterr.Click
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            ' Filtreleme için parametreli SQL sorgusu
            Dim query As String = "SELECT HayvanID, HayvanAdı AS [Hayvan Adı], SahibinAdı AS [Sahibin Adı], " &
                                  "Cinsiyet, Tür, Cins, Yaş, SonAşıTarihi AS [Son Aşı Tarihi], " &
                                  "AlerjiDurumu AS [Alerji Durumu], KısırlaştırmaDurumu AS [Kısırlaştırma Durumu], " &
                                  "Açıklama FROM SatılanHayvanlar " &
                                  "WHERE HayvanAdı LIKE @HayvanAdı AND SahibinAdı LIKE @SahibinAdı"

            Using cmd As New SqlCommand(query, conn)
                ' TextBox'lardan alınan değerler ile parametreleri ekle
                cmd.Parameters.AddWithValue("@HayvanAdı", "%" & HayvanAdıSt.Text.Trim() & "%")
                cmd.Parameters.AddWithValue("@SahibinAdı", "%" & sahibadıtxt.Text.Trim() & "%")

                ' Veritabanı bağlantısını aç
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using

        ' DataGridView'in kaynak verisini filtrelenmiş veri tablosu ile güncelle
        soldananimalsdata.DataSource = dt

        ' Eğer sonuç dönmüyorsa uyarı ver
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Aranan kriterlere uygun hayvan bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub CheckVaccinationExpiration()
        Dim expiredVaccinations As New List(Of String)
        Using conn As New SqlConnection(connStr)
            ' Son aşı tarihi 3 yıldan eski olan hayvanları sorgulayalım
            Dim query As String = "SELECT HayvanID, HayvanAdı FROM SatılanHayvanlar WHERE SonAşıTarihi <= DATEADD(year, -1, GETDATE())"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Listeye ekleyelim
                        expiredVaccinations.Add(String.Format("ID: {0} - {1}", reader("HayvanID").ToString(), reader("HayvanAdı").ToString()))
                    End While
                End Using
            End Using
        End Using

        ' Eğer sonuç varsa uyarı mesajı göster
        If expiredVaccinations.Count > 0 Then
            Dim message As String = "Dikkat! Aşağıdaki hayvanların son aşı tarihleri 1 yıldan daha eski:" & Environment.NewLine & String.Join(Environment.NewLine, expiredVaccinations)
            MessageBox.Show(message, "Aşı Süresi Dolmuş Hayvanlar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class