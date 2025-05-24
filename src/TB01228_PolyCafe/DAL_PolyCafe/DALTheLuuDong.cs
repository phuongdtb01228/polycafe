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
    public class DALTheLuuDong
    {
        public List<TheLuuDong> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<TheLuuDong> list = new List<TheLuuDong>();

            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    TheLuuDong tld = new TheLuuDong();
                    tld.MaThe = reader.GetString("MaThe");
                    tld.ChuSoHuu = reader.GetString("ChuSoHuu");
                    tld.TrangThai = reader.GetBoolean("TrangThai");

                    list.Add(tld);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return list;
        }

        public List<TheLuuDong> selectAll()
        {
            string sql = "SELECT * FROM TheLuuDong";
            return selectBySql(sql, new List<Object>());
        }
        public TheLuuDong selectById(string id)
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

        
    }
}
