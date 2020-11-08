using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Contracts;

namespace ConsoleApp1
{
    class LoaiHang
    {
        string MaLoai, TenLoai, MauSac;
        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string TenLoai1 { get => TenLoai; set => TenLoai = value; }
        public string MauSac1 { get => MauSac; set => MauSac = value; }
        public LoaiHang()
        {
            MaLoai = "";
            TenLoai = "";
            MauSac = "";
        }
        public LoaiHang(string MaLoai, string TenLoai, string MauSac)
        {
            this.MaLoai = MaLoai;
            this.TenLoai = TenLoai;
            this.MauSac = MauSac;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma loai hang:");
            MaLoai = Console.ReadLine();
            Console.Write("Nhap ten loai hang:");
            TenLoai = Console.ReadLine();
            Console.Write("Nhap mau sac:");
            MauSac = Console.ReadLine();
        }
        public void Hienthi()
        {
            Console.Write("{0}\t{1}\t{2}", MaLoai, TenLoai, MauSac);
        }
        public string Tostring()
        {
            return MaLoai + " " + TenLoai + " " + MauSac;
        }
    }
    class DSLoaiHang
    {
        List<LoaiHang> ds = new List<LoaiHang>();
        public void DocTep()
        {
            StreamReader f = File.OpenText("LoaiHang.txt");
            string a;
            while ((a = f.ReadLine()) != null)
            {
                LoaiHang l = new LoaiHang();
                string[] d = a.Split(' ');
                l.MaLoai1 = d[0];
                l.TenLoai1 = d[1];
                l.MauSac1 = d[3];
                ds.Add(l);
            }
            f.Close();
        }
        public void Hienthi()
        {
            for (int i = 0; i < ds.Count; i++)
                ds[i].Hienthi();
        }
        public void Nhap()
        {
            LoaiHang a = new LoaiHang();
            a.Nhap();
            ds.Add(a);
        }
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSLoaiHang.txt");
            for (int i = 0; i < ds.Count; i++)
                f.WriteLine(ds[i].Tostring());
            f.Close();
        }
        public void Sua()
        {
            string x;
            string y;
            int j = 0;
            Console.Write("Nhap ma loai can sua: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaLoai1.IndexOf(x) >= 0)
                {
                    j = 1;
                    Console.WriteLine("Nhap mau sac can sua: ");
                    y = Console.ReadLine();
                    ds[i].MauSac1 = y;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma loai hang nay trong danh sach");
            }
        }
        public void Xoa()
        {
            string x;
            int j = 0;
            Console.Write("Nhap ma loai can xoa: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaLoai1.IndexOf(x) >= 0)
                {
                    j = 1;
                    ds.Remove(ds[i]);
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma loai hang nay trong danh sach");
            }
        }
        public void TimkiemMaLoai()
        {
            int j = 0;
            string x;
            Console.Write("Nhap ma loai can tim: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                j = 1;
                if (ds[i].MaLoai1.IndexOf(x) >= 0)
                    ds[i].Hienthi();
            }
            if (j == 0)
                Console.WriteLine("Khong co ma loai hang can tim");
        }
        public void TimkiemTenLoai()
        {
            int j = 0;
            string x;
            Console.Write("Nhap ten loai can tim: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                j = 1;
                if (ds[i].TenLoai1.IndexOf(x) >= 0)
                    ds[i].Hienthi();
            }
            if (j == 0)
                Console.WriteLine("Khong co ten loai hang can tim");
        }
    }
    class HangHoa
    {
        string MaHang, TenHang, MaLoai;
        int slgNhap, slgCo;
        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string TenHang1 { get => TenHang; set => TenHang = value; }
        public int slgNhap1 { get => slgNhap; set => slgNhap = value; }
        public int slgCo1 { get => slgCo; set => slgCo = value; }
        public HangHoa()
        {
            MaHang = "";
            TenHang = "";
            MaLoai = "";
            slgNhap = 0;
            slgCo = 0;
        }
        public HangHoa(string MaHang, string TenHang, string MaLoai, int slgNhap, int slgCo)
        {
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.MaLoai = MaLoai;
            this.slgNhap = slgNhap;
            this.slgCo = slgCo;
        }
        public void Nhap()
        {
            do
            {
                Console.Write("Nhap ma hang hoa: ");
                MaHang = Console.ReadLine();
            }
            while (MaHang.Length == 0);
            do
            {
                Console.Write("Nhap ten hang hoa: ");
                TenHang= Console.ReadLine();
            }
            while (TenHang.Length == 0);
            do
            {
                Console.Write("Nhap ma loai hang hoa: ");
                MaLoai = Console.ReadLine();
            }
            while (MaLoai.Length == 0);
            do
            {
                Console.Write("Nhap so luong nhap ve: ");
                slgNhap = int.Parse(Console.ReadLine());
            }
            while (slgNhap < 0);
            {
                Console.Write("Nhap so luong hien co: ");
                slgCo = int.Parse(Console.ReadLine());
            }
            while (slgCo < 0) ;
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", MaHang, TenHang, MaLoai, slgNhap, slgCo);
        }
        public string Tostring()
        {
            return MaHang + " " + TenHang + " " + MaLoai + " " + slgNhap + " " + slgCo;
        }
    }
    class DSHangHoa
    {
        List<HangHoa> ds = new List<HangHoa>();
        public void DocTep()
        {
            StreamReader f = File.OpenText("HangHoa.txt");
            string b;
            while ((b = f.ReadLine()) != null)
            {
                HangHoa h = new HangHoa();
                string[]a  = b.Split('#');
                h.MaHang1 = a[0];
                h.TenHang1 = a[1];
                h.MaLoai1 = a[2];
                h.slgNhap1 = int.Parse(a[3]);
                h.slgCo1 = int.Parse(a[4]);
                ds.Add(h);
            }
            f.Close();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
