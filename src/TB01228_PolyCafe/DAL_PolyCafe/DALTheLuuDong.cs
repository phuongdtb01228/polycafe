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
            string sql = "SELECT * FROM TheLuuDong WHERE MaThe=@0";
            List<Object> thamSo = new List<Object>();
            thamSo.Add(id);

            List<TheLuuDong> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insert(TheLuuDong tld)
        {
            string sql = "INSERT INTO TheLuuDong (MaThe, ChuSoHuu, TrangThai) " +
                         "VALUES (@0, @1, @2)";

            List<object> thamSo = new List<object>();
            thamSo.Add(tld.MaThe);
            thamSo.Add(tld.ChuSoHuu);
            thamSo.Add(tld.TrangThai);

            DBUtil.Update(sql, thamSo);
        }

        public void update(TheLuuDong tld)
        {
            string sql = "UPDATE TheLuuDong " +
                "SET ChuSoHuu=@1, TrangThai=@2 WHERE MaThe=@0";

            List<object> thamSo = new List<object>();
            thamSo.Add(tld.MaThe);     // @0
            thamSo.Add(tld.ChuSoHuu);          // @1
            thamSo.Add(tld.TrangThai);        // @2
            DBUtil.Update(sql, thamSo);
        }

        public void delete(string maThe)
        {
            try
            {
                string sql = "DELETE FROM TheLuuDong WHERE MaThe = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maThe);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public string generateMaThe()
        {
            string prefix = "THE";
            string sql = "SELECT MAX(MaThe) FROM TheLuuDong";
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

        public bool checkChuSoHuu(string chusohuu)
        {
            string sql = "SELECT COUNT(*) FROM TheLuuDong WHERE ChuSoHuu =@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(chusohuu);
            object result = DBUtil.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }

    }
}
