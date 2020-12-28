using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    public interface IGiaBanDAL
    {
        List<giaban> GetAllGiaban();
        void Themgiaban(giaban gb);
        void Update(List<giaban> list);
    }
}
