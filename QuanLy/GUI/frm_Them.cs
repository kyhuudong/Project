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
    public partial class frm_Them : DevExpress.XtraEditors.XtraForm
    {
        BLL.GiangVien bllGV;

        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();


        public void LoadCombobox()
        {
            string sql = "select * from LOP";
            DataTable dt = lop.LoadData(sql);
            cbMaLop.DataSource = dt;
            cbMaLop.DisplayMember = "TENLOP";
            cbMaLop.ValueMember = "MALOP";
        }
        public frm_Them()
        {
            InitializeComponent();
            bllGV = new BLL.GiangVien(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bllGV.Them();
        }

        private void frm_Them_Load(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hay cho anh";
            open.Filter = "JEPG|*.JEPG|BMP|*.bmp|Tất cả ảnh|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
    }
}