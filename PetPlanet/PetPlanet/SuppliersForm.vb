Imports System.Data.SqlClient
Public Class SuppliersForm
    Dim conn As New SqlConnection("Data Source=localhost;Initial Catalog=PetShopDB;Integrated Security=True")
    Private Sub SuppliersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliersData()
        FormDragHelper.AttachDragHandlers(Me)
    End Sub
    Private Sub LoadSuppliersData()
        Dim cmd As New SqlCommand("SELECT TedarikçiID, Adı, Adres, Telefon FROM TedarikçiTablo", conn)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        tedarikcidata.DataSource = dt
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
    Private Sub tedarikcidata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tedarikcidata.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim index As Integer = e.RowIndex
            If index < tedarikcidata.Rows.Count Then
                Dim selectedRow As DataGridViewRow = tedarikcidata.Rows(index)
                ' Id sütununu almak için, Cells(0) kullanılır
                ' Diğer veriler için Cells(1) ve sonrası kullanılır
                FirmAd.Text = selectedRow.Cells(1).Value.ToString()
                FirmAdr.Text = selectedRow.Cells(2).Value.ToString()
                FirmTel.Text = selectedRow.Cells(3).Value.ToString()
            End If
        End If
    End Sub
    Private Sub TedEkleBtn_Click(sender As Object, e As EventArgs) Handles TedEkleBtn.Click
        ' Textbox'ların boş olup olmadığını kontrol et
        If String.IsNullOrEmpty(FirmAd.Text) OrElse String.IsNullOrEmpty(FirmAdr.Text) OrElse
       String.IsNullOrEmpty(FirmTel.Text) Then
            ' Boş textbox varsa uyarı ver
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Verileri kaydetmek için SQL sorgusu
        Dim sql As String = "INSERT INTO TedarikçiTablo (Adı, Adres, Telefon) " &
                    "VALUES (@adı, @adres, @telefon)"  ' Buradaki virgül kaldırıldı

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@adı", FirmAd.Text)
        cmd.Parameters.AddWithValue("@adres", FirmAdr.Text)
        cmd.Parameters.AddWithValue("@telefon", FirmTel.Text)
        ' Bağlantıyı aç
        conn.Open()
        ' Komutu çalıştır
        cmd.ExecuteNonQuery()

        ' Bağlantıyı kapat
        conn.Close()

        ' Kayıt işlemi başarılıysa mesaj ver
        MessageBox.Show("Tedarikçi başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' DataGridView'i güncelle
        LoadSuppliersData()
        ' Textbox'ları temizle
        FirmAd.Text = ""
        FirmAdr.Text = ""
        FirmTel.Text = ""
    End Sub
    Private Sub TedSilBtn_Click(sender As Object, e As EventArgs) Handles TedSilBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If tedarikcidata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen silmek için bir tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan Id bilgisini al
        Dim selectedId As Integer = Convert.ToInt32(tedarikcidata.SelectedRows(0).Cells("TedarikçiID").Value)

        ' Veritabanından müşteriyi silmek için SQL sorgusu
        Dim sql As String = "DELETE FROM TedarikçiTablo WHERE TedarikçiID = @ID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)

        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@ID", selectedId)

        Try
            ' Bağlantıyı aç
            conn.Open()

            ' Komutu çalıştır
            cmd.ExecuteNonQuery()

            ' Mesaj ver
            MessageBox.Show("Tedarikçi başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' DataGridView'i güncelle
            LoadSuppliersData()

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Bağlantıyı kapat
            conn.Close()
        End Try
    End Sub
    Private Sub TedGuncelleBtn_Click(sender As Object, e As EventArgs) Handles TedGuncelleBtn.Click
        ' Seçilen satırın doğruluğunu kontrol et
        If tedarikcidata.SelectedRows.Count = 0 Then
            MessageBox.Show("Lütfen güncellemek için bir tedarikçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' TextBox'ların boş olup olmadığını kontrol et
        If String.IsNullOrEmpty(FirmAd.Text) OrElse
           String.IsNullOrEmpty(FirmAdr.Text) OrElse
           String.IsNullOrEmpty(FirmTel.Text) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Seçilen satırdan Id bilgisini al
        Dim selectedId As Integer = Convert.ToInt32(tedarikcidata.SelectedRows(0).Cells("ID").Value)

        ' Veritabanında tedarikçiyi güncellemek için SQL sorgusu
        Dim sql As String = "UPDATE TedarikçiTablo SET Adı = @Adı, Adres = @Adres, Telefon = @Telefon WHERE TedarikçiID = @ID"

        ' SqlCommand nesnesi oluştur ve SQL sorgusunu ata
        Dim cmd As New SqlCommand(sql, conn)
        ' Parametreleri ekle
        cmd.Parameters.AddWithValue("@Adı", FirmAd.Text)
        cmd.Parameters.AddWithValue("@Adres", FirmAdr.Text)
        cmd.Parameters.AddWithValue("@Telefon", FirmTel.Text)
        cmd.Parameters.AddWithValue("@ID", selectedId)

        Try
            ' Bağlantıyı aç
            conn.Open()

            ' Komutu çalıştır
            cmd.ExecuteNonQuery()

            ' Mesaj ver
            MessageBox.Show("Tedarikçi başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' DataGridView'i güncelle
            LoadSuppliersData()

            ' TextBox'ları temizle
            FirmAd.Text = ""
            FirmAdr.Text = ""
            FirmTel.Text = ""

        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Bağlantıyı kapat
            conn.Close()
        End Try
    End Sub
    Private Sub BtnTemizle_Click(sender As Object, e As EventArgs) Handles BtnTemizle.Click
        ' Belirli TextBox kontrollerini temizle
        FirmAd.Text = ""
        FirmAdr.Text = ""
        FirmTel.Text = ""
        LoadSuppliersData()
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        LoadFilteredSuppliersData()
    End Sub
    Private Sub LoadFilteredSuppliersData()
        Dim nameFilter As String = FirmAd.Text.Trim()
        Dim phoneFilter As String = FirmTel.Text.Trim()

        Dim query As String = "SELECT TedarikçiID, Adı, Adres, Telefon FROM TedarikçiTablo WHERE 1=1"

        If Not String.IsNullOrEmpty(nameFilter) Then
            query += " AND Adı LIKE '%' + @Name + '%'"
        End If
        If Not String.IsNullOrEmpty(phoneFilter) Then
            query += " AND Telefon LIKE '%' + @Phone + '%'"
        End If

        Dim cmd As New SqlCommand(query, conn)
        If Not String.IsNullOrEmpty(nameFilter) Then
            cmd.Parameters.AddWithValue("@Name", nameFilter)
        End If
        If Not String.IsNullOrEmpty(phoneFilter) Then
            cmd.Parameters.AddWithValue("@Phone", phoneFilter)
        End If

        Try
            conn.Open()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)
            tedarikcidata.DataSource = dt
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