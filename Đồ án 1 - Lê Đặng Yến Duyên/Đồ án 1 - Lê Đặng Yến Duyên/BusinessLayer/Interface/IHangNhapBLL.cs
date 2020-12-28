using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.BusinessLayer
{
    public interface IHangNhapBLL
    {
        List<hangNhap> GetAllHangnhap();
        void ThemHangnhap(hangNhap hn);
        void SuaHangnhap(hangNhap hn);
        void XoaHangnhap(string mahn);
        List<hangNhap> TimHangnhap(hangNhap hn);
    }
}
