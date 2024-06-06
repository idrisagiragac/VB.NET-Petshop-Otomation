Imports System.Data.SqlClient
Public Class Form2
    ' Bağlantı dizesi
    Dim connStr As String = "Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPersonellComboBox()
        LoadFaturaData()
        LoadAsiTarihiData()
        FormDragHelper.AttachDragHandlers(Me)
    End Sub
    Private Sub LoadFaturaData()
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            ' FaturaTablosu'ndan gerekli sütunları çeken sorguyu hazırlayın
            Dim query As String = "SELECT PersonelID, ÜrünID, Adet, Tutar FROM ÜrünSepet"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                ' Verileri DataTable'a doldur
                adapter.Fill(dt)
            End Using
        End Using
        ' DataGridView'e verileri yükle
        urunsatdata.DataSource = dt
    End Sub
    Private Sub LoadAsiTarihiData()
        Dim dt As New DataTable()

        ' Son aşı tarihinden bir yıl önceki tarihi hesaplayalım
        Dim oneYearAgo As DateTime = DateTime.Today.AddYears(-1)

        ' Veritabanından verileri almak için sorguyu oluşturalım
        Dim query As String = "SELECT SH.HayvanID, SH.MüşteriID, SH.HayvanAdı, SH.SahibinAdı, SH.SonAşıTarihi " &
                          "FROM SatılanHayvanlar SH " &
                          "JOIN MüşteriTablo MT ON SH.MüşteriID = MT.MüşteriID " &
                          "WHERE SH.SonAşıTarihi < @OneYearAgo"

        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                ' Parametre ekleyerek sorguyu hazırlayalım
                cmd.Parameters.AddWithValue("@OneYearAgo", oneYearAgo)

                ' Verileri adaptöre doldurup DataTable'a aktaralım
                Dim adapter As New SqlDataAdapter(cmd)
                conn.Open()
                adapter.Fill(dt)
            End Using
        End Using

        ' DataGridView'e verileri yükleme
        asitarihidata.DataSource = dt
    End Sub
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click

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
    Private Sub SoldBtn_Click(sender As Object, e As EventArgs) Handles SoldBtn.Click
        Dim SoldAnimals As New SoldAnimals()
        SoldAnimals.Show()
        Me.Hide()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMin_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub AramaButonu_Click(sender As Object, e As EventArgs) Handles AramaButonu.Click
        If String.IsNullOrEmpty(AramaTextBox.Text) Then
            MessageBox.Show("Lütfen bir ürün ID'si giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim arananID As Integer
        If Not Int32.TryParse(AramaTextBox.Text, arananID) Then
            MessageBox.Show("Lütfen geçerli bir sayısal değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Sorguyu stok sayısı bilgisiyle güncelle
        Dim query As String = "SELECT ÜrünID, Adı AS 'Ürün Adı', Fiyat, StokSayısı FROM ÜrünlerTablo WHERE ÜrünID = @UrunID"

        Using conn As New SqlConnection(connStr), cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@UrunID", arananID)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                urunaradata.DataSource = dt
            Else
                MessageBox.Show("Ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                urunaradata.DataSource = Nothing
            End If
        End Using
    End Sub
    Private Sub AramaTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AramaTextBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub urunaradata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles urunaradata.CellDoubleClick
        ' Seçilen satırı al
        Dim selectedRow As DataGridViewRow = urunaradata.Rows(e.RowIndex)

        ' Ürün bilgilerini ve stok sayısını al
        Dim urunID As String = selectedRow.Cells("ÜrünID").Value.ToString()
        Dim fiyat As Decimal = Convert.ToDecimal(selectedRow.Cells("Fiyat").Value)
        Dim stokSayisi As Integer = Convert.ToInt32(selectedRow.Cells("StokSayısı").Value)

        ' Kullanıcıdan ürün adedi için giriş al
        Dim adet As String = InputBox("Ürün Adedi Giriniz:", "Adet", "1")
        Dim adetSayisi As Integer

        ' Girişin geçerli bir sayı olup olmadığını kontrol et ve stok sayısını aşmadığından emin ol
        If Not Int32.TryParse(adet, adetSayisi) Then
            MessageBox.Show("Geçersiz adet girişi. Lütfen bir sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf adetSayisi > stokSayisi Then
            MessageBox.Show("Stokta yeterli ürün bulunmamaktadır. Lütfen stok sayısından az veya eşit bir değer giriniz.", "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' DataTable'a yeni bir satır ekleyin
        Dim dt As DataTable = CType(urunsatdata.DataSource, DataTable)
        Dim newRow As DataRow = dt.NewRow()
        newRow("PersonelID") = ComboBoxPersonelID.SelectedValue
        newRow("ÜrünID") = urunID
        newRow("Adet") = adetSayisi
        newRow("Tutar") = fiyat
        dt.Rows.Add(newRow)
        GuncelleToplamTutar()
    End Sub
    Private Sub FillPersonellComboBox()
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT PersonelID, Adı + ' ' + Soyadı AS AdSoyad FROM PersonelTablo"
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim personeller As New List(Of KeyValuePair(Of String, String))()
                        While reader.Read()
                            Dim id As String = reader("PersonelID").ToString()
                            Dim adSoyad As String = reader("AdSoyad").ToString()
                            ' Burada ID'yi değer, adı ve soyadı ise anahtar olarak ekliyoruz
                            personeller.Add(New KeyValuePair(Of String, String)(id, adSoyad))
                        End While
                        ComboBoxPersonelID.DataSource = personeller
                        ComboBoxPersonelID.DisplayMember = "Value" ' Görünen metni adı ve soyadı olarak ayarla
                        ComboBoxPersonelID.ValueMember = "Key" ' ComboBox değerini ID olarak ayarla
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Personel bilgileri yüklenirken bir hata oluştu: " & ex.Message)
        End Try
    End Sub
    Private Sub ComboBoxPersonelID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPersonelID.SelectedIndexChanged
        If ComboBoxPersonelID.SelectedItem IsNot Nothing Then
            ' Seçilen öğeyi KeyValuePair olarak alıp, personelin adını ve soyadını TextBox'a yazdır
            Dim selectedPair As KeyValuePair(Of String, String) = DirectCast(ComboBoxPersonelID.SelectedItem, KeyValuePair(Of String, String))
            txtperadısoyad.Text = selectedPair.Key ' Adı ve soyadı TextBox'a yazdır
        End If
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

    Private Sub GuncelleToplamTutar()
        Dim toplamTutar As Decimal = 0

        ' DataGridView'deki her satır için 'Fiyat' ve 'Adet' sütunlarının değerlerini çarp ve topla
        For Each row As DataGridViewRow In urunsatdata.Rows
            If Not row.IsNewRow Then ' Eğer yeni bir satır ise bu kontrolü atla
                Dim tutar As Decimal = Convert.ToDecimal(row.Cells("Tutar").Value)
                Dim adet As Integer = Convert.ToInt32(row.Cells("Adet").Value)
                toplamTutar += tutar * adet
            End If
        Next

        ' Toplam tutarı Label'da göster
        lblToplamTutar.Text = "Toplam Tutar: " & toplamTutar.ToString("C2")  ' C2, para birimi formatında gösterir
    End Sub

    Private Sub MüsteriAramaButonu_Click(sender As Object, e As EventArgs) Handles MüsteriAramaButonu.Click
        ' Müşteri ID'sini kontrol edin
        If String.IsNullOrEmpty(MusteriAraText.Text) Then
            MessageBox.Show("Lütfen bir müşteri ID'si giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Müşteri ID'sini tamsayıya dönüştürün
        Dim musteriID As Integer
        If Not Integer.TryParse(MusteriAraText.Text, musteriID) Then
            MessageBox.Show("Lütfen geçerli bir sayısal değer giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Müşteri bilgilerini almak için sorguyu hazırlayın
        Dim query As String = "SELECT Adı, Soyadı, HayvanAdı, Telefon FROM MüşteriTablo WHERE MüşteriID = @MusteriID"

        ' Verileri saklamak için bir DataTable oluşturun
        Dim dt As New DataTable()

        ' Veritabanı bağlantısı oluşturun ve sorguyu çalıştırın
        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                ' Parametreyi ekleyerek sorguyu hazırlayın
                cmd.Parameters.AddWithValue("@MusteriID", musteriID)

                ' Verileri adaptöre doldurun ve DataTable'a aktarın
                Dim adapter As New SqlDataAdapter(cmd)
                conn.Open()
                adapter.Fill(dt)
            End Using
        End Using

        ' DataTable'daki verileri DataGridView'e yükleyin
        musteridatas.DataSource = dt

        ' Eğer veri bulunamazsa kullanıcıya bilgilendirme mesajı gösterin
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Müşteri bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SatisYapBtn_Click(sender As Object, e As EventArgs) Handles SatisYapBtn.Click
        ' Satış işlemleri gerçekleştirildiğinde çağrılacak kod bloğu
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim satirSayisi As Integer = 0
            For Each row As DataGridViewRow In urunsatdata.Rows
                If Not row.IsNewRow Then
                    Dim personelID As Integer = Convert.ToInt32(row.Cells("PersonelID").Value)
                    Dim urunID As Integer = Convert.ToInt32(row.Cells("ÜrünID").Value)
                    Dim adet As Integer = Convert.ToInt32(row.Cells("Adet").Value)
                    Dim birimFiyat As Decimal = Convert.ToDecimal(row.Cells("Tutar").Value)
                    Dim toplamTutar As Decimal = birimFiyat * adet

                    ' FaturaTablo'ya ekleme işlemi
                    Dim cmd As New SqlCommand("INSERT INTO FaturaTablo (PersonelID, ÜrünID, Adet, Tutar) VALUES (@PersonelID, @ÜrünID, @Adet, @BirimFiyat); SELECT SCOPE_IDENTITY()", conn)
                    cmd.Parameters.AddWithValue("@PersonelID", personelID)
                    cmd.Parameters.AddWithValue("@ÜrünID", urunID)
                    cmd.Parameters.AddWithValue("@Adet", adet)
                    cmd.Parameters.AddWithValue("@BirimFiyat", birimFiyat)

                    Dim faturaID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' FaturaDetayTablo'ya ekleme işlemi
                    Dim faturaDetayCmd As New SqlCommand("INSERT INTO FaturaDetayTablo (FaturaID, ÜrünID, Adet, ToplamTutar) VALUES (@FaturaID, @ÜrünID, @Adet, @ToplamTutar)", conn)
                    faturaDetayCmd.Parameters.AddWithValue("@FaturaID", faturaID)
                    faturaDetayCmd.Parameters.AddWithValue("@ÜrünID", urunID)
                    faturaDetayCmd.Parameters.AddWithValue("@Adet", adet)
                    faturaDetayCmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar)

                    faturaDetayCmd.ExecuteNonQuery()

                    satirSayisi += 1

                    ' Stok sayısını güncelle
                    Dim updateCmd As New SqlCommand("UPDATE ÜrünlerTablo SET StokSayısı = StokSayısı - @Adet WHERE ÜrünID = @UrunID", conn)
                    updateCmd.Parameters.AddWithValue("@Adet", adet)
                    updateCmd.Parameters.AddWithValue("@UrunID", urunID)
                    updateCmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show(satirSayisi.ToString() & " adet satış başarıyla kaydedildi.", "Satış Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Baskı önizlemesi oluşturma
            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintDocument1_PrintPage

            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDoc

            ' Baskı önizleme penceresini hemen göster
            printPreviewDialog.ShowDialog()
        End Using
    End Sub
    Private Sub spttemizle_Click(sender As Object, e As EventArgs) Handles spttemizle.Click
        ' urunsatdata'nın DataSource'unun DataTable olduğunu varsayarak
        Dim dt As DataTable = CType(urunsatdata.DataSource, DataTable)
        dt.Clear()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim yPos As Integer = 100 ' Başlangıç yüksekliği
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim leftMargin As Integer = 50
        Dim rowHeight As Integer = 30 ' Satır yüksekliğini artırın

        ' Renkleri tanımla
        Dim purpleColor As Color = Color.FromArgb(128, 0, 165)
        Dim orangeColor As Color = Color.FromArgb(255, 185, 0)

        ' Başlık yazdırma, büyük ve ortalı
        Dim titleFont As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim titleSize As SizeF = e.Graphics.MeasureString("PetPlanet", titleFont)
        e.Graphics.DrawString("PetPlanet", titleFont, New SolidBrush(purpleColor), (pageWidth - titleSize.Width) / 2, 40)

        ' Kolon başlıkları, büyük ve ortalı
        Dim headers As String = "ÜrünID   Adet   Tutar"
        Dim headerFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim headerSize As SizeF = e.Graphics.MeasureString(headers, headerFont)
        e.Graphics.DrawString(headers, headerFont, New SolidBrush(orangeColor), (pageWidth - headerSize.Width) / 2, yPos)
        yPos += rowHeight

        Dim rowFont As New Font("Segoe UI", 12)
        For Each row As DataGridViewRow In urunsatdata.Rows
            If Not row.IsNewRow Then
                Try
                    Dim urunID As String = row.Cells("ÜrünID").Value.ToString()
                    Dim adet As String = row.Cells("Adet").Value.ToString()
                    Dim tutar As String = row.Cells("Tutar").Value.ToString()

                    Dim urunBilgisi As String = String.Format("{0,-10} {1,-10} {2,-10}", urunID, adet, tutar)
                    Dim rowSize As SizeF = e.Graphics.MeasureString(urunBilgisi, rowFont)
                    e.Graphics.DrawString(urunBilgisi, rowFont, New SolidBrush(orangeColor), (pageWidth - rowSize.Width) / 2, yPos)
                    yPos += rowHeight
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next

        yPos += 10
        e.Graphics.DrawLine(New Pen(purpleColor, 2), leftMargin, yPos, pageWidth - leftMargin, yPos)
        yPos += 20

        Dim totalText As String = "Toplam Tutar: " & lblToplamTutar.Text
        Dim totalFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim totalSize As SizeF = e.Graphics.MeasureString(totalText, totalFont)
        e.Graphics.DrawString(totalText, totalFont, New SolidBrush(orangeColor), (pageWidth - totalSize.Width) / 2, yPos)

        yPos += 40
        e.Graphics.DrawLine(New Pen(purpleColor, 2), leftMargin, yPos, pageWidth - leftMargin, yPos)
        yPos += 20

        Dim thanksText As String = "******* Teşekkür Ederiz *******"
        Dim thanksFont As New Font("Segoe UI", 12, FontStyle.Italic)
        Dim thanksSize As SizeF = e.Graphics.MeasureString(thanksText, thanksFont)
        e.Graphics.DrawString(thanksText, thanksFont, New SolidBrush(orangeColor), (pageWidth - thanksSize.Width) / 2, yPos)

        yPos += 60
        Dim specialText As String = "Sevgili müşterimiz, ürünlerimizi seçtiğiniz için teşekkür ederiz!"
        Dim specialFont As New Font("Segoe UI", 14, FontStyle.Bold Or FontStyle.Italic)
        Dim specialSize As SizeF = e.Graphics.MeasureString(specialText, specialFont)
        e.Graphics.DrawString(specialText, specialFont, New SolidBrush(purpleColor), (pageWidth - specialSize.Width) / 2, yPos)
    End Sub
End Class