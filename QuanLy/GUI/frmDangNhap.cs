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
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string sql = "select * from TAIKHOAN where TENTAIKHOAN='"+txtTaiKhoan.Text+"' and MATKHAU='"+txtMatKhau.Text+"'";
            DataTable dt = lop.LoadData(sql);
            
            if (dt.Rows.Count > 0)
            {
                frmMenu menu = new frmMenu(dt.Rows[0][1].ToString(),dt.Rows[0][3].ToString());
                

                menu.Show();
                this.Hide();

                
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập","Something wrong");
            }

        }

       

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap.PerformClick();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}