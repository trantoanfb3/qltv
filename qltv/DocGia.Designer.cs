namespace qltv
{
    partial class frm_DocGia
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_docgia = new System.Windows.Forms.ComboBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_tendangnhap = new System.Windows.Forms.TextBox();
            this.chk_trangthai = new System.Windows.Forms.CheckBox();
            this.btn_taotaikhoan = new System.Windows.Forms.Button();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_khoamotaikhoan = new System.Windows.Forms.Button();
            this.dgv_taikhoandocgia = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoandocgia)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1272, 634);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1266, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản Độc Giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_trangthai);
            this.groupBox1.Controls.Add(this.txt_tendangnhap);
            this.groupBox1.Controls.Add(this.txt_matkhau);
            this.groupBox1.Controls.Add(this.cbo_docgia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tài Khoản Độc Giả";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lammoi);
            this.groupBox2.Controls.Add(this.btn_khoamotaikhoan);
            this.groupBox2.Controls.Add(this.btn_doimatkhau);
            this.groupBox2.Controls.Add(this.btn_taotaikhoan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1266, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao Tác";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_taikhoandocgia);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1266, 270);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Tài Khoản Độc Giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Độc Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(611, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng Thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên Đăng Nhập";
            // 
            // cbo_docgia
            // 
            this.cbo_docgia.FormattingEnabled = true;
            this.cbo_docgia.Location = new System.Drawing.Point(177, 30);
            this.cbo_docgia.Name = "cbo_docgia";
            this.cbo_docgia.Size = new System.Drawing.Size(381, 33);
            this.cbo_docgia.TabIndex = 4;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(177, 96);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(381, 30);
            this.txt_matkhau.TabIndex = 5;
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Location = new System.Drawing.Point(794, 27);
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.Size = new System.Drawing.Size(381, 30);
            this.txt_tendangnhap.TabIndex = 6;
            // 
            // chk_trangthai
            // 
            this.chk_trangthai.AutoSize = true;
            this.chk_trangthai.Location = new System.Drawing.Point(794, 102);
            this.chk_trangthai.Name = "chk_trangthai";
            this.chk_trangthai.Size = new System.Drawing.Size(131, 29);
            this.chk_trangthai.TabIndex = 7;
            this.chk_trangthai.Text = "checkBox1";
            this.chk_trangthai.UseVisualStyleBackColor = true;
            // 
            // btn_taotaikhoan
            // 
            this.btn_taotaikhoan.Location = new System.Drawing.Point(43, 41);
            this.btn_taotaikhoan.Name = "btn_taotaikhoan";
            this.btn_taotaikhoan.Size = new System.Drawing.Size(217, 53);
            this.btn_taotaikhoan.TabIndex = 0;
            this.btn_taotaikhoan.Text = "Tạo Tài Khoản";
            this.btn_taotaikhoan.UseVisualStyleBackColor = true;
            this.btn_taotaikhoan.Click += new System.EventHandler(this.btn_taotaikhoan_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Location = new System.Drawing.Point(357, 41);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(217, 53);
            this.btn_doimatkhau.TabIndex = 1;
            this.btn_doimatkhau.Text = "Đổi Mật Khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(990, 41);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(217, 53);
            this.btn_lammoi.TabIndex = 3;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_khoamotaikhoan
            // 
            this.btn_khoamotaikhoan.Location = new System.Drawing.Point(676, 41);
            this.btn_khoamotaikhoan.Name = "btn_khoamotaikhoan";
            this.btn_khoamotaikhoan.Size = new System.Drawing.Size(217, 53);
            this.btn_khoamotaikhoan.TabIndex = 2;
            this.btn_khoamotaikhoan.Text = "Khóa/Mở Tài Khoản";
            this.btn_khoamotaikhoan.UseVisualStyleBackColor = true;
            // 
            // dgv_taikhoandocgia
            // 
            this.dgv_taikhoandocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_taikhoandocgia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_taikhoandocgia.Location = new System.Drawing.Point(3, 26);
            this.dgv_taikhoandocgia.Name = "dgv_taikhoandocgia";
            this.dgv_taikhoandocgia.RowHeadersWidth = 51;
            this.dgv_taikhoandocgia.RowTemplate.Height = 24;
            this.dgv_taikhoandocgia.Size = new System.Drawing.Size(1260, 241);
            this.dgv_taikhoandocgia.TabIndex = 0;
            this.dgv_taikhoandocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_taikhoandocgia_CellClick);
            // 
            // frm_DocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_DocGia";
            this.Text = "DocGia";
            this.Load += new System.EventHandler(this.frm_DocGia_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_taikhoandocgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_trangthai;
        private System.Windows.Forms.TextBox txt_tendangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.ComboBox cbo_docgia;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_khoamotaikhoan;
        private System.Windows.Forms.Button btn_doimatkhau;
        private System.Windows.Forms.Button btn_taotaikhoan;
        private System.Windows.Forms.DataGridView dgv_taikhoandocgia;
    }
}