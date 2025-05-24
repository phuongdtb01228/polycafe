using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe
{
    public class DALNhanVien
    {
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email =@0 AND MatKhau =@1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            NhanVien nv = DBUtil.Value<NhanVien>(sql, thamSo);
            return nv;
        }


        public void CapNhatMatKhau (string password, string email)
        {
            try
            {
                string sql = "UPDATE NhanVien SET MatKhau = @0 WHERE EMAIL = @1 ";
                List<object> thamSo = new List<object>();
                thamSo.Add(password);
                thamSo.Add(email);
                DBUtil.Update(sql, thamSo);
            }
            catch(Exception ex)
            {
                throw ;
            }
        }

        public void insert(NhanVien nv)
        {
            string sql = "INSERT INTO NhanVien (MaNhanVien, HoTen, Email, MatKhau, VaiTro, TrangThai) " +
                         "VALUES (@0, @1, @2, @3, @4, @5)";

            List<object> thamSo = new List<object>();
            thamSo.Add(nv.MaNhanVien);
            thamSo.Add(nv.HoTen);
            thamSo.Add(nv.Email);
            thamSo.Add(nv.MatKhau);
            thamSo.Add(nv.VaiTro);
            thamSo.Add(nv.TrangThai);

            DBUtil.Update(sql, thamSo);
        }

        public void update(NhanVien nv)
        {
            string sql = "UPDATE NhanVien " +
                "SET HoTen=@1, Email=@2, MatKhau=@3, VaiTro=@4, TrangThai=@5 WHERE MaNhanVien=@0";

            List<object> thamSo = new List<object>();
            thamSo.Add(nv.MaNhanVien);     // @0
            thamSo.Add(nv.HoTen);          // @1
            thamSo.Add(nv.Email);        // @2
            thamSo.Add(nv.MatKhau);          // @3
            thamSo.Add(nv.VaiTro);         // @4
            thamSo.Add(nv.TrangThai);      // @5
           

            DBUtil.Update(sql, thamSo);
        }

        public void deleteNhanVien(string maNV)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maNV);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public List<NhanVien> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVien> list = new List<NhanVien>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNhanVien = reader.GetString("MaNhanVien");
                    nv.HoTen = reader.GetString("HoTen");
                    nv.Email = reader.GetString("Email");
                    nv.MatKhau = reader.GetString("MatKhau");
                    nv.VaiTro = reader.GetBoolean("VaiTro");
                    nv.TrangThai = reader.GetBoolean("TrangThai");

                    list.Add(nv);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        public  List<NhanVien> selectAll()
        {
            string sql = "SELECT * FROM NhanVien";
            return selectBySql(sql, new List<Object>());
        }
        public  NhanVien selectById(string id)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNhanVien=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);

            List<NhanVien> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public string generateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MAX(MaNhanVien) FROM NhanVien";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public bool checkEmail(string email)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE EMAIL =@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            object result = DBUtil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }
    }

}

