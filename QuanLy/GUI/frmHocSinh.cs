using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLy.GUI
{
    public partial class frmHocSinh : DevExpress.XtraEditors.XtraForm
    {
        
        public frmHocSinh()
        {
            InitializeComponent();
        
            
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            
        }

        public void HienThi()
        {
            txtMaGV.Text = dataGridView1.CurrentRow.Cells["MAGV"].Value.ToString();
            txtGV.Text = dataGridView1.CurrentRow.Cells["TENGV"].Value.ToString();
            txtNgaySinh.Text = dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
            txtKhoa.Text = dataGridView1.CurrentRow.Cells["KHOA"].Value.ToString();
            cbMaLop.SelectedValue = dataGridView1.CurrentRow.Cells["MALOP"].Value.ToString();

            pictureBox1.Image = Image.FromFile(@"D:\DEV express\QuanLy\Image\"+dataGridView1.CurrentRow.Cells["HINH"].Value.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            


        }
    }
}