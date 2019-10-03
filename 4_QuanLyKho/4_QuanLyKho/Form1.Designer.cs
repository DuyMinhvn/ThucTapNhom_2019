namespace _4_QuanLyKho
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
            this.dataGridView_dshh = new System.Windows.Forms.DataGridView();
            this.button_Nhap = new System.Windows.Forms.Button();
            this.button_xuat = new System.Windows.Forms.Button();
            this.button_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dshh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_dshh
            // 
            this.dataGridView_dshh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dshh.Location = new System.Drawing.Point(93, 146);
            this.dataGridView_dshh.Name = "dataGridView_dshh";
            this.dataGridView_dshh.Size = new System.Drawing.Size(240, 150);
            this.dataGridView_dshh.TabIndex = 0;
            // 
            // button_Nhap
            // 
            this.button_Nhap.Location = new System.Drawing.Point(541, 52);
            this.button_Nhap.Name = "button_Nhap";
            this.button_Nhap.Size = new System.Drawing.Size(75, 23);
            this.button_Nhap.TabIndex = 1;
            this.button_Nhap.Text = "Nhập";
            this.button_Nhap.UseVisualStyleBackColor = true;
            // 
            // button_xuat
            // 
            this.button_xuat.Location = new System.Drawing.Point(541, 99);
            this.button_xuat.Name = "button_xuat";
            this.button_xuat.Size = new System.Drawing.Size(75, 23);
            this.button_xuat.TabIndex = 2;
            this.button_xuat.Text = "Xuất";
            this.button_xuat.UseVisualStyleBackColor = true;
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(541, 146);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(75, 23);
            this.button_timkiem.TabIndex = 3;
            this.button_timkiem.Text = "Tìm kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.timkiem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.button_xuat);
            this.Controls.Add(this.button_Nhap);
            this.Controls.Add(this.dataGridView_dshh);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dshh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dshh;
        private System.Windows.Forms.Button button_Nhap;
        private System.Windows.Forms.Button button_xuat;
        private System.Windows.Forms.Button button_timkiem;
    }
}

