namespace QuanLy.GUI
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.aaaa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // aaaa
            // 
            this.aaaa.AutoSize = true;
            this.aaaa.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaaa.Location = new System.Drawing.Point(12, 27);
            this.aaaa.Name = "aaaa";
            this.aaaa.Size = new System.Drawing.Size(162, 25);
            this.aaaa.TabIndex = 0;
            this.aaaa.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(180, 34);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(186, 21);
            this.txtTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(180, 74);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(186, 21);
            this.txtMatKhau.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.Location = new System.Drawing.Point(180, 111);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDangNhap.Size = new System.Drawing.Size(38, 31);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Click += new System.EventHandler(this.simpleButton1_Click);
            this.btnDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDangNhap_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(239, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 171);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aaaa);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aaaa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}