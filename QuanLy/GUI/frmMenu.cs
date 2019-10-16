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
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {
        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();
        string phanquyen;
        string tentaikhoan;
        public frmMenu()
        {
            InitializeComponent();            
        }

        public frmMenu(string tentaikhoan,string phanquyen)
        {
            InitializeComponent();
            this.tentaikhoan = tentaikhoan;
            this.phanquyen = phanquyen;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void LoadComboBox()
        {
            string sql = "select * from LOP";
            comboBox1.DataSource = lop.LoadData(sql);
            comboBox1.DisplayMember = "TENLOP";
            comboBox1.ValueMember = "MALOP";
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            PhanQuyen();
        }



        public void PhanQuyen()
        {

            string sql = "";
            if (phanquyen == "1")
            {
                sql = "select * from HOCSINH where TENTAIKHOAN='"+tentaikhoan+"'";
                DataTable dt = lop.LoadData(sql);
                DataRow dr = dt.Rows[0];
                
                lblTK.Text = Convert.ToString(dr["TENTAIKHOAN"]);

                lblTenn.Text = "TÊN HỌC SINH:";
                lblTEN.Text = Convert.ToString(dr["TENHS"]);
                lblMm.Text = "MÃ HỌC SINH:";
                lblMA.Text = Convert.ToString(dr["MAHS"]);
                pictureBox1.Image = Image.FromFile(@"D:\DEV express\QuanLy\Image\"+Convert.ToString(dr["HINH"]));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                sql = "select * from GIANGVIEN where TENTAIKHOAN='" + tentaikhoan + "'";
                DataTable dt = lop.LoadData(sql);
                DataRow dr = dt.Rows[0];

                lblTK.Text = Convert.ToString(dr["TENTAIKHOAN"]);
                lblTenn.Text = "TÊN GIẢNG VIÊN:";
                lblTEN.Text = Convert.ToString(dr["TENGV"]);
                lblMm.Text = "MÃ GIẢNG VIÊN:";
                lblMA.Text = Convert.ToString(dr["MAGV"]);
                pictureBox1.Image = Image.FromFile(@"D:\DEV express\QuanLy\Image\" + Convert.ToString(dr["HINH"]));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            //Lay gia tri cua ban hoc sinh
            string sqlHS = "select * from HOCSINH";
            DataTable tableHS = lop.LoadData(sqlHS);
            DataRow rowHS = tableHS.Rows[0];

            //Lay gia tri cua ban giang vien
            string sqlGV = "select * from GIANGVIEN";
            DataTable tableGV = lop.LoadData(sqlGV);
            DataRow rowGV = tableGV.Rows[0];
            


            try
            {
                //Phan quyen giao vien
                if (phanquyen == "2")
                {
                    string q = "select * from HOCSINH where MALOP='"+comboBox1.SelectedValue.ToString()+"'";

                    
                    DataTable dt = lop.LoadData(q);

                    GUI.frmDSHocSinh dsHS = new GUI.frmDSHocSinh();

                    //Combobox
                    string commandLOP = "select * from LOP";
                    dsHS.cbMaLop.DataSource = lop.LoadData(commandLOP);
                    dsHS.cbMaLop.DisplayMember = "TENLOP";
                    dsHS.cbMaLop.ValueMember = "MALOP";


                    dsHS.dataGridView1.DataSource = dt;
                    

                    dsHS.Show();

                }
                //Phan quyen hoc sinh
                else
                {
                    

                    //Truyen tham du lieu datagridview cho frmHocSinh
                    string commandDIEM = "select * from DIEM where MAHS='"+lblMA.Text+"'";
                    DataTable tableDIEM = lop.LoadData(commandDIEM);


                    //Truyen tham du lieu text cho frmHocSinh
                    string commandGIANGVIEN = "select * from GIANGVIEN where MALOP='"+comboBox1.SelectedValue+"'";
                    DataTable tableGIANGVIEN = lop.LoadData(commandGIANGVIEN);
                    DataRow drGIANGVIEN = tableGIANGVIEN.Rows[0];



                    GUI.frmHocSinh dsTTHS = new GUI.frmHocSinh();

                    //Combobox
                    string commandLOP = "select * from LOP";
                    dsTTHS.cbMaLop.DataSource = lop.LoadData(commandLOP);
                    dsTTHS.cbMaLop.DisplayMember = "TENLOP";
                    dsTTHS.cbMaLop.ValueMember = "MALOP";

                    //THONG TIN
                    dsTTHS.txtMaGV.Text = Convert.ToString(drGIANGVIEN["MAGV"]);
                    dsTTHS.txtGV.Text = Convert.ToString(drGIANGVIEN["TENGV"]);
                    dsTTHS.txtNgaySinh.Text = Convert.ToString(drGIANGVIEN["NGAYSINH"]);
                    dsTTHS.txtEmail.Text = Convert.ToString(drGIANGVIEN["EMAIL"]);
                    dsTTHS.txtSDT.Text = Convert.ToString(drGIANGVIEN["SDT"]);
                    dsTTHS.txtKhoa.Text = Convert.ToString(drGIANGVIEN["KHOA"]);
                    

                    //ANH
                    dsTTHS.pictureBox1.Image = Image.FromFile(@"D:\DEV express\QuanLy\Image\"+Convert.ToString(drGIANGVIEN["HINH"]));
                    dsTTHS.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    //Datagridview cua HOC SINH
                    dsTTHS.dataGridView1.DataSource = tableDIEM;

                    dsTTHS.Show();
                  
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI.frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }
    }
}