using System;
using System.Collections.Generic;
using System.Text;
using HangHoa.Entities;

namespace HangHoa.BusinessLayer
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
