using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public interface IHangNhapDAL
    {
        List<hangNhap> GetAllHangnhap();
        void ThemHangnhap(hangNhap hn);
        void Update(List<hangNhap> list);
    }
}
