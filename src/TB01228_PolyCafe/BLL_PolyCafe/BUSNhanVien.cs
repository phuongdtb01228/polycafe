using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSNhanVien
    {
        DALNhanVien dalNhanVien = new DALNhanVien();
        public NhanVien DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            return dalNhanVien.getNhanVien(username, password);
        }

        public bool UpdateMatKhau(string email, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    return false;
                }
                dalNhanVien.CapNhatMatKhau(password, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<NhanVien> GetNhanVienList()
        {
            return dalNhanVien.selectAll();
        }

        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                nv.MaNhanVien = dalNhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã Nhân Viên Không Hợp Lệ.";
                }
                if (dalNhanVien.checkEmail(nv.Email))
                {
                    return "Email Đã Tồn Tại.";
                }
                dalNhanVien.insert(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string Update(NhanVien nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalNhanVien.update(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ";
                }
                dalNhanVien.deleteNhanVien(maNV);
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

    
