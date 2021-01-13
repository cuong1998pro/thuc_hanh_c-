using System;
using System.Windows.Forms;

namespace Basic
{
    public partial class FormCha : Form
    {
        public FormCha()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoten.Text.Trim();
            string diachi = txtDiachi.Text.Trim();
            string noiSinh = cboNoiSinh.Text.Trim();
            DateTime ngaySinh = dpkNgaySinh.Value;
            string gioiTinh = "";
            if (rdoNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            string soThich = "";
            foreach (var item in grpThongTin.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox checkbox = item as CheckBox;
                    if (checkbox.Checked)
                        soThich += checkbox.Text.Trim() + ", ";
                }
            }
            soThich = soThich.Substring(0, soThich.Length - 2);

            MessageBox.Show(
                string.Format("Họ tên: {0}\nGiới tính: {1}\n Địa chỉ: {2}\n Nơi sinh: {3}\n Sở thích: {4}\n Ngày sinh: {5}",
                hoTen, gioiTinh, diachi, noiSinh, soThich, ngaySinh),
                "Thông tin",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void NhanTinNhanTuFormCon(string message)
        {
            txtHoten.Text = (message.Trim());
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            FrmCon form = new FrmCon("text");
            form.truyenDL = new FrmCon.TruyenDL(NhanTinNhanTuFormCon);
            form.Show();
        }
    }
}