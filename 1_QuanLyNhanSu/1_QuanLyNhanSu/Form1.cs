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
            var model = (from nv in obj.NhanViens
                         join ct in obj.CongTacs
                         on nv.MaNhanVien equals ct.MaNhanVien
                         join cv in obj.ChucVus on ct.MaChucVu equals cv.MaChucVu
                         join pb in obj.PhongBans on ct.MaPhongBan equals pb.MaPhongBan
                         join td in obj.TrinhDoHocVans on nv.MaTrinhDoHocVan equals td.MaTrinhDoHocVan
                         select new
                         {
                             MaNhanVien = nv.MaNhanVien,
                             HoTen = nv.HoTen,
                             DanToc = nv.DanToc,
                             GioiTinh = nv.GioiTinh,
                             SDT = nv.SDT,
                             QueQuan = nv.QueQuan,
                             NgaySinh = nv.NgaySinh,
                             TenPhongBan = pb.TenPhongBan,
                             TenChucVu = cv.TenChucVu,
                             Luong = ct.Luong,
                             TenTDHv = td.TenTrinhDoHocVan

                         })
                         ;
            InitializeComponent();
            dataGridView_nhanvien.DataSource = model.ToList();
            //dataGridView_nhanvien.Columns[8].Visible = false;
            //dataGridView_nhanvien.Columns[9].Visible = false;
            //textBox_hoten.Enabled = false;
            //textBox_dantoc.Enabled = false;
            //textBox_sdt.Enabled = false;
            //textBox_diachi.Enabled = false;
            //comboBox_gioitinh.Enabled = false;
            //dateTimePicker_ngaysinh.Enabled = false;
            
        }

        private void themNhanvien(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox_ma.Enabled = false;
            textBox_hoten.Enabled = false;
            textBox_dantoc.Enabled = false;
            textBox_diachi.Enabled = false;
            textBox_sdt.Enabled = false;
            comboBox_gioitinh.Enabled = false;
            dateTimePicker_ngaysinh.Enabled = false;
        }

        private void dataGridView_nhanvien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_nhanvien.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView_nhanvien.SelectedRows)
                {
                    textBox_ma.Text = row.Cells[0].Value.ToString();
                    textBox_hoten.Text = row.Cells[1].Value.ToString();
                    textBox_dantoc.Text = row.Cells[2].Value.ToString();
                    comboBox_gioitinh.Text = row.Cells[3].Value.ToString();
                    textBox_sdt.Text = row.Cells[4].Value.ToString();
                    textBox_diachi.Text = row.Cells[5].Value.ToString();
                    dateTimePicker_ngaysinh.Text = row.Cells[6].Value.ToString();
                    //textBox_hoten.Text = row.Cells[0].Value.ToString();

                }
            }
        }
    }
}
