using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhanVien.Entities;

namespace NhanVien.DataAccessLayer
{
    class NhanVienDAL : INhanVienDAL
    {
        private string txtfile = "Data/NhanVien.txt";
        public List<nhanvien> GetAllNhanvien()
        {
            List<nhanvien> list = new List<nhanvien>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new nhanvien(a[0], a[1], a[2], a[3], DateTime.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemNhanvien(nhanvien nv)
        {
            string manv = "MV" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(manv + "#" + nv.tenNv + "#" + nv.Pass + "#" + nv.loaiNv + "#" + nv.ngayLam);
            fwrite.Close();
        }
        public void Update(List<nhanvien> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maNv + "#" + list[i].tenNv + "#" + list[i].Pass + "#" + list[i].loaiNv + "#" + list[i].ngayLam);
            fwrite.Close();
        }
    }
}
