namespace qltv
{
    partial class frm_Kho
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
            this.dgv_dssachtrongphieunhap = new System.Windows.Forms.DataGridView();
            this.cbo_nhacungcap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_nhanvien = new System.Windows.Forms.ComboBox();
            this.cbo_khonhap = new System.Windows.Forms.ComboBox();
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbo_chonsach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_dongianhap = new System.Windows.Forms.TextBox();
            this.num_soluongnhap = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssachtrongphieunhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluongnhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_dssachtrongphieunhap
            // 
            this.dgv_dssachtrongphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssachtrongphieunhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dssachtrongphieunhap.Location = new System.Drawing.Point(3, 26);
            this.dgv_dssachtrongphieunhap.Name = "dgv_dssachtrongphieunhap";
            this.dgv_dssachtrongphieunhap.RowHeadersWidth = 51;
            this.dgv_dssachtrongphieunhap.RowTemplate.Height = 24;
            this.dgv_dssachtrongphieunhap.Size = new System.Drawing.Size(1247, 171);
            this.dgv_dssachtrongphieunhap.TabIndex = 0;
            // 
            // cbo_nhacungcap
            // 
            this.cbo_nhacungcap.FormattingEnabled = true;
            this.cbo_nhacungcap.Location = new System.Drawing.Point(177, 30);
            this.cbo_nhacungcap.Name = "cbo_nhacungcap";
            this.cbo_nhacungcap.Size = new System.Drawing.Size(381, 33);
            this.cbo_nhacungcap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kho Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1253, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHO SÁCH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_ngaynhap);
            this.groupBox1.Controls.Add(this.cbo_khonhap);
            this.groupBox1.Controls.Add(this.cbo_nhanvien);
            this.groupBox1.Controls.Add(this.cbo_nhacungcap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1253, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phiếu Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_soluongnhap);
            this.groupBox2.Controls.Add(this.txt_dongianhap);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.cbo_chonsach);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1253, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Sách Nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_dssachtrongphieunhap);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1253, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sách Trong Phiếu Nhập";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 198F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 642);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cbo_nhanvien
            // 
            this.cbo_nhanvien.FormattingEnabled = true;
            this.cbo_nhanvien.Location = new System.Drawing.Point(177, 98);
            this.cbo_nhanvien.Name = "cbo_nhanvien";
            this.cbo_nhanvien.Size = new System.Drawing.Size(381, 33);
            this.cbo_nhanvien.TabIndex = 8;
            // 
            // cbo_khonhap
            // 
            this.cbo_khonhap.FormattingEnabled = true;
            this.cbo_khonhap.Location = new System.Drawing.Point(794, 30);
            this.cbo_khonhap.Name = "cbo_khonhap";
            this.cbo_khonhap.Size = new System.Drawing.Size(381, 33);
            this.cbo_khonhap.TabIndex = 9;
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.Location = new System.Drawing.Point(794, 103);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(381, 30);
            this.dtp_ngaynhap.TabIndex = 10;
            // 
            // cbo_chonsach
            // 
            this.cbo_chonsach.FormattingEnabled = true;
            this.cbo_chonsach.Location = new System.Drawing.Point(177, 53);
            this.cbo_chonsach.Name = "cbo_chonsach";
            this.cbo_chonsach.Size = new System.Drawing.Size(381, 33);
            this.cbo_chonsach.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số Lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn Giá Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Chọn Sách";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(794, 109);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(227, 55);
            this.btn_them.TabIndex = 18;
            this.btn_them.Text = "Thêm Sách";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_dongianhap
            // 
            this.txt_dongianhap.Location = new System.Drawing.Point(177, 124);
            this.txt_dongianhap.Name = "txt_dongianhap";
            this.txt_dongianhap.Size = new System.Drawing.Size(381, 30);
            this.txt_dongianhap.TabIndex = 19;
            // 
            // num_soluongnhap
            // 
            this.num_soluongnhap.Location = new System.Drawing.Point(794, 51);
            this.num_soluongnhap.Name = "num_soluongnhap";
            this.num_soluongnhap.Size = new System.Drawing.Size(381, 30);
            this.num_soluongnhap.TabIndex = 20;
            // 
            // frm_Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 642);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_Kho";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.frm_Kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssachtrongphieunhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluongnhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_dssachtrongphieunhap;
        private System.Windows.Forms.ComboBox cbo_nhacungcap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.ComboBox cbo_khonhap;
        private System.Windows.Forms.ComboBox cbo_nhanvien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cbo_chonsach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_soluongnhap;
        private System.Windows.Forms.TextBox txt_dongianhap;
    }
}