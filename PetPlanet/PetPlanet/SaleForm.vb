Imports System.Data.SqlClient
Public Class SaleForm
    ' Bağlantı dizesi
    Dim connStr As String = "Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True"
    Private Sub SaleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPetsData()
        LoadAlisData()
        LoadSatisData()
        FillSuppliersComboBox()
        FormDragHelper.AttachDragHandlers(Me)
        StockData()
    End Sub
    Private Sub LoadAlisData()
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            ' FaturaTablosu'ndan gerekli sütunları çeken sorguyu hazırlayın
            Dim query As String = "SELECT TedarikçiID, ÜrünID, Adet, Tutar FROM AlisSepet"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                ' Verileri DataTable'a doldur
                adapter.Fill(dt)
            End Using
        End Using
        ' DataGridView'e verileri yükle
        stoksatınalsepet.DataSource = dt
    End Sub
    Private Sub LoadSatisData()
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            ' FaturaTablosu'ndan gerekli sütunları çeken sorguyu hazırlayın
            Dim query As String = "SELECT  HayvanSatisID, Adet, Tutar FROM HayvanSepet"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                ' Verileri DataTable'a doldur
                adapter.Fill(dt)
            End Using
        End Using
        ' DataGridView'e verileri yükle
        hayvansatdata.DataSource = dt
    End Sub
    Private Sub StockData()
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            ' Sorguyu güncelle: stoksayısı minstoktan fazla olanları hariç tut
            Dim query As String = "SELECT ÜrünID, Adı, Maliyet, StokSayısı, MinStok FROM ürünlertablo WHERE StokSayısı <= MinStok"
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        stokdata.DataSource = dt
    End Sub
    Private Sub FillSuppliersComboBox()
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT TedarikçiID, Adı FROM TedarikçiTablo"
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim tedarikciler As New List(Of KeyValuePair(Of String, String))()
                        While reader.Read()
                            Dim id As String = reader("TedarikçiID").ToString()
                            Dim ad As String = reader("Adı").ToString()
                            ' Burada ID'yi değer, adı ise anahtar olarak ekliyoruz
                            tedarikciler.Add(New KeyValuePair(Of String, String)(id, ad))
                        End While
                        cmbTedarikçi.DataSource = tedarikciler
                        cmbTedarikçi.DisplayMember = "Value"
                        cmbTedarikçi.ValueMember = "Key"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Tedarikçi bilgileri yüklenirken bir hata oluştu: " & ex.Message)
        End Try
    End Sub
    Private Sub cmbTedarikçi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTedarikçi.SelectedIndexChanged
        If cmbTedarikçi.SelectedItem IsNot Nothing Then
            ' Seçilen öğeyi KeyValuePair olarak alıp, tedarikçinin adını TextBox'a yazdır
            Dim selectedPair As KeyValuePair(Of String, String) = DirectCast(cmbTedarikçi.SelectedItem, KeyValuePair(Of String, String))
            TedarikçiTxt.Text = selectedPair.Key ' Adı TextBox'a yazdır
        End If
    End Sub
    Private Sub LoadPetsData()
        Dim dt As New DataTable()

        ' Bağlantıyı oluştur
        Using conn As New SqlConnection(connStr)
            ' SQL sorgusu, StokSayısı sütunu Cinsiyet'ten önce eklendi
            Dim query As String = "SELECT HayvanSatisTablo.HayvanSatisID, HayvanTür.Adı AS [Tür], HayvanCins.Adı AS [Cins], HayvanSatisTablo.Fiyat, HayvanSatisTablo.StokSayısı, HayvanSatisTablo.Cinsiyet, HayvanSatisTablo.CinsID, HayvanSatisTablo.TürID FROM HayvanSatisTablo INNER JOIN HayvanTür ON HayvanSatisTablo.TürID = HayvanTür.TürID INNER JOIN HayvanCins ON HayvanSatisTablo.CinsID = HayvanCins.CinsID"
            ' Komut oluştur ve bağlantıyı aç
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                ' Veri adaptörü oluştur ve verileri DataTable'a doldur
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using

        ' DataGridView'e veri kaynağını ata
        hayvansatis.DataSource = dt

        ' DataGridView'deki belirli bir sütunu gizle
        hayvansatis.Columns("HayvanSatisID").Visible = True
        hayvansatis.Columns("CinsID").Visible = False
        hayvansatis.Columns("TürID").Visible = False

        ' StokSayısı sütununu ve diğer sütunları uygun görünürlükte ayarla
        hayvansatis.Columns("StokSayısı").Visible = True
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
    Private Sub TemizleBtn_Click(sender As Object, e As EventArgs) Handles TemizleBtn.Click
        Dim dt As DataTable = CType(stoksatınalsepet.DataSource, DataTable)
        dt.Clear()
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
    Private Sub stokdata_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles stokdata.CellDoubleClick
        ' Seçilen satırı al
        Dim selectedRow As DataGridViewRow = stokdata.Rows(e.RowIndex)

        ' Ürün bilgilerini al
        Dim urunID As String = selectedRow.Cells("ÜrünID").Value.ToString()
        Dim maliyet As Decimal = Convert.ToDecimal(selectedRow.Cells("Maliyet").Value)

        ' Kullanıcıdan ürün adedi için giriş al
        Dim adet As String = InputBox("Ürün Adedi Giriniz:", "Adet", "1")
        Dim adetSayisi As Integer

        ' Girişin geçerli bir sayı olup olmadığını kontrol et
        If Not Int32.TryParse(adet, adetSayisi) Then
            MessageBox.Show("Geçersiz adet girişi. Lütfen bir sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' DataTable'a yeni bir satır ekleyin
        Dim dt As DataTable = CType(stoksatınalsepet.DataSource, DataTable)
        Dim newRow As DataRow = dt.NewRow()
        newRow("TedarikçiID") = cmbTedarikçi.SelectedValue
        newRow("ÜrünID") = urunID
        newRow("Adet") = adetSayisi
        newRow("Tutar") = maliyet
        dt.Rows.Add(newRow)
        GuncelleToplamTutar()
    End Sub

    Private Sub UrunAlBtn_Click(sender As Object, e As EventArgs) Handles UrunAlBtn.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim satirSayisi As Integer = 0

            For Each row As DataGridViewRow In stoksatınalsepet.Rows
                If Not row.IsNewRow Then
                    Dim TedarikçiID As Integer = Convert.ToInt32(row.Cells("TedarikçiID").Value)
                    Dim urunID As Integer = Convert.ToInt32(row.Cells("ÜrünID").Value)
                    Dim adet As Integer = Convert.ToInt32(row.Cells("Adet").Value)
                    Dim maliyet As Decimal = Convert.ToDecimal(row.Cells("Tutar").Value)
                    Dim toplamTutar As Decimal = maliyet * adet

                    ' AlışTablo'ya ekleme işlemi
                    Dim cmd As New SqlCommand("INSERT INTO AlışTablo (TedarikçiID, ÜrünID, Adet, Tutar) VALUES (@TedarikçiID, @ÜrünID, @Adet, @Tutar); SELECT SCOPE_IDENTITY()", conn)
                    cmd.Parameters.AddWithValue("@TedarikçiID", TedarikçiID)
                    cmd.Parameters.AddWithValue("@ÜrünID", urunID)
                    cmd.Parameters.AddWithValue("@Adet", adet)
                    cmd.Parameters.AddWithValue("@Tutar", maliyet)

                    Dim alisID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' AlışDetayTablo'ya ekleme işlemi, toplam tutarı kaydet
                    Dim faturaDetayCmd As New SqlCommand("INSERT INTO AlışDetayTablo (AlışID, ÜrünID, Adet, ToplamTutar) VALUES (@AlışID, @ÜrünID, @Adet, @ToplamTutar)", conn)
                    faturaDetayCmd.Parameters.AddWithValue("@AlışID", alisID)
                    faturaDetayCmd.Parameters.AddWithValue("@ÜrünID", urunID)
                    faturaDetayCmd.Parameters.AddWithValue("@Adet", adet)
                    faturaDetayCmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar)

                    faturaDetayCmd.ExecuteNonQuery()

                    ' Stok sayısını artırma
                    Dim updateCmd As New SqlCommand("UPDATE ÜrünlerTablo SET StokSayısı = StokSayısı + @Adet WHERE ÜrünID = @UrunID", conn)
                    updateCmd.Parameters.AddWithValue("@Adet", adet)
                    updateCmd.Parameters.AddWithValue("@UrunID", urunID)
                    updateCmd.ExecuteNonQuery()

                    satirSayisi += 1
                End If
            Next

            MessageBox.Show(satirSayisi.ToString() & " adet alış işlemi başarıyla kaydedildi.", "Alış Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GuncelleToplamTutar()  ' Toplam tutarı güncelle ve göster
            StockData()
        End Using
        ' Baskı önizlemesi oluşturma
        Dim printDoc As New Printing.PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument1_PrintPage

        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDoc

        ' Baskı önizleme penceresini hemen göster
        printPreviewDialog.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' Seçili tedarikçi adını al
        Dim supplierName As String = If(cmbTedarikçi.SelectedItem IsNot Nothing, cmbTedarikçi.Text, "PetPlanet")

        Dim yPos As Integer = 100 ' Başlangıç yüksekliği
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim leftMargin As Integer = 50
        Dim rowHeight As Integer = 30 ' Satır yüksekliğini artırın

        ' Başlık yazdırma, büyük ve ortalı
        Dim titleFont As New Font("Segoe UI", 18, FontStyle.Bold)
        Dim titleSize As SizeF = e.Graphics.MeasureString(supplierName, titleFont)
        e.Graphics.DrawString(supplierName, titleFont, Brushes.Black, (pageWidth - titleSize.Width) / 2, 40)

        ' Kolon başlıkları, büyük ve ortalı
        Dim headers As String = "ÜrünID   Adet   Tutar"
        Dim headerFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim headerSize As SizeF = e.Graphics.MeasureString(headers, headerFont)
        e.Graphics.DrawString(headers, headerFont, Brushes.Black, (pageWidth - headerSize.Width) / 2, yPos)
        yPos += rowHeight

        ' DataGridView satırları için döngü
        Dim rowFont As New Font("Segoe UI", 12)
        For Each row As DataGridViewRow In stoksatınalsepet.Rows
            If Not row.IsNewRow Then
                Try
                    ' ÜrünID, adet ve tutar değerlerini al
                    Dim urunID As String = row.Cells("ÜrünID").Value.ToString()
                    Dim adet As String = row.Cells("Adet").Value.ToString()
                    Dim tutar As String = row.Cells("Tutar").Value.ToString()

                    ' ÜrünID, adet ve tutarı yazdır, ortalı
                    Dim urunBilgisi As String = String.Format("{0,-10} {1,-10} {2,-10}", urunID, adet, tutar)
                    Dim rowSize As SizeF = e.Graphics.MeasureString(urunBilgisi, rowFont)
                    e.Graphics.DrawString(urunBilgisi, rowFont, Brushes.Black, (pageWidth - rowSize.Width) / 2, yPos)
                    yPos += rowHeight ' Alt satıra geç
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next

        ' Toplam tutarı yazdır, büyük ve ortalı
        Dim totalText As String = lblToplamTutar.Text
        Dim totalFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim totalSize As SizeF = e.Graphics.MeasureString(totalText, totalFont)
        e.Graphics.DrawString(totalText, totalFont, Brushes.Crimson, (pageWidth - totalSize.Width) / 2, yPos)

        ' Teşekkür mesajı yazdır, ortalı
        yPos += 40
        Dim thanksText As String = "******* Teşekkür Ederiz *******"
        Dim thanksFont As New Font("Segoe UI", 12, FontStyle.Italic)
        Dim thanksSize As SizeF = e.Graphics.MeasureString(thanksText, thanksFont)
        e.Graphics.DrawString(thanksText, thanksFont, Brushes.Crimson, (pageWidth - thanksSize.Width) / 2, yPos)
    End Sub

    Private Sub GuncelleToplamTutar()
        Dim toplamTutar As Decimal = 0

        ' stoksatınalsepet DataGridView'deki her satır için 'Fiyat' ve 'Adet' sütunlarının değerlerini çarp ve topla
        For Each row As DataGridViewRow In stoksatınalsepet.Rows
            If Not row.IsNewRow Then
                Dim tutar As Decimal = Convert.ToDecimal(row.Cells("Tutar").Value)
                Dim adet As Integer = Convert.ToInt32(row.Cells("Adet").Value)
                toplamTutar += tutar * adet
            End If
        Next

        ' Toplam tutarı Label'da göster
        lblToplamTutar.Text = "Toplam Tutar: " & toplamTutar.ToString("C2")  ' C2, para birimi formatında gösterir
    End Sub

    Private Sub hayvansatis_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles hayvansatis.CellDoubleClick
        ' Seçilen satırı al
        Dim selectedRow As DataGridViewRow = hayvansatis.Rows(e.RowIndex)

        ' HayvanSatisID değerini al
        Dim hayvanSatisID As String = selectedRow.Cells("HayvanSatisID").Value.ToString()
        ' Stok sayısını al
        Dim stokSayisi As Integer = Convert.ToInt32(selectedRow.Cells("StokSayısı").Value)

        ' Kullanıcıdan adet bilgisi için giriş al
        Dim adet As String = InputBox("Satılacak Hayvan Adedi Giriniz:", "Adet", "1")
        Dim adetSayisi As Integer

        ' Girişin geçerli bir sayı olup olmadığını kontrol et
        If Not Int32.TryParse(adet, adetSayisi) Then
            MessageBox.Show("Geçersiz adet girişi. Lütfen bir sayı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Girilen adet sayısı stok sayısından fazla mı kontrol et
        If adetSayisi > stokSayisi Then
            MessageBox.Show("Yeterli stok yok. Stok Sayısı: " & stokSayisi.ToString(), "Stok Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Tutar hesaplama yok, direkt fiyatı al
        Dim fiyat As Decimal = Convert.ToDecimal(selectedRow.Cells("Fiyat").Value)

        ' DataTable'a yeni bir satır ekleyin
        Dim dt As DataTable = CType(hayvansatdata.DataSource, DataTable)
        Dim newRow As DataRow = dt.NewRow()
        newRow("HayvanSatisID") = hayvanSatisID
        newRow("Adet") = adetSayisi
        newRow("Tutar") = fiyat  ' Tutarı çarpmadan, girilen fiyatı kullan
        dt.Rows.Add(newRow)
        UpdateTotal()
    End Sub
    Private Sub UpdateTotal()
        ' DataTable'ı hayvansatdata DataGridView'den al
        Dim dt As DataTable = CType(hayvansatdata.DataSource, DataTable)

        ' Tutarların toplamını hesapla
        Dim total As Decimal = 0
        For Each row As DataRow In dt.Rows
            Dim adet As Integer = Convert.ToInt32(row("Adet"))
            Dim fiyat As Decimal = Convert.ToDecimal(row("Tutar"))  ' Bu, birim fiyatı temsil ediyor
            total += adet * fiyat  ' Adet ile birim fiyatı çarpıp toplama ekliyoruz
        Next

        ' Toplam tutarı Label'a yaz
        hayvansatlbl.Text = "Toplam Tutar: " & total.ToString("C2")
    End Sub

    Private Sub hayvansepettemizle_Click(sender As Object, e As EventArgs) Handles hayvansepettemizle.Click
        ' DataGridView'in DataSource'unu DataTable olarak al
        Dim dt As DataTable = CType(hayvansatdata.DataSource, DataTable)

        ' DataTable içindeki tüm satırları sil
        dt.Rows.Clear()

        ' Toplam tutarı güncelle (bu durumda 0 olacak)
        UpdateTotal()
    End Sub

    Private Sub HayvanSatisbtn_Click(sender As Object, e As EventArgs) Handles HayvanSatisbtn.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()

            Dim satirSayisi As Integer = 0
            For Each row As DataGridViewRow In hayvansatdata.Rows
                If Not row.IsNewRow Then
                    Dim hayvanSatisID As Integer = Convert.ToInt32(row.Cells("HayvanSatisID").Value)
                    Dim adet As Integer = Convert.ToInt32(row.Cells("Adet").Value)
                    Dim birimFiyat As Decimal = Convert.ToDecimal(row.Cells("Tutar").Value)
                    Dim toplamTutar As Decimal = birimFiyat * adet

                    ' HayvanFatura tablosuna ekleme işlemi
                    Dim cmd As New SqlCommand("INSERT INTO HayvanFatura (HayvanSatisID, Adet, Tutar) VALUES (@HayvanSatisID, @Adet, @Tutar); SELECT SCOPE_IDENTITY()", conn)
                    cmd.Parameters.AddWithValue("@HayvanSatisID", hayvanSatisID)
                    cmd.Parameters.AddWithValue("@Adet", adet)
                    cmd.Parameters.AddWithValue("@Tutar", birimFiyat)

                    Dim faturaID As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' HayvanFaturaDetay tablosuna ekleme işlemi
                    Dim faturaDetayCmd As New SqlCommand("INSERT INTO HayvanFaturaDetay (HayvanSatID, HayvanSatisID, Adet, ToplamTutar) VALUES (@HayvanSatID, @HayvanSatisID, @Adet, @ToplamTutar)", conn)
                    faturaDetayCmd.Parameters.AddWithValue("@HayvanSatID", faturaID)
                    faturaDetayCmd.Parameters.AddWithValue("@HayvanSatisID", hayvanSatisID)
                    faturaDetayCmd.Parameters.AddWithValue("@Adet", adet)
                    faturaDetayCmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar)

                    faturaDetayCmd.ExecuteNonQuery()

                    satirSayisi += 1

                    ' Stok sayısını güncelle
                    Dim updateCmd As New SqlCommand("UPDATE HayvanSatisTablo SET StokSayısı = StokSayısı - @Adet WHERE HayvanSatisID = @HayvanSatisID", conn)
                    updateCmd.Parameters.AddWithValue("@Adet", adet)
                    updateCmd.Parameters.AddWithValue("@HayvanSatisID", hayvanSatisID)
                    updateCmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show(satirSayisi.ToString() & " adet hayvan satışı başarıyla kaydedildi.", "Satış Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadPetsData()

            Dim printDoc As New Printing.PrintDocument()
            AddHandler printDoc.PrintPage, AddressOf PrintDocument2_PrintPage

            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = printDoc

            printPreviewDialog.ShowDialog()

            Dim soldAnimalsForm As New SoldAnimals()
            soldAnimalsForm.Show()
            Me.Hide()
        End Using
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim yPos As Integer = 100 ' Başlangıç yüksekliği
        Dim pageWidth As Integer = e.PageBounds.Width
        Dim leftMargin As Integer = 50 ' Sol kenar boşluğu
        Dim rowHeight As Integer = 40 ' Satır yüksekliğini artırın

        ' Renkleri tanımla
        Dim purpleColor As Color = Color.FromArgb(128, 0, 165)
        Dim orangeColor As Color = Color.FromArgb(255, 185, 0)

        ' Başlık yazdırma, büyük ve ortalı, mor renkli
        Dim titleFont As New Font("Segoe UI", 24, FontStyle.Bold)
        Dim titleSize As SizeF = e.Graphics.MeasureString("PetPlanet", titleFont)
        e.Graphics.DrawString("PetPlanet", titleFont, New SolidBrush(purpleColor), (pageWidth - titleSize.Width) / 2, 40)

        ' Çizgi çiz, mor renkli
        yPos += 40
        e.Graphics.DrawLine(New Pen(purpleColor, 2), leftMargin, yPos, pageWidth - leftMargin, yPos)
        yPos += 20

        ' Kolon başlıkları, büyük ve ortalı, turuncu renkli
        Dim headers As String = "HayvanSatisID   Adet   Tutar"
        Dim headerFont As New Font("Segoe UI", 14, FontStyle.Bold)
        Dim headerSize As SizeF = e.Graphics.MeasureString(headers, headerFont)
        e.Graphics.DrawString(headers, headerFont, New SolidBrush(orangeColor), (pageWidth - headerSize.Width) / 2, yPos)
        yPos += rowHeight

        ' DataGridView satırları için döngü
        Dim rowFont As New Font("Segoe UI", 12)
        For Each row As DataGridViewRow In hayvansatdata.Rows
            If Not row.IsNewRow Then
                Try
                    ' HayvanSatisID, adet ve tutar değerlerini al
                    Dim hayvanSatisID As String = row.Cells("HayvanSatisID").Value.ToString()
                    Dim adet As String = row.Cells("Adet").Value.ToString()
                    Dim tutar As String = row.Cells("Tutar").Value.ToString()

                    ' HayvanSatisID, adet ve tutarı yazdır, ortalı, turuncu renkli
                    Dim urunBilgisi As String = String.Format("{0,-15} {1,-10} {2,-10}", hayvanSatisID, adet, tutar)
                    Dim rowSize As SizeF = e.Graphics.MeasureString(urunBilgisi, rowFont)
                    e.Graphics.DrawString(urunBilgisi, rowFont, New SolidBrush(orangeColor), (pageWidth - rowSize.Width) / 2, yPos)
                    yPos += rowHeight ' Alt satıra geç
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Next

        ' Çizgi çiz, mor renkli
        yPos += 10
        e.Graphics.DrawLine(New Pen(purpleColor, 2), leftMargin, yPos, pageWidth - leftMargin, yPos)
        yPos += 20

        ' Toplam tutarı yazdır, büyük ve ortalı, turuncu renkli
        Dim totalText As String = "Toplam Tutar: " & hayvansatlbl.Text
        Dim totalFont As New Font("Segoe UI", 16, FontStyle.Bold)
        Dim totalSize As SizeF = e.Graphics.MeasureString(totalText, totalFont)
        e.Graphics.DrawString(totalText, totalFont, New SolidBrush(orangeColor), (pageWidth - totalSize.Width) / 2, yPos)

        ' Çizgi çiz, mor renkli
        yPos += 40
        e.Graphics.DrawLine(New Pen(purpleColor, 2), leftMargin, yPos, pageWidth - leftMargin, yPos)
        yPos += 20

        ' Teşekkür mesajı yazdır, ortalı, turuncu renkli
        Dim thanksText As String = "******* Teşekkür Ederiz *******"
        Dim thanksFont As New Font("Segoe UI", 14, FontStyle.Italic)
        Dim thanksSize As SizeF = e.Graphics.MeasureString(thanksText, thanksFont)
        e.Graphics.DrawString(thanksText, thanksFont, New SolidBrush(orangeColor), (pageWidth - thanksSize.Width) / 2, yPos)

        ' Özel mesaj yazdır, mor renkli
        yPos += 60
        Dim specialText As String = "Sevgili müşterimiz, evcil hayvanınızı seçtiğiniz için teşekkür ederiz!"
        Dim specialFont As New Font("Segoe UI", 14, FontStyle.Bold Or FontStyle.Italic)
        Dim specialSize As SizeF = e.Graphics.MeasureString(specialText, specialFont)
        e.Graphics.DrawString(specialText, specialFont, New SolidBrush(purpleColor), (pageWidth - specialSize.Width) / 2, yPos)
    End Sub
End Class