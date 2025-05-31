using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe
{
    public class DALLoaiSanPham
    {
        public List<LoaiSanPham> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.MaLoai = reader.GetString("MaLoai");
                    lsp.TenLoai = reader.GetString("TenLoai");
                    lsp.GhiChu = reader.GetString("GhiChu");

                    list.Add(lsp);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        public List<LoaiSanPham> selectAll()
        {
            string sql = "SELECT * FROM LoaiSanPham";
            return selectBySql(sql, new List<Object>());
        }
        public LoaiSanPham selectById(string id)
        {
            string sql = "SELECT * FROM LoaiSanPham WHERE MaLoai=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);

            List<LoaiSanPham> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insert(LoaiSanPham lsp)
        {
            string sql = "INSERT INTO LoaiSanPham (MaLoai, TenLoai, GhiChu) " +
                        "VALUES (@0, @1, @2)";

            List<object> thamSo = new List<object>();
            thamSo.Add(lsp.MaLoai);
            thamSo.Add(lsp.TenLoai);
            thamSo.Add(lsp.GhiChu);

            DBUtil.Update(sql, thamSo);
        }

        public void update(LoaiSanPham lsp)
        {
            string sql = "UPDATE LoaiSanPham " +
                "SET TenLoai=@1, GhiChu=@2 WHERE MaLoai=@0";

            List<object> thamSo = new List<object>();
            thamSo.Add(lsp.MaLoai);     // @0
            thamSo.Add(lsp.TenLoai);          // @1
            thamSo.Add(lsp.GhiChu);        // @2
            DBUtil.Update(sql, thamSo);
        }

        public void delete(string maLoai)
        {
            try
            {
                string sql = "DELETE FROM LoaiSanPham WHERE MaLoai = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maLoai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string generateMaThe()
        {
            string prefix = "LSP";
            string sql = "SELECT MAX(MaLoai) FROM LoaiSanPham";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(3);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

       

    }
}
