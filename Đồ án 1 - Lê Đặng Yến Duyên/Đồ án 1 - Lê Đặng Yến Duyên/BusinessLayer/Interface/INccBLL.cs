using System;
using System.Collections.Generic;
using System.Text;
using DOAN1.Entities;


namespace DOAN1.BusinessLayer
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
