using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    
    public class BUSTheLuuDong
    {
        DALTheLuuDong dalTheLuuDong = new DALTheLuuDong();
        public List<TheLuuDong> GetTheLuuDongList()
        {
            return dalTheLuuDong.selectAll();
        }

        public string InsertTheLuuDong(TheLuuDong tld)
        {
            try
            {
                tld.MaThe = dalTheLuuDong.generateMaThe();
                if (string.IsNullOrEmpty(tld.MaThe))
                {
                    return "Mã Thẻ Không Hợp Lệ.";
                }
                
                dalTheLuuDong.insert(tld);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string Update(TheLuuDong tld)
        {
            try
            {
                if (string.IsNullOrEmpty(tld.MaThe))
                {
                    return "Mã Thẻ không hợp lệ.";
                }

                dalTheLuuDong.update(tld);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteThe(string maThe)
        {
            try
            {
                if (string.IsNullOrEmpty(maThe))
                {
                    return "Mã nhân viên không hợp lệ";
                }
                dalTheLuuDong.delete(maThe);
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
