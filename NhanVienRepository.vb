
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class NhanVienRepository
    ' 🔗 Chuỗi kết nối đến SQL Server (hãy sửa Initial Catalog theo tên CSDL của bạn)
    Private connectionString As String = "Data Source=DESKTOP-LVGD82A\SQLEXPRESS;Initial Catalog=QuanLyNhanVienCafe;Integrated Security=True"

    ' ✅ Kiểm tra kết nối
    Public Function TestConnection() As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                MessageBox.Show("Kết nối CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show("Không thể kết nối CSDL: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' 📥 Lấy toàn bộ nhân viên
    Public Function GetAllNhanVien() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT MaNV, HoTen, SoDienThoai, DiaChi, NgayLamViec FROM NhanVien"
                Using da As New SqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải danh sách nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ➕ Thêm nhân viên
    Public Function AddNhanVien(hoTen As String, sdt As String, diaChi As String, ngayLamViec As Date) As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO NhanVien (HoTen, SoDienThoai, DiaChi, NgayLamViec) VALUES (@HoTen, @SDT, @DiaChi, @NgayLam)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@HoTen", hoTen)
                    cmd.Parameters.AddWithValue("@SDT", sdt)
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi)
                    cmd.Parameters.AddWithValue("@NgayLam", ngayLamViec)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Lỗi khi thêm nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ✏ Cập nhật nhân viên
    Public Function UpdateNhanVien(maNV As Integer, hoTen As String, sdt As String, diaChi As String, ngayLamViec As Date) As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE NhanVien SET HoTen=@HoTen, SoDienThoai=@SDT, DiaChi=@DiaChi, NgayLamViec=@NgayLam WHERE MaNV=@MaNV"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaNV", maNV)
                    cmd.Parameters.AddWithValue("@HoTen", hoTen)
                    cmd.Parameters.AddWithValue("@SDT", sdt)
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi)
                    cmd.Parameters.AddWithValue("@NgayLam", ngayLamViec)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Lỗi khi cập nhật nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' 🗑 Xóa nhân viên
    Public Function DeleteNhanVien(maNV As Integer) As Boolean
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM NhanVien WHERE MaNV=@MaNV"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@MaNV", maNV)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Lỗi khi xóa nhân viên: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class
