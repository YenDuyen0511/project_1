using System;
using System.Collections.Generic;
using System.Text;
using HangNhap.Entities;

namespace HangNhap.BusinessLayer
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
