using System;
using System.Collections.Generic;
using System.IO;
using DOAN1.Entities;
using DOAN1.DataAccessLayer;

namespace DOAN1.DataAccessLayer
{
    class GiaBanDAL : IGiaBanDAL
    {
        private string txtfile = "Data/Giaban.txt";
        public List<giaban> GetAllGiaban()
        {
            List<giaban> list = new List<giaban>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new giaban(a[0], a[1], int.Parse(a[2]), DateTime.Parse(a[3]), DateTime.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void Themgiaban(giaban gb)
        {
            string magb = "MN" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(magb + "#" + gb.donvi + "#" + gb.Gia + "#" + gb.ngayad + "#" + gb.ngaykt);
            fwrite.Close();
        }
        public void Update(List<giaban> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maHang + "#" + list[i].donvi + "#" + list[i].Gia + "#" + list[i].ngayad + "#" + list[i].ngaykt);
            fwrite.Close();
        }
    }
}
