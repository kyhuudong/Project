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
using System.Data.SqlClient;

namespace QuanLy.GUI
{
    public partial class frmDSHocSinh : DevExpress.XtraEditors.XtraForm
    {
        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();
        BLL.GiangVien BllGV;
        
        public frmDSHocSinh()
        {
            InitializeComponent();
            BllGV = new BLL.GiangVien(this);
        }
       
        private void frmDSHocSinh_Load(object sender, EventArgs e)
        {
            
        }

        public void HienThi()
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMAHS.Text = dataGridView1.CurrentRow.Cells["MAHS"].Value.ToString();
                txtHS.Text = dataGridView1.CurrentRow.Cells["TENHS"].Value.ToString();
                txtNgaySinh.Text = dataGridView1.CurrentRow.Cells["NGAYSINH"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["EMAIL"].Value.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells["SDT"].Value.ToString();
                txtTK.Text = dataGridView1.CurrentRow.Cells["TENTAIKHOAN"].Value.ToString();
                txtMaMonHoc.Text = dataGridView1.CurrentRow.Cells["MAMH"].Value.ToString();

                cbMaLop.SelectedValue = dataGridView1.CurrentRow.Cells["MALOP"].Value.ToString();

                pictureBox1.Image = Image.FromFile(@"D:\DEV express\QuanLy\Image\"+dataGridView1.CurrentRow.Cells[8].Value.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frm_Them frmThem = new frm_Them();
            frmThem.Show();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSua frmsua = new frmSua();
            frmsua.txtMAHS.Text = txtMAHS.Text;
            frmsua.txtTK.Text = txtTK.Text;
            frmsua.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BllGV.Xoa();
        }
    }
}