using System;
using System.Windows.Forms;

namespace Basic
{
    public partial class FrmCon : Form
    {
        public FrmCon()
        {
            InitializeComponent();
        }

        public FrmCon(string dl)
        {
            InitializeComponent();

            textBox1.Text = dl;
        }

        public delegate void TruyenDL(string message);

        public TruyenDL truyenDL;

        private void button1_Click(object sender, EventArgs e)
        {
            if (truyenDL != null)
            {
                truyenDL(textBox1.Text);
            }
        }
    }
}