using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThuTucVaTruyenParams();
        }

        private void ThuTucVaTruyenParams()
        {
            string strCon = @"Data Source=.\sqlexpress;Initial Catalog=SinhVien;Integrated Security=True";
            var con = new SqlConnection(strCon);
            try
            {
                con.Open();
                //string sql = @"INSERT INTO [dbo].[SinhVien]
                //               ([TenSV]
                //               ,[NgaySinh]
                //               ,[DiaChi]
                //               ,[DVHT])
                //            VALUES
                //            (@TenSV, @NgaySinh, @Diachi, @DVHT)";
                string sql = @"MonHoc_Insert";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@TenSV", "Nguyễn Văn Hoàng");
                command.Parameters.AddWithValue("@NgaySinh", "2000-06-06");
                command.Parameters.AddWithValue("@DiaChi", "Hải Phòng");
                command.Parameters.AddWithValue("@DVHT", "Hàn Quốc");

                //neu la thu tuc them commandtype la thu tuc, khong thi k can
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void NhapSinhVien()
        {
            string strCon = @"Data Source=.\sqlexpress;Initial Catalog=SinhVien;Integrated Security=True";
            var con = new SqlConnection(strCon);
            try
            {
                con.Open();
                string sql = @"INSERT INTO [dbo].[SinhVien]
                               ([TenSV]
                               ,[NgaySinh]
                               ,[DiaChi]
                               ,[DVHT])
                            VALUES
                            (N'Nguyễn Văn Linh', '2020-1-1', N'Hải Phòng', 'CNT57DH')";

                SqlCommand command = new SqlCommand(sql, con);
                //tuong tu: them, cap nhat, xoa => excutenonequery
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void KetNoiCSDL()
        {
            string strCon = @"Data Source=.\sqlexpress;Initial Catalog=SinhVien;Integrated Security=True";
            var con = new SqlConnection(strCon);
            try
            {
                con.Open();
                string sql = @"SELECT TOP (1000) [MaSV]
                              ,[TenSV]
                              ,[NgaySinh]
                              ,[DiaChi]
                              ,[DVHT]
                            FROM[SinhVien].[dbo].[SinhVien]";
                var command = new SqlCommand(sql, con);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader["masv"].ToString();
                    string hoten = reader["tensv"].ToString();
                    MessageBox.Show(string.Format("ID: {0}\nHọ tên: {1}", ID, hoten));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}