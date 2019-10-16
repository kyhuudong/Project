using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.BLL
{
    class GiangVien
    {

        GUI.frm_Them frmThem;

        GUI.frmSua frmSua;
        GUI.frmDSHocSinh frmDSHS;
        DAL.GiangVien dalGV = new DAL.GiangVien();


        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
        + @"\Image\";

        public GiangVien(GUI.frm_Them frmThem)
        {
            this.frmThem = frmThem;
        }

        public GiangVien(GUI.frmSua frmSua)
        {
            this.frmSua = frmSua;
        }
        public GiangVien(GUI.frmDSHocSinh frmDSHS)
        {
            this.frmDSHS = frmDSHS;
        }

        public void Them()
        {

            try
            {
                int ketqua1 = dalGV.ThemTK(frmThem.txtTK.Text);
                int ketqua = dalGV.Them(frmThem.txtMAHS.Text, frmThem.txtHS.Text, frmThem.txtNgaySinh.Text, frmThem.txtEmail.Text, frmThem.txtSDT.Text, frmThem.txtTK.Text, frmThem.txtMaMonHoc.Text, frmThem.cbMaLop.SelectedValue.ToString(), frmThem.txtHinh.Text);

                if (ketqua >= 1 && ketqua1 >= 1)
                {
                    MessageBox.Show("Them thanh cong");                   
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Xoa()
        {
            try
            {
                int ketqua1 = dalGV.XoaTK(frmDSHS.txtTK.Text);
                int ketqua = dalGV.Xoa(frmDSHS.txtMAHS.Text);
                if (ketqua >= 1 && ketqua1 >= 1)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Sua()
        {
            try
            {
                int ketqua = dalGV.Sua(frmSua.txtMAHS.Text, frmSua.txtHS.Text, frmSua.txtNgaySinh.Text, frmSua.txtEmail.Text, frmSua.txtSDT.Text, frmSua.txtTK.Text, frmSua.txtMaMonHoc.Text, frmSua.cbMaLop.SelectedValue.ToString(), frmSua.txtHinh.Text);
                if (ketqua >= 1)
                {
                    MessageBox.Show("Sua thanh cong");

                }
                else
                {
                    MessageBox.Show("Sua that bai");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
    
