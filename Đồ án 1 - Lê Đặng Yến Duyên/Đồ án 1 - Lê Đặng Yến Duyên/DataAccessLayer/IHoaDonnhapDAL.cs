using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public interface IHoaDonnhapDAL
    {
        List<hoadonNhap> GetAllHoaDonnhap();
        void ThemHoaDonnhap(hoadonNhap hdn);
        void Update(List<hoadonNhap> list);
    }
}
