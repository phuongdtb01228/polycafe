using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSLoaiSanPham
    {
        DALLoaiSanPham dalLoaiSanPham = new DALLoaiSanPham();
        public List<LoaiSanPham> GetLoaiSanPhamList()
        {
            return dalLoaiSanPham.selectAll();
        }

        public string InsertLoaiSanPham(LoaiSanPham lsp)
        {
            try
            {
                lsp.MaLoai = dalLoaiSanPham.generateMaThe();
                if (string.IsNullOrEmpty(lsp.MaLoai))
                {
                    return "Mã Loai Không Hợp Lệ.";
                }

                dalLoaiSanPham.insert(lsp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string Update(LoaiSanPham lsp)
        {
            try
            {
                if (string.IsNullOrEmpty(lsp.MaLoai))
                {
                    return "Mã Loai không hợp lệ.";
                }

                dalLoaiSanPham.update(lsp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteThe(string maLoai)
        {
            try
            {
                if (string.IsNullOrEmpty(maLoai))
                {
                    return "Mã Loai không hợp lệ";
                }
                dalLoaiSanPham.delete(maLoai);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
