using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.BusinessLayer
{
    public interface IHangHoaBLL
    {
        List<hanghoa> GetAllHanghoa();
        void ThemHanghoa(hanghoa hh);
        void SuaHanghoa(hanghoa hh);
        void XoaHanghoa(string mahang);
        List<hanghoa> TimHanghoa(hanghoa hh);
    }
}
