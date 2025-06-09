using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSDoanhThuTheoNV
    {
        DALDoanhThuTheoNV dal = new DALDoanhThuTheoNV();

        public List<DoanhThuTheoNV> GetThongKeDoanhThuTheoNhanVien(string maNV, DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoNhanVien(maNV, tuNgay, denNgay);
        }
    }
}
