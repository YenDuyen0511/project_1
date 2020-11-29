using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loaihang.Entities;

namespace LoaiHang.DataAccessLayer
{
    class LoaiHangDAL : ILoaiHangDAL
    {
        private string txtfile = "Data/LoaiHang.txt";
        public List<loaihang> GetAllLoaihang()
        {
            List<loaihang> list = new List<loaihang>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while(s!= null)
            {
                if(s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new loaihang(a[0], a[1], a[2]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemLoaiHang(loaihang lh)
        {
            string maLoai = "ML" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(maLoai + "#" + lh.tenLoai + "#" + lh.mauSac);
            fwrite.Close();
        }
        public void Update(List<loaihang> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maLoai + "#" + list[i].tenLoai + "#" + list[i].mauSac);
            fwrite.Close();
        }
    }
}
