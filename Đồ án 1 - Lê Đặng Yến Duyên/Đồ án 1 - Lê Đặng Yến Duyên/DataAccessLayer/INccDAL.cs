using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCC.Entities;

namespace NCC.DataAccessLayer
{
    public interface INccDAL
    {
        List<ncc> GetAllNcc();
        void ThemNcc(ncc cc);
        void Update(List<ncc> list);
    }
}
