﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public bool VaiTro { get; set; }
        public bool TrangThai { get; set; }

        public string VaiTroText => VaiTro ? "Quản Lý" : "NhânViên";
        public string TrangThaiText => TrangThai ? "Hoạt Động" : "Ngừng Hoạt Động";
    }


}
