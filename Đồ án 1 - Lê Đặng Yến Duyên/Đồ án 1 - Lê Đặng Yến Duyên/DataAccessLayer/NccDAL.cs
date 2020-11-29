using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCC.Entities;

namespace NCC.DataAccessLayer
{
    class NccDAL : INccDAL
    {
        private string txtfile = "Data/Ncc.txt";
        public List<ncc> GetAllNcc()
        {
            List<ncc> list = new List<ncc>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new ncc(a[0], a[1], a[2], a[3]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        public void ThemNcc(ncc cc)
        {
            string mancc = "MN" + DateTime.Now.ToString("yyMMddhhmmss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mancc + "#" + cc.tenNcc + "#" + cc.dChi + "#" + cc.SDT);
            fwrite.Close();
        }
        public void Update(List<ncc> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; i++)
                fwrite.WriteLine(list[i].maNcc + "#" + list[i].tenNcc + "#" + list[i].dChi + "#" + list[i].SDT);
            fwrite.Close();
        }
    }
}
