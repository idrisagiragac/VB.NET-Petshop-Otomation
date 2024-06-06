Imports System.Data.SqlClient
Public Class CustomersForm
    Dim conn As New SqlConnection("Data Source=localhost ;Initial Catalog=PetShopDB;Integrated Security=True")
    Private Sub CustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormDragHelper.AttachDragHandlers(Me)
        LoadCustomerData()
    End Sub
    Private Sub LoadCustomerData()
        Dim cmd As New SqlCommand("SELECT MüşteriID, Adı, Soyadı, HayvanAdı, Telefon, EPosta, Adres FROM MüşteriTablo", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        musteridata.DataSource = dt
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
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMin_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub musteridata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles musteridata.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim index As Integer = e.RowIndex
            If index < musteridata.Rows.Count Then
                Dim selectedRow As DataGridViewRow = musteridata.Rows(index)
                ' Id sütununu almak için, Cells(0) kullanılır
                ' Diğer veriler için Cells(1) ve sonrası kullanılır
                MüsAdı.Text = selectedRow.Cells(1).Value.ToString()
                MüsSoyadı.Text = selectedRow.Cells(2).Value.ToString()
                HayvanAdıMus.Text = selectedRow.Cells(3).Value.ToString()
                MüsTel.Text = selectedRow.Cells(4).Value.ToString()
                MüsEPos.Text = selectedRow.Cells(5).Value.ToString()
                MüsAdr.Text = selectedRow.Cells(6).Value.ToString()
            End If
        End If
    End Sub
    Private Sub MüsEkleBtn_Click(sender As Object, e As EventArgs) Handles MüsEkleBtn.Click
        ' Textbox'ların boş olup olmadığını kontrol et
        If String.IsNullOrEmpty(MüsAdı.Text) OrElse String.IsNullOrEmpty(MüsSoyadı.Text) OrElse
           String.IsNullOrEmpty(HayvanAdıMus.Text) OrElse String.IsNullOrEmpty(MüsTel.Text) OrElse
           String.IsNullOrEmpty(MüsEPos.Text) OrElse String.IsNullOrEmpty(MüsAdr.Text) Then
            ' Boş textbox varsa uyarı ver
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Verileri kaydetmek için SQL sorgusu
        Dim sql As String = "INSERT INTO MüşteriTablo (Adı, Soyadı, HayvanAdı, Telefon, EPosta, Adres) " &
                        "VALUES (@adı, @soyadı, @hayvanadı, @telefon, @EPosta, @adres)"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@adı", MüsAdı.Text)
        cmd.Parameters.AddWithValue("@soyadı", MüsSoyadı.Text)
        cmd.Parameters.AddWithValue("@hayvanAdı", HayvanAdıMus.Text)
        cmd.Parameters.AddWithValue("@telefon", MüsTel.Text)
        cmd.Parameters.AddWithValue("@EPosta", MüsEPos.Text)
        cmd.Parameters.AddWithValue("@adres", MüsAdr.Text)
        ' Bağlantıyı aç
        conn.Open()

        ' Komutu çalıştır
        cmd.ExecuteNonQuery()

        ' Bağlantıyı kapat
        conn.Close()

        ' Kayıt işlemi başarılıysa mesaj ver
        MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' DataGridView'i güncelle
        LoadCustomerData()
        ' Textbox'ları temizle
        MüsAdı.Text = ""
        MüsSoyadı.Text = ""
        HayvanAdıMus.Text = ""
        MüsTel.Text = ""
        MüsEPos.Text = ""
        MüsAdr.Text = ""
    End Sub
    Private Sub MüsSilBtn_Click(sender As Object, e As EventArgs) Handles MüsSilBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If musteridata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan Id bilgisini al
        Dim selectedId As Integer = Convert.ToInt32(musteridata.SelectedRows(0).Cells("MüşteriID").Value)

        ' Veritabanından müşteriyi silmek için SQL sorgusu
        Dim sql As String = "DELETE FROM MüşteriTablo WHERE MüşteriID = @MüşteriID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@MüşteriID", selectedId)

        Try
            ' Bağlantıyı aç
            conn.Open()

            ' Komutu çalıştır
            cmd.ExecuteNonQuery()

            ' Mesaj ver
            MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' DataGridView'i güncelle
            LoadCustomerData()

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Bağlantıyı kapat
            conn.Close()
        End Try
    End Sub
    Private Sub MüsGünBtn_Click(sender As Object, e As EventArgs) Handles MüsGünBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If musteridata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Eğer TextBox'lar boşsa güncelleme işlemini yapma
        If String.IsNullOrEmpty(MüsAdı.Text) OrElse String.IsNullOrEmpty(MüsSoyadı.Text) OrElse
           String.IsNullOrEmpty(HayvanAdıMus.Text) OrElse String.IsNullOrEmpty(MüsTel.Text) OrElse
           String.IsNullOrEmpty(MüsEPos.Text) OrElse String.IsNullOrEmpty(MüsAdr.Text) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan Id bilgisini al
        Dim selectedId As Integer = Convert.ToInt32(musteridata.SelectedRows(0).Cells("MüşteriID").Value)

        ' Veritabanında güncelleme işlemi için SQL sorgusu
        Dim sql As String = "UPDATE MüşteriTablo SET Adı = @adı, Soyadı = @soyadı, HayvanAdı = @hayvanadı, Telefon = @telefon, EPosta = @EPosta, Adres = @adres WHERE MüşteriId = @id"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@adı", MüsAdı.Text)
        cmd.Parameters.AddWithValue("@soyadı", MüsSoyadı.Text)
        cmd.Parameters.AddWithValue("@hayvanAdı", HayvanAdıMus.Text)
        cmd.Parameters.AddWithValue("@telefon", MüsTel.Text)
        cmd.Parameters.AddWithValue("@EPosta", MüsEPos.Text)
        cmd.Parameters.AddWithValue("@adres", MüsAdr.Text)
        cmd.Parameters.AddWithValue("@id", selectedId)

        Try
            ' Bağlantıyı aç
            conn.Open()

            ' Komutu çalıştır
            cmd.ExecuteNonQuery()

            ' Mesaj ver
            MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' DataGridView'i güncelle
            LoadCustomerData()
            ' Textbox'ları temizle
            MüsAdı.Text = ""
            MüsSoyadı.Text = ""
            HayvanAdıMus.Text = ""
            MüsTel.Text = ""
            MüsEPos.Text = ""
            MüsAdr.Text = ""

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Bağlantıyı kapat
            conn.Close()
        End Try
    End Sub
    Private Sub BtnTemizle_Click(sender As Object, e As EventArgs) Handles BtnTemizle.Click
        MüsAdı.Text = ""
        MüsSoyadı.Text = ""
        HayvanAdıMus.Text = ""
        MüsTel.Text = ""
        MüsEPos.Text = ""
        MüsAdr.Text = ""
        LoadCustomerData()
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadFilteredCustomerData()
    End Sub
    Private Sub LoadFilteredCustomerData()
        Dim animalName As String = HayvanAdıMus.Text.Trim()
        Dim phoneNumber As String = MüsTel.Text.Trim()

        Dim baseQuery As String = "SELECT MüşteriID, Adı, Soyadı, HayvanAdı, Telefon, EPosta, Adres FROM MüşteriTablo WHERE 1=1"

        If Not String.IsNullOrEmpty(animalName) Then
            baseQuery += " AND HayvanAdı LIKE '%' + @animalName + '%'"
        End If

        If Not String.IsNullOrEmpty(phoneNumber) Then
            baseQuery += " AND Telefon LIKE '%' + @phoneNumber + '%'"
        End If

        Dim cmd As New SqlCommand(baseQuery, conn)
        If Not String.IsNullOrEmpty(animalName) Then
            cmd.Parameters.AddWithValue("@animalName", animalName)
        End If

        If Not String.IsNullOrEmpty(phoneNumber) Then
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
        End If

        Try
            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            musteridata.DataSource = dt
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