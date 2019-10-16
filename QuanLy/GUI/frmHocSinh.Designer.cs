namespace QuanLy.GUI
{
    partial class frmHocSinh
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
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtGV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(115, 53);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.ReadOnly = true;
            this.txtMaGV.Size = new System.Drawing.Size(200, 21);
            this.txtMaGV.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "THÔNG TIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "MÃ GIẢNG VIÊN:";
            // 
            // cbMaLop
            // 
            this.cbMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(400, 229);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(127, 21);
            this.cbMaLop.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(353, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 157);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(116, 195);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(200, 21);
            this.txtSDT.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(200, 21);
            this.txtEmail.TabIndex = 36;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(116, 126);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.ReadOnly = true;
            this.txtNgaySinh.Size = new System.Drawing.Size(200, 21);
            this.txtNgaySinh.TabIndex = 35;
            // 
            // txtGV
            // 
            this.txtGV.Location = new System.Drawing.Point(116, 88);
            this.txtGV.Name = "txtGV";
            this.txtGV.ReadOnly = true;
            this.txtGV.Size = new System.Drawing.Size(200, 21);
            this.txtGV.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "MÃ LỚP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "SỐ ĐIỆN THOẠI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "NGÀY SINH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "TÊN GIẢNG VIÊN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 163);
            this.dataGridView1.TabIndex = 42;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(443, 284);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 46;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(309, 284);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(164, 284);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(37, 284);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "KHOA";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(116, 229);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.ReadOnly = true;
            this.txtKhoa.Size = new System.Drawing.Size(200, 21);
            this.txtKhoa.TabIndex = 38;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 488);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbMaLop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "frmHocSinh";
            this.Text = "frmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMaGV;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbMaLop;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtSDT;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNgaySinh;
        public System.Windows.Forms.TextBox txtGV;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnThoat;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtKhoa;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}