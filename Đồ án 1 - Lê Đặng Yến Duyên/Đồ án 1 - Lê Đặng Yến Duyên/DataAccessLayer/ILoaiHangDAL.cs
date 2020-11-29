using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loaihang.Entities;

namespace LoaiHang.DataAccessLayer
{
    public interface ILoaiHangDAL
    {
        List<loaihang> GetAllLoaihang();
        void ThemLoaiHang(loaihang lh);
        void Update(List<loaihang> list);
    }
}
