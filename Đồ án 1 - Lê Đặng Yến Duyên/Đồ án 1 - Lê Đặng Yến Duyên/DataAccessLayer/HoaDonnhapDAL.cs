using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN1.Entities;

namespace DOAN1.DataAccessLayer
{
    class HoaDonnhapDAL : IHoaDonnhapDAL
    {
        private string txtfile = "Data/HoaDonnhap.txt";
        public List<hoadonNhap> GetAllHoaDonnhap()
        {
            List<hoadonNhap> list = new List<hoadonNhap>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new hoadonNhap(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemHoaDonnhap(hoadonNhap hdn)
        {
            string mahdn = "HDN" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahdn + "#" + hdn.tenNvgiao + "#" + hdn.maNcc + "#" + hdn.Tong + "#" + hdn.VAT);
            fwrite.Close();
        }
        public void Update(List<hoadonNhap> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maHdn + "#" + list[i].tenNvgiao + "#" + list[i].maNcc + "#" + list[i].Tong + "#" + list[i].VAT);
            fwrite.Close();
        }
    }
}
