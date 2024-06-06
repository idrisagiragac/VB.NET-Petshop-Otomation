Imports System.Data.SqlClient
Public Class PersonelForm
    Dim conn As New SqlConnection("Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True")
    Private Sub PersonelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDragHelper.AttachDragHandlers(Me)
        LoadPersonelData()
    End Sub
    Private Sub LoadPersonelData()
        Dim cmd As New SqlCommand("SELECT PersonelID, Adı, Soyadı, Pozisyon, Telefon, EPosta FROM PersonelTablo", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        personeldata.DataSource = dt
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        Dim Form2Form As New Form2()
        Form2Form.Show()
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
        Dim CustomerForm As New CustomersForm()
        CustomerForm.Show()
        Me.Hide()
    End Sub
    Private Sub PersonelBtn_Click(sender As Object, e As EventArgs) Handles PersonelBtn.Click

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

    Private Sub personeldata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles personeldata.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim index As Integer = e.RowIndex
            If index < personeldata.Rows.Count Then
                Dim selectedRow As DataGridViewRow = personeldata.Rows(index)
                ' ID sütunu DataGridView'deki indeksi 0 ise, diğer veriler için Cells(1) ve sonrası kullanılır
                PerAdı.Text = selectedRow.Cells(1).Value.ToString()
                PerSoyadı.Text = selectedRow.Cells(2).Value.ToString()
                PerPoz.Text = selectedRow.Cells(3).Value.ToString()
                PerTel.Text = selectedRow.Cells(4).Value.ToString()
                PerEPosta.Text = selectedRow.Cells(5).Value.ToString()
            End If
        End If
    End Sub
    Private Sub PerEkleBtn_Click(sender As Object, e As EventArgs) Handles PerEkleBtn.Click

        ' Textbox'ların boş olup olmadığını kontrol et
        If String.IsNullOrEmpty(PerAdı.Text) OrElse String.IsNullOrEmpty(PerSoyadı.Text) OrElse
           String.IsNullOrEmpty(PerPoz.Text) OrElse String.IsNullOrEmpty(PerTel.Text) OrElse
           String.IsNullOrEmpty(PerEPosta.Text) Then
            ' Boş textbox varsa uyarı ver
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Verileri kaydetmek için SQL sorgusu
        Dim sql As String = "INSERT INTO PersonelTablo (Adı, Soyadı, Pozisyon, Telefon, EPosta) " &
                        "VALUES (@adı, @soyadı, @pozisyon, @telefon, @EPosta)"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)


        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@Adı", PerAdı.Text)
        cmd.Parameters.AddWithValue("@Soyadı", PerSoyadı.Text)
        cmd.Parameters.AddWithValue("@Pozisyon", PerPoz.Text)
        cmd.Parameters.AddWithValue("@Telefon", PerTel.Text)
        cmd.Parameters.AddWithValue("@EPosta", PerEPosta.Text)

        ' Bağlantıyı aç
        conn.Open()

        ' Komutu çalıştır
        cmd.ExecuteNonQuery()

        ' Bağlantıyı kapat
        conn.Close()

        ' Kayıt işlemi başarılıysa mesaj ver
        MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' DataGridView'i güncelle
        LoadPersonelData()
        ' Textbox'ları temizle
        PerAdı.Text = ""
        PerSoyadı.Text = ""
        PerPoz.Text = ""
        PerTel.Text = ""
        PerEPosta.Text = ""
    End Sub
    Private Sub PerSilBtn_Click(sender As Object, e As EventArgs) Handles PerSilBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If personeldata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen silmek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan ID bilgisini al
        Dim selectedID As Integer = Convert.ToInt32(personeldata.SelectedRows(0).Cells("PersonelID").Value)

        ' Veritabanından personeli silmek için SQL sorgusu
        Dim sql As String = "DELETE FROM PersonelTablo WHERE PersonelID = @PersonelID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@PersonelID", selectedID)

        Try
            ' Bağlantıyı aç
            conn.Open()

            ' Komutu çalıştır
            cmd.ExecuteNonQuery()

            ' Mesaj ver
            MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' DataGridView'i güncelle
            LoadPersonelData()

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Bağlantıyı kapat
            conn.Close()
        End Try
    End Sub
    Private Sub PerGünBtn_Click(sender As Object, e As EventArgs) Handles PerGünBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If personeldata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen güncellemek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Eğer TextBox'lar boşsa güncelleme işlemini yapma
        If String.IsNullOrEmpty(PerAdı.Text) OrElse String.IsNullOrEmpty(PerSoyadı.Text) OrElse
           String.IsNullOrEmpty(PerPoz.Text) OrElse String.IsNullOrEmpty(PerTel.Text) OrElse
           String.IsNullOrEmpty(PerEPosta.Text) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan ID bilgisini al
        Dim selectedID As Integer = Convert.ToInt32(personeldata.SelectedRows(0).Cells("PersonelID").Value)

        ' Yeni bilgileri al
        Dim yeniAd As String = PerAdı.Text
        Dim yeniSoyad As String = PerSoyadı.Text
        Dim yeniPoz As String = PerPoz.Text
        Dim yeniTel As String = PerTel.Text
        Dim yeniEPosta As String = PerEPosta.Text

        ' Veritabanında güncelleme işlemi için SQL sorgusu
        Dim sql As String = "UPDATE PersonelTablo SET Adı = @ad, Soyadı = @soyad, Pozisyon = @poz, Telefon = @tel, EPosta = @eposta WHERE PersonelID = @PersonelID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@ad", yeniAd)
        cmd.Parameters.AddWithValue("@soyad", yeniSoyad)
        cmd.Parameters.AddWithValue("@poz", yeniPoz)
        cmd.Parameters.AddWithValue("@tel", yeniTel)
        cmd.Parameters.AddWithValue("@eposta", yeniEPosta)
        cmd.Parameters.AddWithValue("@PersonelID", selectedID)

        Try
            ' Bağlantıyı aç
            conn.Open()

            ' Komutu çalıştır
            cmd.ExecuteNonQuery()

            ' Mesaj ver
            MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' DataGridView'i güncelle
            LoadPersonelData()

            ' TextBox'ları temizle
            PerAdı.Text = ""
            PerSoyadı.Text = ""
            PerPoz.Text = ""
            PerTel.Text = ""
            PerEPosta.Text = ""

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Bağlantıyı kapat
            conn.Close()
        End Try
    End Sub
    Private Sub BtnTemizle_Click(sender As Object, e As EventArgs) Handles BtnTemizle.Click
        PerAdı.Text = ""
        PerSoyadı.Text = ""
        PerPoz.Text = ""
        PerTel.Text = ""
        PerEPosta.Text = ""
        LoadPersonelData()
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadFilteredPersonelData()
    End Sub

    Private Sub LoadFilteredPersonelData()
        Dim positionFilter As String = PerPoz.Text.Trim()
        Dim phoneFilter As String = PerTel.Text.Trim()

        Dim query As String = "SELECT PersonelID, Adı, Soyadı, Pozisyon, Telefon, EPosta FROM PersonelTablo WHERE 1=1"

        If Not String.IsNullOrEmpty(positionFilter) Then
            query += " AND Pozisyon LIKE '%' + @Position + '%'"
        End If
        If Not String.IsNullOrEmpty(phoneFilter) Then
            query += " AND Telefon LIKE '%' + @Phone + '%'"
        End If

        Dim cmd As New SqlCommand(query, conn)
        If Not String.IsNullOrEmpty(positionFilter) Then
            cmd.Parameters.AddWithValue("@Position", positionFilter)
        End If
        If Not String.IsNullOrEmpty(phoneFilter) Then
            cmd.Parameters.AddWithValue("@Phone", phoneFilter)
        End If

        Try
            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            personeldata.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Veritabanı hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
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
End Class
