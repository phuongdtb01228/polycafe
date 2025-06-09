using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_PolyCafe;
using Microsoft.Data.SqlClient;

namespace DAL_PolyCafe
{
    public class DALDoanhThuTheoNV
    {
        public List<DoanhThuTheoNV> GetDoanhThuTheoNhanVien(string maNV, DateTime tuNgay, DateTime denNgay)
        {
            List<DoanhThuTheoNV> list = new List<DoanhThuTheoNV>();
            string sql = @"
                SELECT nv.HoTen, SUM(ctp.SoLuong * ctp.DonGia) AS TongDoanhThu
                FROM ChiTietPhieu ctp
                JOIN PhieuBanHang pbh ON ctp.MaPhieu = pbh.MaPhieu
                JOIN NhanVien nv ON pbh.MaNhanVien = nv.MaNhanVien
                WHERE (@0 = '' OR nv.MaNhanVien = @0)
                  AND pbh.NgayTao BETWEEN @1 AND @2
                GROUP BY nv.HoTen";

            List<object> parameters = new List<object> { maNV, tuNgay, denNgay };
            SqlDataReader reader = DBUtil.Query(sql, parameters);

            while (reader.Read())
            {
                DoanhThuTheoNV item = new DoanhThuTheoNV
                {
                    HoTen = reader["HoTen"].ToString(),
                    DoanhThu = reader.GetDecimal(reader.GetOrdinal("TongDoanhThu"))
                };
                list.Add(item);
            }

            return list;
        }
    }
}
