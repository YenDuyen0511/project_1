﻿using System;
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
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSHH.txt");
            for (int i = 0; i < ds.Count; i++)
                f.WriteLine(ds[i].Tostring());
            f.Close();
        }
        public void Hienthi()
        {
            Console.WriteLine("Ma hang   Ten hang       Ma loai     So luong nhap ve    So luong hien co");
            for (int i = 0; i < ds.Count; i++)
            {
                ds[i].Hienthi();
            }
        }
        public void Them()
        {
            HangHoa c = new HangHoa();
            c.Nhap();
            ds.Add(c);
        }
        public void Suaslnv()
        {
            int f = 0;
            Console.Write("Nhap ma hang can sua: ");
            string a = Console.ReadLine();
            Console.Write("Nhap so luong nhap ve can sua doi: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaHang1) >= 0)
                {
                    ds[i].slgNhap1 = b;
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hang khong ton tai");
        }
        public void Suaslhc()
        {
            int f = 0;
            Console.Write("Nhap ma hang can sua: ");
            string a = Console.ReadLine();
            Console.Write("Nhap so luong hien co can sua doi: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaHang1) >= 0)
                {
                    ds[i].slgCo1 = b;
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hang khong ton tai");
        }
        public void Xoa()
        {
            int f = 0;
            Console.Write("Nhap ma hang can xoa: ");
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaHang1) >= 0)
                {
                    ds.Remove(ds[i]);
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hang khong ton tai");
        }
        public void TimkiemMaHang()
        {
            int f = 0;
            Console.Write("Nhap ma hang can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaHang1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hang khong ton tai");
        }
        public void TimkiemTenHang()
        {
            int f = 0;
            Console.Write("Nhap ten hang can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].TenHang1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hang khong ton tai");
        }

    }
    class NCC
    {
        string MaNcc, TenNcc, DiaChi, sdt;
        public string MaNcc1 { get => MaNcc; set => MaNcc = value; }
        public string TenNcc1 { get => TenNcc; set => TenNcc = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string sdt1 { get => sdt; set => sdt = value; }
        public NCC()
        {
            MaNcc = "";
            TenNcc = "";
            DiaChi = "";
            sdt = "";
        }
        public NCC(string MaNcc,string TenNcc, string DiaChi,string sdt)
        {
            this.MaNcc = MaNcc;
            this.TenNcc = TenNcc;
            this.DiaChi = DiaChi;
            this.sdt = sdt;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma nha cung cap:");
            MaNcc = Console.ReadLine();
            Console.Write("Nhap ten nha cung cap:");
            TenNcc = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap so dien thoai:");
            sdt = Console.ReadLine();
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", MaNcc, TenNcc, DiaChi, sdt);
        }
        public string Tostring()
        {
            return MaNcc + " " + TenNcc + " " + DiaChi + " " + sdt;
        }
    }
    class DSNcc
    {
        List<NCC> ds = new List<NCC>();
        public void DocTep()
        {
            StreamReader f = File.OpenText("NCC.txt");
            string b;
            while ((b = f.ReadLine()) != null)
            {
                NCC c = new NCC();
                string[] a = b.Split('#');
                c.MaNcc1 = a[0];
                c.TenNcc1 = a[1];
                c.DiaChi1 = a[2];
                c.sdt1 = a[3];
                ds.Add(c);
            }
            f.Close();
        }
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSNCC.txt");
            for (int i = 0; i < ds.Count; i++)
                f.WriteLine(ds[i].Tostring());
            f.Close();
        }
        public void Hienthi()
        {
            Console.WriteLine("Ma ncc   Ten ncc     Dia chi       Sdt ");
            for (int i = 0; i < ds.Count; i++)
            {
                ds[i].Hienthi();
            }
        }
        public void Them()
        {
            NCC c = new NCC();
            c.Nhap();
            ds.Add(c);
        }
        public void Sua()
        {
            string x;
            string y;
            int j = 0;
            Console.Write("Nhap ma nha cung cap can sua: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaNcc1.IndexOf(x) >= 0)
                {
                    j = 1;
                    Console.WriteLine("Nhap dia chi can sua: ");
                    y = Console.ReadLine();
                    ds[i].DiaChi1 = y;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma nha cung cap nay trong danh sach");
            }
        }
        public void Xoa()
        {
            int f = 0;
            Console.Write("Nhap ma nha cung cap can xoa: ");
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaNcc1) >= 0)
                {
                    ds.Remove(ds[i]);
                }
            }
            if (f == 0)
                Console.WriteLine("Ma nha cung cap khong ton tai");
        }
        public void TimkiemMaNcc()
        {
            int f = 0;
            Console.Write("Nhap ma nha cung cap can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaNcc1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ma nha cung cap khong ton tai");
        }
        public void TimkiemTenNcc()
        {
            int f = 0;
            Console.Write("Nhap ten nha cung cap can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].TenNcc1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ten nha cung cap khong ton tai");
        }
    }
    class Nhanvien
    {
        string MaNv, TenNv, LoaiNv, pass;
        DateTime NgayLam;
        public string MaNv1 { get => MaNv; set => MaNv = value; }
        public string TenNv1 { get => TenNv; set => TenNv = value; }
        public string LoaiNv1 { get => LoaiNv; set => LoaiNv = value; }
        public string pass1 { get => pass; set => pass = value; }
        public DateTime NgayLam1 { get => NgayLam; set => NgayLam = value; }
        public Nhanvien()
        {
            MaNv = "";
            TenNv = "";
            LoaiNv = "";
            pass = "";
        }
        public Nhanvien(string MaNv, string TenNv, string LoaiNv, string pass, DateTime NgayLam)
        {
            this.MaNv = MaNv;
            this.TenNv = TenNv;
            this.LoaiNv = LoaiNv;
            this.pass = pass;
            this.NgayLam = NgayLam;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma nhan vien:");
            MaNv = Console.ReadLine();
            Console.Write("Nhap ten nhan vien:");
            TenNv = Console.ReadLine();
            Console.Write("Nhap loai nhan vien:");
            LoaiNv = Console.ReadLine();
            Console.Write("Nhap pass:");
            pass = Console.ReadLine();
            Console.Write("Nhap ngay lam viec:");
            NgayLam = DateTime.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2)\t{3}\t{4}", MaNv, TenNv, LoaiNv, pass, NgayLam);
        }
        public string Tostring()
        {
            return MaNv + " " + TenNv + " " + LoaiNv + " " + pass + " " + NgayLam;
        }
    }
    class DSNV
    {
        List<Nhanvien> ds = new List<Nhanvien>();
        public void Doctep()
        {
            StreamReader f = File.OpenText("NhanVien.txt");
            string b;
            while ((b = f.ReadLine()) != null)
            {
                Nhanvien v = new Nhanvien();
                string[] a = b.Split('#');
                v.MaNv1 = a[0];
                v.TenNv1 = a[1];
                v.LoaiNv1 = a[2];
                v.pass1 = a[3];
                v.NgayLam1 = DateTime.Parse(a[4]);
                ds.Add(v);
            }
            f.Close();
        }
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSNV.txt");
            for (int i = 0; i < ds.Count; i++)
                f.WriteLine(ds[i].Tostring());
            f.Close();
        }
        public void Hienthi()
        {
            for (int i = 0; i < ds.Count; i++)
                ds[i].Hienthi();
        }
        public void Them()
        {
            Nhanvien v = new Nhanvien();
            v.Nhap();
            ds.Add(v);
        }
        public void Sua()
        {
            string x;
            string y;
            int j = 0;
            Console.Write("Nhap ma nhan vien can sua: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaNv1.IndexOf(x) >= 0)
                {
                    j = 1;
                    Console.WriteLine("Nhap loai nhan vien can sua: ");
                    y = Console.ReadLine();
                    ds[i].LoaiNv1 = y;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma nhan vien nay trong danh sach");
            }
        }
        public void Xoa()
        {
            int f = 0;
            Console.Write("Nhap ma nhan vien can xoa: ");
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaNv1) >= 0)
                {
                    ds.Remove(ds[i]);
                }
            }
            if (f == 0)
                Console.WriteLine("Ma nhan vien khong ton tai");
        }
        public void TimkiemMaNv()
        {
            int f = 0;
            Console.Write("Nhap ma nhan vien can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaNv1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ma nhan vien khong ton tai");
        }
        public void TimkiemTenNv()
        {
            int f = 0;
            Console.Write("Nhap ten nhan vien can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].TenNv1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ten nhan vien khong ton tai");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
