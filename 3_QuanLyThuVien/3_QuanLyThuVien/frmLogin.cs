using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_QuanLyThuVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmController.show_panel( pnlDangNhap, false);
            frmController.show_panel( pnlDangKy, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmController.show_panel(pnlDangNhap, true);
            frmController.show_panel(pnlDangKy, false);
        }
    }
}
