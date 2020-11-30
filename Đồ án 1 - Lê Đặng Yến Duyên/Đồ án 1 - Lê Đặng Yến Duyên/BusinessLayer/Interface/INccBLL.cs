using System;
using System.Collections.Generic;
using System.Text;
using NCC.Entities;


namespace NCC.BusinessLayer
{
    public interface INccBLL
    {
        List<ncc> GetAllNcc();
        void ThemNcc(ncc cc);
        void SuaNcc(ncc cc);
        void XoaNcc(string mancc);
        List<ncc> TimNcc(ncc cc);
    }
}
