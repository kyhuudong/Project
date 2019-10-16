using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy.DAL
{
    class HocSinh
    {
        DAL.LOPDUNGCHUNG lop = new DAL.LOPDUNGCHUNG();
        public int Them(string MAHS,string TENHS,string NGAYSINH,string EMAIL,string SDT,string TENTAIKHOAN,string MAMH,string MALOP,string HINH)
        {
            string sql = "insert into HOCSINH values (N'"+TENHS+"',N'"+NGAYSINH+"',N'"+EMAIL+"','"+SDT+"',N'"+TENTAIKHOAN+"',N'"+MAMH+"',N'"+MALOP+"',N'"+HINH+"'";
            return lop.ExecuteNonquery(sql);
        }
        public int xoa(string MAHS)
        {
            string sql="delete HOCSINH where MAHS='"+MAHS+"'";
            return lop.ExecuteNonquery(sql);
        }
        public int sua(string MAHS, string TENHS, string NGAYSINH, string EMAIL, string SDT, string TENTAIKHOAN, string MAMH, string MALOP, string HINH)
        {
            string sql = "updete HOCSINH set TENHS=N'"+TENHS+"',NGAYSINH=N'"+NGAYSINH+"',EMAIL=N'"+EMAIL+"',SDT=N'"+SDT+"',TENTAIKHOAN=N'"+TENTAIKHOAN+"',MAMH=N'"+MAMH+"',MALOP=N'"+MALOP+"',HINH=N'"+HINH+"' where MAHS='"+MAHS+"'";
            return lop.ExecuteNonquery(sql);
        }
        public DataTable loadSV()
        {
            string sql = "select * from HOCSINH";
            return lop.LoadData(sql);
        }
        
    }
}
