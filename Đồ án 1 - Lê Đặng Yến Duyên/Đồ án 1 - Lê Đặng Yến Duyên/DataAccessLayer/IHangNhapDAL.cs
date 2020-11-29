using System;
using System.Collections.Generic;
using System.Text;
using HangNhap.Entities;

namespace HangNhap.DataAccessLayer
{
    public interface IHangNhapDAL
    {
        List<hangNhap> GetAllHangnhap();
        void ThemHangnhap(hangNhap hn);
        void Update(List<hangNhap> list);
    }
}
