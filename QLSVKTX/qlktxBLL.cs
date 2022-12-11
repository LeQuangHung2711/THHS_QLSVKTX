using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVKTX
{
    internal class qlktxBLL
    {
        KTXDAL dalKTX;
        public qlktxBLL()
        {
            dalKTX = new KTXDAL();
        }
        //Sinh Vien
        public DataTable getAllSinhVien()
        {
            return dalKTX.getAllSinhVien();
        }
        public bool InsertSinhVien(tblSinhVien sv)
        {
            return dalKTX.InsertSinhVien(sv);
        }
        public bool UpdateSinhVien(tblSinhVien sv)
        {
            return dalKTX.UpdateSinhVien(sv);
        }
        public bool DeleteSinhVien(tblSinhVien sv)
        {
            return dalKTX.DeleteSinhVien(sv);
        }
        public DataTable FindSinhVien(string sv)
        {
            return dalKTX.FindSinhVien(sv);
        }

        // Phong
        public DataTable getAllPhong()
        {
            return dalKTX.getAllPhong();
        }
        public bool InsertPhong(tblPhongKTX p)
        {
            return dalKTX.InsertPhong(p);
        }
        public bool UpdatePhong(tblPhongKTX p)
        {
            return dalKTX.UpdatePhong(p);
        }
        public bool DeletePhong(tblPhongKTX p)
        {
            return dalKTX.DeletePhong(p);
        }
        public DataTable FindPhong(string p)
        {
            return dalKTX.FindPhong(p);
        }

        // Hóa Đơn
        public DataTable getAllHoaDon()
        {
            return dalKTX.getAllHoaDon();
        }
        public bool InsertHoaDon(tblHoaDon hd)
        {
            return dalKTX.InsertHoaDon(hd);
        }
        public bool UpdateHoaDon(tblHoaDon hd)
        {
            return dalKTX.UpdateHoaDon(hd);
        }
        public bool DeleteHoaDon(tblHoaDon hd)
        {
            return dalKTX.DeleteHoaDon(hd);
        }
        public DataTable FindHoaDon(string hd)
        {
            return dalKTX.FindHoaDon(hd);
        }
    }
}
