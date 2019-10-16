using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy.DAL
{
    class GiangVien
    {


        DAL.LOPDUNGCHUNG lop = new LOPDUNGCHUNG();

        public int Them(string MAHS, string TENHS, string NGAYSINH, string EMAIL, string SDT, string TENTAIKHOAN, string MAMH, string MALOP,string HINH)
        {

            string sql = "Insert into HOCSINH values(N'"+MAHS+"',N'"+TENHS +"',N'"+NGAYSINH+"',N'"+EMAIL+"',N'"+SDT+"',N'"+TENTAIKHOAN+"','"+MAMH+"',N'"+MALOP+"',N'"+HINH+"')";


            return lop.ExecuteNonquery(sql);

        }

        public int Sua(string MAHS, string TENHS, string NGAYSINH, string EMAIL, string SDT, string TENTAIKHOAN, string MAMH, string MALOP, string HINH)
        {
            string sql = "Update HOCSINH set TENHS=N'"+TENHS+"',NGAYSINH=N'"+NGAYSINH+"',EMAIL=N'"+EMAIL+"',SDT=N'"+SDT+"',"+
                "MAMH='"+MAMH+"',MALOP=N'"+MALOP+"',HINH=N'"+HINH+"' where MAHS='"+MAHS+ "' and TENTAIKHOAN=N'"+TENTAIKHOAN+"'";

            return lop.ExecuteNonquery(sql);
        }

        public int Xoa(string MAHS)
        {

            string sql = "Delete HOCSINH where MAHS='"+MAHS+"'";

            return lop.ExecuteNonquery(sql);
        }
        public DataTable LoadData()
        {
            string sql = "Select * from HOCSINH";
            return lop.LoadData(sql);
        }
        public int ThemTK(string tk)
        {
            DataTable table = lop.LoadData("select *from TAIKHOAN");

            int id = table.Rows.Count+1;
            string sql = "insert into TAIKHOAN values('"+id+"','"+tk+"','1','1')";
            return lop.ExecuteNonquery(sql);
        }
        public int XoaTK(string tk)
        {
            string sql = "Delete TAIKHOAN where TENTAIKHOAN='"+tk+"'";
            return lop.ExecuteNonquery(sql);
        }
      
    }
}
