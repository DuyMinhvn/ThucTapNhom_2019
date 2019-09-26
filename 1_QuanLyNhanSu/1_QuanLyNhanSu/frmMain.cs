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
    public partial class frmMain : Form
    {
        QLNSEntities obj = new QLNSEntities();
        int countThem = 0;
        public frmMain()
        {
           
            //}

            InitializeComponent();
            
            //using (var context = new QLNSEntities()) {

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
            if (countThem%2==0)
            {
                textBox_ma.Enabled = true;
                textBox_hoten.Enabled = true;
                textBox_dantoc.Enabled = true;
                textBox_quequan.Enabled = true;
                textBox_sdt.Enabled = true;
                comboBox_gioitinh.Enabled = true;
                dateTimePicker_ngaysinh.Enabled = true;
                textBox_Luong.Enabled = true;
                textBox_ma_ctac.Enabled = true;
                comboBox_cv.Enabled = true;
                comboBox_pb.Enabled = true;
                comboBox_td.Enabled = true;
                if (countThem == 0)
                {
                    foreach (PhongBan pb in obj.PhongBan)
                    {
                        comboBox_pb.Items.Add(pb.TenPhongBan.ToString());
                    }
                    foreach (ChucVu cv in obj.ChucVu)
                    {
                        comboBox_cv.Items.Add(cv.TenChucVu.ToString());
                    }
                    foreach (TrinhDoHocVan td in obj.TrinhDoHocVan)
                    {
                        comboBox_td.Items.Add(td.TenTrinhDoHocVan.ToString());
                    }
                }

                countThem++;
            }
            else
            {
                NhanVien nv = new NhanVien();
                nv.MaNhanVien = textBox_ma.Text;
                nv.HoTen = textBox_hoten.Text;
                nv.GioiTinh = comboBox_gioitinh.Text;
                nv.QueQuan = textBox_quequan.Text;
                nv.SDT = textBox_sdt.Text;
                nv.DanToc = textBox_dantoc.Text;
                nv.NgaySinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
                nv.MaTrinhDoHocVan = obj.TrinhDoHocVan.Where(z => z.TenTrinhDoHocVan == comboBox_td.Text).FirstOrDefault().MaTrinhDoHocVan.ToString();
                CongTac ct = new CongTac();



                textBox_ma.Text = "";
                textBox_hoten.Text = "";
                textBox_dantoc.Text = "";
                textBox_quequan.Text = "";
                textBox_sdt.Text = "";
                comboBox_gioitinh.Text = "";
                dateTimePicker_ngaysinh.Text = "";
                textBox_Luong.Text = "";
                comboBox_cv.Text = "";
                comboBox_pb.Text = "";
                comboBox_td.Text = "";
                textBox_ma_ctac.Text = "";

                textBox_ma.Enabled = false;
                textBox_hoten.Enabled = false;
                textBox_dantoc.Enabled = false;
                textBox_quequan.Enabled = false;
                textBox_sdt.Enabled = false;
                comboBox_gioitinh.Enabled = false;
                dateTimePicker_ngaysinh.Enabled = false;
                textBox_Luong.Enabled = false;
                textBox_ma_ctac.Enabled = false;
                comboBox_cv.Enabled = false;
                comboBox_pb.Enabled = false;
                comboBox_td.Enabled = false;

                countThem++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox_ma.Enabled = false;
            textBox_hoten.Enabled = false;
            textBox_dantoc.Enabled = false;
            textBox_quequan.Enabled = false;
            textBox_sdt.Enabled = false;
            comboBox_gioitinh.Enabled = false;
            dateTimePicker_ngaysinh.Enabled = false;
            textBox_Luong.Enabled = false;
            textBox_ma_ctac.Enabled = false;
            comboBox_cv.Enabled = false;
            comboBox_pb.Enabled = false;
            comboBox_td.Enabled = false;
            comboBox_ma_pb.Enabled = false;
            comboBox_ma_td.Enabled = false;
            comboBox_ma_cv.Enabled = false;
            var model = (from nv in obj.NhanVien
                         join ct in obj.CongTac
                         on nv.MaNhanVien equals ct.MaNhanVien
                         join cv in obj.ChucVu on ct.MaChucVu equals cv.MaChucVu
                         join pb in obj.PhongBan on ct.MaPhongBan equals pb.MaPhongBan
                         join td in obj.TrinhDoHocVan on nv.MaTrinhDoHocVan equals td.MaTrinhDoHocVan
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

                         });
            dataGridView_nhanvien.DataSource = model.ToList();

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
                    textBox_quequan.Text = row.Cells[5].Value.ToString();
                    dateTimePicker_ngaysinh.Text = row.Cells[6].Value.ToString();
                    comboBox_pb.Text = row.Cells[7].Value.ToString();
                    textBox_Luong.Text = row.Cells[9].Value.ToString();
                    comboBox_cv.Text = row.Cells[8].Value.ToString();
                    comboBox_td.Text = row.Cells[10].Value.ToString();
                    //textBox_hoten.Text = row.Cells[0].Value.ToString();
                }
            }
        }
        
        private void textBox_Cv_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_sửa_Click(object sender, EventArgs e)
        {
            textBox_ma.Enabled = false;
            textBox_hoten.Enabled = true;
            textBox_dantoc.Enabled = true;
            textBox_quequan.Enabled = true;
            textBox_sdt.Enabled = true;
            comboBox_gioitinh.Enabled = true;
            dateTimePicker_ngaysinh.Enabled = true;
            textBox_Luong.Enabled = true;
            comboBox_cv.Enabled =false;
            comboBox_pb.Enabled = false;
            comboBox_td.Enabled = false;
            comboBox_ma_pb.Enabled = true;
            comboBox_ma_td.Enabled = true;
            comboBox_ma_cv.Enabled = true;
            //hien lua chon o combobox ten phong ban
            comboBox_pb.DataSource = obj.PhongBan.ToList();
            comboBox_pb.DisplayMember = "TenPhongBan" ;
            comboBox_pb.ValueMember = "MaPhongBan";
            //hien thi lua chon o combobox chuc vu
            comboBox_cv.DataSource = obj.ChucVu.ToList();
            comboBox_cv.DisplayMember = "TenChucVu";
            comboBox_cv.ValueMember = "MaChucVu";
            //hien thi lua chon o combobox trinh do hoc van
            comboBox_td.DataSource = obj.TrinhDoHocVan.ToList();
            comboBox_td.DisplayMember = "TenTrinhDoHocVan";
            comboBox_td.ValueMember = "MaTrinhDoHocVan";
            //hien thi lua chon o combobox ma pb
            comboBox_ma_pb.DataSource = obj.PhongBan.ToList();
            comboBox_ma_pb.DisplayMember = "MaPhongBan" ;
            comboBox_ma_pb.ValueMember = "MaPhongBan";
            //hien thi lua chon o combobox ma cv
            comboBox_ma_cv.DataSource = obj.ChucVu.ToList();
            comboBox_ma_cv.DisplayMember = "MaChucVu";
            comboBox_ma_cv.ValueMember = "MaChucVu";
            //hien thi lua chon o combobox ma trinh do
            comboBox_ma_td.DataSource = obj.TrinhDoHocVan.ToList();
            comboBox_ma_td.DisplayMember = "MaTrinhDoHocVan";
            comboBox_ma_td.ValueMember = "MaTrinhDoHocVan";
            //update du lieu den tat ca cac bang
            var nv = obj.NhanVien.First<NhanVien>();
            nv.HoTen = textBox_hoten.Text;
            nv.DanToc = textBox_dantoc.Text;
            nv.SDT = textBox_sdt.Text;
            nv.GioiTinh = comboBox_gioitinh.Text;
            nv.NgaySinh = DateTime.Parse(dateTimePicker_ngaysinh.Text);
            nv.QueQuan = textBox_quequan.Text;
            nv.MaTrinhDoHocVan = comboBox_ma_td.Text;
            var ct = obj.CongTac.First<CongTac>();
            ct.MaChucVu = comboBox_ma_cv.Text;
            ct.MaPhongBan = comboBox_ma_pb.Text;
            obj.SaveChangesAsync();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            obj.SaveChangesAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
