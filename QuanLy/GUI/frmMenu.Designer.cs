﻿namespace QuanLy.GUI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTenn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMm = new System.Windows.Forms.Label();
            this.lblTEN = new System.Windows.Forms.Label();
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMA = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 147);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // lblTenn
            // 
            this.lblTenn.AutoSize = true;
            this.lblTenn.Location = new System.Drawing.Point(131, 12);
            this.lblTenn.Name = "lblTenn";
            this.lblTenn.Size = new System.Drawing.Size(33, 13);
            this.lblTenn.TabIndex = 3;
            this.lblTenn.Text = "TÊN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TÀI KHOẢN:";
            // 
            // lblMm
            // 
            this.lblMm.AutoSize = true;
            this.lblMm.Location = new System.Drawing.Point(131, 95);
            this.lblMm.Name = "lblMm";
            this.lblMm.Size = new System.Drawing.Size(35, 13);
            this.lblMm.TabIndex = 5;
            this.lblMm.Text = "label3";
            // 
            // lblTEN
            // 
            this.lblTEN.AutoSize = true;
            this.lblTEN.Location = new System.Drawing.Point(236, 9);
            this.lblTEN.Name = "lblTEN";
            this.lblTEN.Size = new System.Drawing.Size(35, 13);
            this.lblTEN.TabIndex = 6;
            this.lblTEN.Text = "label4";
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Location = new System.Drawing.Point(236, 54);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(35, 13);
            this.lblTK.TabIndex = 7;
            this.lblTK.Text = "label5";
            // 
            // lblMA
            // 
            this.lblMA.AutoSize = true;
            this.lblMA.Location = new System.Drawing.Point(236, 95);
            this.lblMA.Name = "lblMA";
            this.lblMA.Size = new System.Drawing.Size(35, 13);
            this.lblMA.TabIndex = 8;
            this.lblMA.Text = "label4";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(91, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã lớp :";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(196, 180);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 261);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMA);
            this.Controls.Add(this.lblTK);
            this.Controls.Add(this.lblTEN);
            this.Controls.Add(this.lblMm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTenn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTenn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMm;
        private System.Windows.Forms.Label lblTEN;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMA;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}