using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    class HoaDonbanDAL : IHoaDonbanDAL
    {
        private string txtfile = "Data/HoaDonban.txt";
        public List<hoadonBan> GetAllHoaDonban()
        {
            List<hoadonBan> list = new List<hoadonBan>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new hoadonBan(a[0], a[1], int.Parse(a[2]), int.Parse(a[3]), DateTime.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemHoaDonban(hoadonBan hdb)
        {
            string mahdb = "HDB" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahdb + "#" + hdb.maNv + "#" + hdb.thanhTien + "#" + hdb.cKhau + "#" + hdb.ngayBan);
            fwrite.Close();
        }
        public void Update(List<hoadonBan> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maHdb + "#" + list[i].maNv + "#" + list[i].thanhTien + "#" + list[i].cKhau + "#" + list[i].ngayBan);
            fwrite.Close();
        }
    }
}
