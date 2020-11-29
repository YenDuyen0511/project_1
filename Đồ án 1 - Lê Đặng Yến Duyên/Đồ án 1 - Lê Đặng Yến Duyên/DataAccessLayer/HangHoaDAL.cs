using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangHoa.Entities;

namespace HangHoa.DataAccessLayer
{
    class HangHoaDAL : IHangHoaDAL
    {
        private string txtfile = "Data/HangHoa.txt";
        public List<hanghoa> GetAllHanghoa()
        {
            List<hanghoa> list = new List<hanghoa>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new hanghoa(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemHanghoa(hanghoa hh)
        {
            string mahang = "MH" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahang + "#" + hh.tenHang + "#" + hh.maLoai + "#" + hh.slgnhap + "#" + hh.slgco);
            fwrite.Close();
        }
        public void Update(List<hanghoa> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maHang + "#" + list[i].tenHang + "#" + list[i].maLoai + "#" + list[i].slgnhap + "#" + list[i].slgco);
            fwrite.Close();
        }
    }
}

