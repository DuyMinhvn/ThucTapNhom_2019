namespace _1_QuanLyNhanSu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_nhanvien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_td = new System.Windows.Forms.ComboBox();
            this.comboBox_cv = new System.Windows.Forms.ComboBox();
            this.comboBox_pb = new System.Windows.Forms.ComboBox();
            this.textBox_Luong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_huongdan = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_dantoc = new System.Windows.Forms.TextBox();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.textBox_diachi = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.comboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sửa = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_nhanvien
            // 
            this.dataGridView_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_nhanvien.Location = new System.Drawing.Point(0, 345);
            this.dataGridView_nhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            this.dataGridView_nhanvien.Size = new System.Drawing.Size(1016, 185);
            this.dataGridView_nhanvien.TabIndex = 1;
            this.dataGridView_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_nhanvien_CellClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_td);
            this.panel1.Controls.Add(this.comboBox_cv);
            this.panel1.Controls.Add(this.comboBox_pb);
            this.panel1.Controls.Add(this.textBox_Luong);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_ma);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_huongdan);
            this.panel1.Controls.Add(this.button_luu);
            this.panel1.Controls.Add(this.textBox_sdt);
            this.panel1.Controls.Add(this.textBox_dantoc);
            this.panel1.Controls.Add(this.textBox_hoten);
            this.panel1.Controls.Add(this.textBox_diachi);
            this.panel1.Controls.Add(this.dateTimePicker_ngaysinh);
            this.panel1.Controls.Add(this.comboBox_gioitinh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_timkiem);
            this.panel1.Controls.Add(this.button_xoa);
            this.panel1.Controls.Add(this.button_sửa);
            this.panel1.Controls.Add(this.button_them);
            this.panel1.Controls.Add(this.dataGridView_nhanvien);
            this.panel1.Location = new System.Drawing.Point(16, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 530);
            this.panel1.TabIndex = 2;
            // 
            // comboBox_td
            // 
            this.comboBox_td.FormattingEnabled = true;
            this.comboBox_td.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không xác định"});
            this.comboBox_td.Location = new System.Drawing.Point(566, 227);
            this.comboBox_td.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_td.Name = "comboBox_td";
            this.comboBox_td.Size = new System.Drawing.Size(265, 24);
            this.comboBox_td.TabIndex = 31;
            // 
            // comboBox_cv
            // 
            this.comboBox_cv.FormattingEnabled = true;
            this.comboBox_cv.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không xác định"});
            this.comboBox_cv.Location = new System.Drawing.Point(566, 152);
            this.comboBox_cv.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_cv.Name = "comboBox_cv";
            this.comboBox_cv.Size = new System.Drawing.Size(265, 24);
            this.comboBox_cv.TabIndex = 30;
            // 
            // comboBox_pb
            // 
            this.comboBox_pb.FormattingEnabled = true;
            this.comboBox_pb.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không xác định"});
            this.comboBox_pb.Location = new System.Drawing.Point(566, 118);
            this.comboBox_pb.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_pb.Name = "comboBox_pb";
            this.comboBox_pb.Size = new System.Drawing.Size(265, 24);
            this.comboBox_pb.TabIndex = 29;
            // 
            // textBox_Luong
            // 
            this.textBox_Luong.Location = new System.Drawing.Point(566, 198);
            this.textBox_Luong.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Luong.Name = "textBox_Luong";
            this.textBox_Luong.Size = new System.Drawing.Size(265, 22);
            this.textBox_Luong.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(437, 230);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tên Trình Độ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 198);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Lương";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 155);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tên Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 115);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tên Phòng Ban";
            // 
            // textBox_ma
            // 
            this.textBox_ma.Location = new System.Drawing.Point(566, 79);
            this.textBox_ma.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ma.Name = "textBox_ma";
            this.textBox_ma.Size = new System.Drawing.Size(265, 22);
            this.textBox_ma.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mã Nv";
            // 
            // button_huongdan
            // 
            this.button_huongdan.Location = new System.Drawing.Point(880, 16);
            this.button_huongdan.Margin = new System.Windows.Forms.Padding(4);
            this.button_huongdan.Name = "button_huongdan";
            this.button_huongdan.Size = new System.Drawing.Size(100, 28);
            this.button_huongdan.TabIndex = 19;
            this.button_huongdan.Text = "Hướng dẫn";
            this.button_huongdan.UseVisualStyleBackColor = true;
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(536, 17);
            this.button_luu.Margin = new System.Windows.Forms.Padding(4);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(100, 28);
            this.button_luu.TabIndex = 18;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Location = new System.Drawing.Point(137, 193);
            this.textBox_sdt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(247, 22);
            this.textBox_sdt.TabIndex = 17;
            // 
            // textBox_dantoc
            // 
            this.textBox_dantoc.Location = new System.Drawing.Point(137, 115);
            this.textBox_dantoc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dantoc.Name = "textBox_dantoc";
            this.textBox_dantoc.Size = new System.Drawing.Size(247, 22);
            this.textBox_dantoc.TabIndex = 16;
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Location = new System.Drawing.Point(137, 79);
            this.textBox_hoten.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(247, 22);
            this.textBox_hoten.TabIndex = 15;
            // 
            // textBox_diachi
            // 
            this.textBox_diachi.Location = new System.Drawing.Point(137, 267);
            this.textBox_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_diachi.Name = "textBox_diachi";
            this.textBox_diachi.Size = new System.Drawing.Size(254, 22);
            this.textBox_diachi.TabIndex = 14;
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(137, 230);
            this.dateTimePicker_ngaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker_ngaysinh.TabIndex = 13;
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.FormattingEnabled = true;
            this.comboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Không Xác Định"});
            this.comboBox_gioitinh.Location = new System.Drawing.Point(137, 155);
            this.comboBox_gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(247, 24);
            this.comboBox_gioitinh.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "SDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dân tộc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ tên";
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(705, 17);
            this.button_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(100, 28);
            this.button_timkiem.TabIndex = 5;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(371, 17);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(100, 28);
            this.button_xoa.TabIndex = 4;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            // 
            // button_sửa
            // 
            this.button_sửa.Location = new System.Drawing.Point(203, 17);
            this.button_sửa.Margin = new System.Windows.Forms.Padding(4);
            this.button_sửa.Name = "button_sửa";
            this.button_sửa.Size = new System.Drawing.Size(100, 28);
            this.button_sửa.TabIndex = 3;
            this.button_sửa.Text = "Sửa";
            this.button_sửa.UseVisualStyleBackColor = true;
            this.button_sửa.Click += new System.EventHandler(this.button_sửa_Click);
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(44, 18);
            this.button_them.Margin = new System.Windows.Forms.Padding(4);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(100, 28);
            this.button_them.TabIndex = 2;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.themNhanvien);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1048, 549);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_nhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_dantoc;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.TextBox textBox_diachi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.ComboBox comboBox_gioitinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sửa;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_huongdan;
        private System.Windows.Forms.TextBox textBox_ma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Luong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_td;
        private System.Windows.Forms.ComboBox comboBox_cv;
        private System.Windows.Forms.ComboBox comboBox_pb;
    }
}

