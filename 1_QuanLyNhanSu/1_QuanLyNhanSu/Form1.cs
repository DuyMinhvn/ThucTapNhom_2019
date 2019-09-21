using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        QLNSEntities obj = new QLNSEntities();
        public Form1()
        {
            InitializeComponent();
            dataGridView_nhanvien.DataSource = obj.NhanViens.ToList();
            dataGridView_nhanvien.Columns[8].Visible = false;
            dataGridView_nhanvien.Columns[9].Visible = false;
            textBox_hoten.Enabled = false;
            textBox_dantoc.Enabled = false;
            textBox_sdt.Enabled = false;
            textBox_diachi.Enabled = false;
            comboBox_gioitinh.Enabled = false;
            dateTimePicker_ngaysinh.Enabled = false;
            
        }

        private void themNhanvien(object sender, EventArgs e)
        {

        }
    }
}
