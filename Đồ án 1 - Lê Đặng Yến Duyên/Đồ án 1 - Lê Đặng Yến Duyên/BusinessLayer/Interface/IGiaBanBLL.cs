using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;


namespace DOAN1.BusinessLayer
{
    public interface IGiaBanBLL
    {
        List<giaban> GetAllGiaban();
        void Themgiaban(giaban gb);
        void Suagiaban(giaban gb);
        void Xoagiaban(string mahang);
        List<giaban> Timgiaban(giaban gb);
    }
}
