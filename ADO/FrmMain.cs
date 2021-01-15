using Microsoft.ApplicationBlocks.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADO
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void HienThiSinhVienKhongCanKetNoi()
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

                //luu tru lai, khong can ket noi van dung duoc,
                //dataset: tap hop nhieu datatable => datatable: mot bang, gom nhieu hang => data row => data column
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dtSV = new DataTable();
                da.Fill(dtSV);

                //foreach (DataRow row in dtSV.Rows)
                //{
                //    string ID = row["MaSV"].ToString();
                //    string hoten = row["tensv"].ToString();
                //    MessageBox.Show(string.Format("ID: {0}\nHọ tên: {1}", ID, hoten));
                //}
                dgvSinhVien.DataSource = dtSV;
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

        private void ThuTucVaTruyenParams(string tensv, DateTime ngaysinh, string diachi, string donvihoctap)
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
                command.Parameters.AddWithValue("@TenSV", tensv);
                command.Parameters.AddWithValue("@NgaySinh", ngaysinh.ToString("yyyy/MM/dd"));
                command.Parameters.AddWithValue("@DiaChi", diachi);
                command.Parameters.AddWithValue("@DVHT", donvihoctap);

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

        private void HienThiSinhVien()
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

        private void SuDungSqlHelper()
        {
            string strCon = @"Data Source=.\sqlexpress;Initial Catalog=SinhVien;Integrated Security=True";
            try
            {
                string sql = @"SELECT TOP (1000) [MaSV]
                              ,[TenSV]
                              ,[NgaySinh]
                              ,[DiaChi]
                              ,[DVHT]
                            FROM[SinhVien].[dbo].[SinhVien]";
                DataTable dtData = new DataTable();
                dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, sql).Tables[0];
                dgvSinhVien.DataSource = dtData;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SuDungSqlHelper();
        }

        private void dgvSinhVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSinhVien[0, e.RowIndex].Value = e.RowIndex + 1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var masv = txtMsv.Text.Trim();
            var hoten = txthoten.Text.Trim();
            var diachi = txtdiachi.Text.Trim();
            DateTime ngaysinh = dpkNgaysinh.Value;
            var donvihoctap = txtdvht.Text.Trim();

            ThuTucVaTruyenParams(hoten, ngaysinh, diachi, donvihoctap);
            HienThiSinhVienKhongCanKetNoi();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            //if (rowIndex >= 0)
            //{
            //    DataGridViewRow row = dgvSinhVien.Rows[rowIndex];
            //    txtMsv.Text = row.Cells[1].Value.ToString();
            //    txthoten.Text = row.Cells[2].Value.ToString();
            //    dpkNgaysinh.Text = row.Cells[3].Value.ToString();
            //    txtdiachi.Text = row.Cells[4].Value.ToString();
            //    txtdvht.Text = row.Cells[5].Value.ToString();
            //}
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSinhVien.SelectedRows[0];
                txtMsv.Text = row.Cells[1].Value.ToString();
                txthoten.Text = row.Cells[2].Value.ToString();
                dpkNgaysinh.Text = row.Cells[3].Value.ToString();
                txtdiachi.Text = row.Cells[4].Value.ToString();
                txtdvht.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}