Imports System
Imports System.Data

Public Class Form1

    Private repo As New NhanVienRepository()

    ' Load khi mở Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtMaNV.Enabled = False ' Mã NV khóa để không sửa
    End Sub

    ' Nạp dữ liệu lên DataGridView
    Private Sub LoadData()
        dgvNhanVien.DataSource = repo.GetAllNhanVien()
    End Sub

    ' Khi click 1 dòng trên DataGridView -> đổ dữ liệu lên TextBox/DateTimePicker
    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvNhanVien.Rows(e.RowIndex)

            txtMaNV.Text = If(row.Cells("MaNV").Value IsNot Nothing, row.Cells("MaNV").Value.ToString(), "")
            txtHoTen.Text = If(row.Cells("HoTen").Value IsNot Nothing, row.Cells("HoTen").Value.ToString(), "")
            txtSDT.Text = If(row.Cells("SoDienThoai").Value IsNot Nothing, row.Cells("SoDienThoai").Value.ToString(), "")
            txtDiaChi.Text = If(row.Cells("DiaChi").Value IsNot Nothing, row.Cells("DiaChi").Value.ToString(), "")

            ' Xử lý ngày
            Dim cellDate = row.Cells("NgayLamViec").Value
            If cellDate IsNot Nothing AndAlso Not IsDBNull(cellDate) Then
                Try
                    dtpNgayLam.Value = Convert.ToDateTime(cellDate)
                Catch
                    dtpNgayLam.Value = DateTime.Today
                End Try
            Else
                dtpNgayLam.Value = DateTime.Today
            End If
        End If
    End Sub

    ' Nút Thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If String.IsNullOrWhiteSpace(txtHoTen.Text) OrElse String.IsNullOrWhiteSpace(txtSDT.Text) Then
            MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ok = repo.AddNhanVien(txtHoTen.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim(), dtpNgayLam.Value.Date)
        If ok Then
            MessageBox.Show("Đã thêm nhân viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields()
        End If
    End Sub

    ' Nút Sửa
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If String.IsNullOrWhiteSpace(txtMaNV.Text) Then
            MessageBox.Show("Vui lòng chọn nhân viên để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim maNV As Integer
        If Not Integer.TryParse(txtMaNV.Text, maNV) Then
            MessageBox.Show("Mã NV không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim ok = repo.UpdateNhanVien(maNV, txtHoTen.Text.Trim(), txtSDT.Text.Trim(), txtDiaChi.Text.Trim(), dtpNgayLam.Value.Date)
        If ok Then
            MessageBox.Show("Đã cập nhật thông tin.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
            ClearFields()
        End If
    End Sub

    ' Nút Xóa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrWhiteSpace(txtMaNV.Text) Then
            MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim maNV As Integer
        If Not Integer.TryParse(txtMaNV.Text, maNV) Then
            MessageBox.Show("Mã NV không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim ok = repo.DeleteNhanVien(maNV)
            If ok Then
                MessageBox.Show("Đã xóa nhân viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            End If
        End If
    End Sub

    ' Nút Làm mới
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        ClearFields()
        LoadData()
    End Sub

    ' Xóa ô nhập liệu
    Private Sub ClearFields()
        txtMaNV.Text = ""
        txtHoTen.Text = ""
        txtSDT.Text = ""
        txtDiaChi.Text = ""
        dtpNgayLam.Value = DateTime.Today
    End Sub

    Private Sub lblNgayLam_Click(sender As Object, e As EventArgs) Handles lblNgayLam.Click

    End Sub
End Class
