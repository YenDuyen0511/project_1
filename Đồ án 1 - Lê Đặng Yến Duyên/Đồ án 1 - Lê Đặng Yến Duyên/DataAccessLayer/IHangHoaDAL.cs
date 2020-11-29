using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangHoa.Entities;

namespace HangHoa.DataAccessLayer
{
    public interface IHangHoaDAL
    {
        List<hanghoa> GetAllHanghoa();
        void ThemHanghoa(hanghoa hh);
        void Update(List<hanghoa> list);
    }
}
