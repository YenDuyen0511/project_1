﻿using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;

namespace DOAN1.BusinessLayer
{
    public interface ILoaiHangBLL
    {
        List<loaihang> GetAllLoaihang();
        void ThemLoaihang(loaihang lh);
        void SuaLoaihang(loaihang lh);
        void XoaLoaihang(string maloai);
        List<loaihang> TimLoaihang(loaihang lh);
    }
}
