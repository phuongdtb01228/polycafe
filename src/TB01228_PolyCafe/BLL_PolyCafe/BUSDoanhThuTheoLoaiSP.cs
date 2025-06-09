using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSDoanhThuTheoLoaiSP
    {
        private DALDoanhThuTheoLoaiSP dal = new DALDoanhThuTheoLoaiSP();

        //public List<DoanhThuTheoLoai> GetThongKeDoanhThu()
        //{
        //    return dal.GetDoanhThuTheoLoai();
        //}
        public List<DoanhThuTheoLoaiSP> GetThongKeDoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoLoaiTheoNgay(tuNgay, denNgay);
        }
        public List<DoanhThuTheoLoaiSP> GetThongKeDoanhThuTheoLoai(string ma, DateTime tuNgay, DateTime denNgay)
        {
            return dal.GetDoanhThuTheoLoai(ma, tuNgay, denNgay);
        }
    }
}
