using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVKTX
{
    internal class KTXDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public KTXDAL ()
        {
            dc = new DataConnection ();
        }

        //Sinh Viên tblSinhVien
        public DataTable getAllSinhVien()
        {
            string sql = "SELECT * FROM tblSinhVien";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            
            return dt;
        }

        public bool InsertSinhVien(tblSinhVien sv)
        {
            string sql = "INSERT INTO tblSinhVien(MSSV, TenSV, SDT, GioiTinh, IDPhong, NgayVao ) VALUES (@MSSV, @TenSV, @SDT, @GioiTinh, @IDPhong, @NgayVao)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MSSV", SqlDbType.NVarChar).Value = sv.MSSV;
                cmd.Parameters.Add("@TenSv", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sv.SDT;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = sv.IDPhong;
                cmd.Parameters.Add("@NgayVao", SqlDbType.NVarChar).Value = sv.NgayVao;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSinhVien(tblSinhVien sv)
        {
            string sql = "UPDATE tblSinhVien SET MSSV = @MSSV, TenSV = @TenSV, SDT = @SDT, GioiTinh = @GioiTinh, IDPhong=@IDPhong, NgayVao=@NgayVao WHERE MSSV = @MSSV";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MSSV", SqlDbType.NVarChar).Value = sv.MSSV;
                cmd.Parameters.Add("@TenSv", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sv.SDT;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = sv.IDPhong;
                cmd.Parameters.Add("@NgayVao", SqlDbType.NVarChar).Value = sv.NgayVao;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool DeleteSinhVien(tblSinhVien sv)
        {
            string sql = "DELETE tblSinhVien WHERE MSSV = @MSSV";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MSSV", SqlDbType.NVarChar).Value = sv.MSSV;
                cmd.ExecuteNonQuery() ;
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public DataTable FindSinhVien(string sv)
        {
            string sql = "SELECT * FROM tblSinhVien WHERE MSSV like %N" + sv + "%' OR TenSv like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //Phòng ktx tblPhongKTX
        public DataTable getAllPhong()
        {
            string sql = "SELECT * FROM tblPhongKTX";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        public bool InsertPhong(tblPhongKTX p)
        {
            string sql = "INSERT INTO tblPhongKTX( IDPhong, IDDayNha, SoLuong, SoLuongToiDa ) VALUES (@IDPhong, @IDDayNha, @SoLuong, @SoLuongToiDa)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = p.IDPhong;
                cmd.Parameters.Add("@IDDayNha", SqlDbType.NVarChar).Value = p.IDDayNha;
                cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = p.SoLuong;
                cmd.Parameters.Add("@SoLuongToiDa", SqlDbType.NVarChar).Value = p.SoLuongToiDa;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdatePhong(tblPhongKTX p)
        {
            string sql = "UPDATE tblPhongKTX SET IDPhong=@IDPhong, IDDayNha=@IDDayNha, SoLuong=@SoLuong, SoLuongToiDa=@SoLuongToiDa WHERE IDPhong=@IDPhong";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = p.IDPhong;
                cmd.Parameters.Add("@IDDayNha", SqlDbType.NVarChar).Value = p.IDDayNha;
                cmd.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = p.SoLuong;
                cmd.Parameters.Add("@SoLuongToiDa", SqlDbType.NVarChar).Value = p.SoLuongToiDa;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool DeletePhong(tblPhongKTX p)
        {
            string sql = "DELETE tblPhongKTX WHERE IDPhong = @IDPhong";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = p.IDPhong;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public DataTable FindPhong(string p)
        {
            string sql = "SELECT * FROM tblPhongKTX WHERE IDPhong like %N" + p + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //Hóa Đơn điện nước tblHoaDon
        public DataTable getAllHoaDon()
        {
            string sql = "SELECT * FROM tblHoaDon";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            return dt;
        }

        public bool InsertHoaDon(tblHoaDon hd)
        {
            string sql = "INSERT INTO tblHoaDon(IDHoaDon, IDPhong, SoDien, SoNuoc, NgayLapPhieu ) VALUES (@IDHoaDon, @IDPHong, @SoDien, @SoNuoc, @NgayLapPhieu)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDHoaDon", SqlDbType.NVarChar).Value = hd.IDHoaDon;
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = hd.IDPhong;
                cmd.Parameters.Add("@SoDien", SqlDbType.NVarChar).Value = hd.SoDien;
                cmd.Parameters.Add("@SoNuoc", SqlDbType.NVarChar).Value = hd.SoNuoc;
                cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.NVarChar).Value = hd.NgayLapPhieu;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdateHoaDon(tblHoaDon hd)
        {
            string sql = "UPDATE tblHoaDon SET IDHoaDon=@IDHoaDon, IDPhong=@IDPhong, SoDien=@SoDien, SoNuoc=@SoNuoc, NgayLapPhieu=@NgayLapPhieu WHERE IDHoaDon=@IDHoaDon";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDHoaDon", SqlDbType.NVarChar).Value = hd.IDHoaDon;
                cmd.Parameters.Add("@IDPhong", SqlDbType.NVarChar).Value = hd.IDPhong;
                cmd.Parameters.Add("@SoDien", SqlDbType.NVarChar).Value = hd.SoDien;
                cmd.Parameters.Add("@SoNuoc", SqlDbType.NVarChar).Value = hd.SoNuoc;
                cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.NVarChar).Value = hd.NgayLapPhieu;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool DeleteHoaDon(tblHoaDon hd)
        {
            string sql = "DELETE tblHoaDon WHERE IDHoaDon = @IDHoaDon";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDHoaDon", SqlDbType.NVarChar).Value = hd.IDHoaDon;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public DataTable FindHoaDon(string hd)
        {
            string sql = "SELECT * FROM tblHoaDon WHERE IDHoaDon like %N" + hd + "%' OR IDPhong like N'%" + hd + "%' OR NgayLapPhieu like N'%";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
