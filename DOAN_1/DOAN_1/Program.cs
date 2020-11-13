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
    class TinhLuong
    {
        string MaTL, MaNV;
        int soNgay;
        float thuong;
        float lgCB;
        float Thanhtien;
        public string MaTL1 { get => MaTL; set => MaTL = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public int soNgay1 { get => soNgay; set => soNgay = value; }
        public float thuong1 { get => thuong; set => thuong = value; }
        public float lgCB1 { get => lgCB; set => lgCB = value; }
        public float Thanhtien1 { get => Thanhtien; set => Thanhtien = value; }
        public TinhLuong()
        {
            MaTL = "";
            MaNV = "";
            soNgay = 0;
            thuong = lgCB= 0;
        }
        public TinhLuong(string MaTL,string MaNV, int soNgay, float thuong, float lgCB)
        {
            this.MaTL = MaTL;
            this.MaNV = MaNV;
            this.soNgay = soNgay;
            this.thuong = thuong;
            this.lgCB = lgCB;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma tinh luong:");
            MaTL = Console.ReadLine();
            Console.Write("Nhap ma nhan vien:");
            MaNV = Console.ReadLine();
            Console.Write("Nhap so ngay lam viec:");
            soNgay = int.Parse(Console.ReadLine());
            Console.Write("Nhap thuong(neuco):");
            thuong = float.Parse(Console.ReadLine());
            Console.Write("Nhap luong co ban:");
            lgCB = float.Parse(Console.ReadLine());
        }
        public float ThanhTien()
        {
            return (soNgay * lgCB) + thuong;
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1)\t{2}\t{3}\t{4}\t{5}", MaTL, MaNV, soNgay, thuong, lgCB, ThanhTien());
        }
        public string Tostring()
        {
            return MaTL + " " + MaNV + " " + soNgay + " " + thuong + " " + lgCB + " " + ThanhTien();
        }
    }
    class DSTL
    {
        List<TinhLuong> ds = new List<TinhLuong>();
        public void Doctep()
        {
            StreamReader f = File.OpenText("TinhLuong.txt");
            string b;
            while ((b = f.ReadLine()) != null)
            {
                TinhLuong tl = new TinhLuong();
                string[] a = b.Split('#');
                tl.MaTL1 = a[0];
                tl.MaNV1 = a[1];
                tl.soNgay1 = int.Parse(a[2]);
                tl.thuong1 = float.Parse(a[3]);
                tl.lgCB1 = float.Parse(a[4]);
                tl.ThanhTien();
                ds.Add(tl);
            }
            f.Close();
        }
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSTL.txt");
            for (int i = 0; i < ds.Count; i++)
                f.WriteLine(ds[i].Tostring());
            f.Close();
        }
        public void Hienthi()
        {
            for (int i = 0; i < ds.Count; i++)
                ds[i].Hienthi();
        }
        public void Sua()
        {
            string x;
            int y;
            int j = 0;
            Console.Write("Nhap ma tinh luong can sua: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaTL1.IndexOf(x) >= 0)
                {
                    j = 1;
                    Console.WriteLine("Nhap so ngay lam viec can sua: ");
                    y = int.Parse(Console.ReadLine());
                    ds[i].soNgay1 = y;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma tinh luong nay trong danh sach");
            }
        }
    }
    class GiaBan
    {
        string MaHang, dvi;
        int gia;
        DateTime ngayAD, ngayKT;
        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public string dvi1 { get => dvi; set => dvi = value; }
        public int gia1 { get => gia; set => gia = value; }
        public DateTime ngayAD1 { get => ngayAD; set => ngayAD = value; }
        public DateTime ngayKT1 { get => ngayKT; set => ngayKT = value; }
        public GiaBan()
        {
            MaHang = "";
            dvi = "";
            gia = 0;
        }
        public GiaBan(string MaHang, string dvi, int gia, DateTime ngayAD, DateTime ngayKT)
        {
            this.MaHang = MaHang;
            this.dvi = dvi;
            this.gia = gia;
            this.ngayAD = ngayAD;
            this.ngayKT = ngayKT;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma hang:");
            MaHang = Console.ReadLine();
            Console.Write("Nhap don vi tinh:");
            dvi = Console.ReadLine();
            Console.Write("Nhap gia ban:");
            gia = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay ap dung:");
            ngayAD = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ngay ket thuc:");
            ngayKT = DateTime.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", MaHang, dvi, gia, ngayAD, ngayKT);
        }
        public string Tostring()
        {
            return MaHang + " " + dvi + " " + gia + " " + ngayAD + " " + ngayKT;
        }
    }
    class DSGB
    {
        List<GiaBan> ds = new List<GiaBan>();
        public void Doctep()
        {
            StreamReader f = File.OpenText("GiaBan.txt");
            string b;
            while ((b = f.ReadLine()) != null)
            {
                GiaBan g = new GiaBan();
                string[] a = b.Split('#');
                g.MaHang1 = a[0];
                g.dvi1 = a[1];
                g.gia1 = int.Parse(a[2]);
                g.ngayAD1 = DateTime.Parse(a[3]);
                g.ngayKT1 = DateTime.Parse(a[4]);
                ds.Add(g);
            }
            f.Close();
        }
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSGB.txt");
            for (int i = 0; i < ds.Count; i++)
                f.WriteLine(ds[i].Tostring());
            f.Close();
        }
        public void Hienthi()
        {
            for (int i = 0; i < ds.Count; i++)
                ds[i].Hienthi();
        }
        public void Sua()
        {
            string x;
            int y;
            int j = 0;
            Console.Write("Nhap ma hang can sua: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHang1.IndexOf(x) >= 0)
                {
                    j = 1;
                    Console.WriteLine("Nhap gia can sua: ");
                    y = int.Parse(Console.ReadLine());
                    ds[i].gia1 = y;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma hang nay trong danh sach");
            }
        }
    }
    class HDnhap
    {
        string MaHDnhap, tenNVgiao, maNCC;
        int tongTien, VAT;
        public string MaHDnhap1 { get => MaHDnhap; set => MaHDnhap = value; }
        public string tenNVgiao1 { get => tenNVgiao; set => tenNVgiao = value; }
        public string maNCC1 { get => maNCC; set => maNCC = value; }
        public int tongTien1 { get => tongTien; set => tongTien = value; }
        public int VAT1 { get => VAT; set => VAT = value; }
        public HDnhap()
        {
            MaHDnhap = "";
            tenNVgiao = "";
            maNCC = "";
            tongTien = 0;
            VAT = 0;
        }
        public HDnhap(string MaHDnhap, string tenNVgiao, string maNCC, int tongTien, int VAT)
        {
            this.MaHDnhap = MaHDnhap;
            this.tenNVgiao = tenNVgiao;
            this.maNCC = maNCC;
            this.tongTien = tongTien;
            this.VAT = VAT;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma hoa don nhap:");
            MaHDnhap = Console.ReadLine();
            Console.Write("Nhap ten nhan vien giao:");
            tenNVgiao = Console.ReadLine();
            Console.Write("Nhap ma nha cung cap:");
            maNCC = Console.ReadLine();
            Console.Write("Nhap tong tien:");
            tongTien = int.Parse(Console.ReadLine());
            Console.Write("Nhap VAT:");
            VAT = int.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", MaHDnhap, tenNVgiao, maNCC, tongTien, VAT);
        }
        public string Tostring()
        {
            return MaHDnhap + " " + tenNVgiao + " " + maNCC + " " + tongTien + " " + VAT;
        }
    }
    class DSHDN
    {
        List<HDnhap> ds = new List<HDnhap>();
        public void Doctep()
        {
            StreamReader f = File.OpenText("HDnhap.txt");
            string b;
            while ((b = f.ReadLine()) != null)
            {
                HDnhap n = new HDnhap();
                string[] a = b.Split('#');
                n.MaHDnhap1 = a[0];
                n.tenNVgiao1 = a[1];
                n.maNCC1 = a[2];
                n.tongTien1 = int.Parse(a[3]);
                n.VAT1 = int.Parse(a[4]);
                ds.Add(n);
            }
            f.Close();
        }
        public void ghitep()
        {
            StreamWriter f = new StreamWriter("DSHDN.txt");
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
            HDnhap n = new HDnhap();
            n.Nhap();
            ds.Add(n);
        }
        public void Sua()
        {
            string x;
            int y;
            int j = 0;
            Console.Write("Nhap ma hoa don nhap can sua: ");
            x = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaHDnhap1.IndexOf(x) >= 0)
                {
                    j = 1;
                    Console.WriteLine("Nhap tong tien can sua: ");
                    y = int.Parse(Console.ReadLine());
                    ds[i].tongTien1 = y;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Khong ton tai ma hoa don nhap nay trong danh sach");
            }
        }
        public void Xoa()
        {
            int f = 0;
            Console.Write("Nhap ma hoa don nhap can xoa: ");
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaHDnhap1) >= 0)
                {
                    ds.Remove(ds[i]);
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hoa don nhap khong ton tai");
        }
        public void TimkiemMaHDnhap()
        {
            int f = 0;
            Console.Write("Nhap ma hoa don nhap can tim kiem: ");
            string a = Console.ReadLine();
            for (int i = 0; i < ds.Count; i++)
            {
                f = 1;
                if (a.IndexOf(ds[i].MaHDnhap1) >= 0)
                {
                    ds[i].Hienthi();
                }
            }
            if (f == 0)
                Console.WriteLine("Ma hoa don nhap khong ton tai");
        }
    }
    class HangNhap
    {
        string maHangnhap;
        int slgnhap, dgianhap;
        DateTime ngaysx, ngayhh;
        public string maHangnhap1 { get => maHangnhap; set => maHangnhap = value; }
        public int slgnhap1 { get => slgnhap; set => slgnhap = value; }
        public int dgianhap1 { get => dgianhap; set => dgianhap = value; }
        public DateTime ngaysx1 { get => ngaysx; set => ngaysx = value; }
        public DateTime ngayhh1 { get => ngayhh; set => ngayhh = value; }
        public HangNhap()
        {
            maHangnhap = "";
            slgnhap = 0;
            dgianhap = 0;
        }
        public HangNhap(string maHangnhap, int slgnhap, int dgianhap)
        {
            this.maHangnhap = maHangnhap;
            this.slgnhap = slgnhap;
            this.dgianhap = dgianhap;
        }
        public void Nhap()
        {
            Console.Write("Nhap ma hang nhap:");
            maHangnhap = Console.ReadLine();
            Console.Write("Nhap so luong nhap:");
            slgnhap = int.Parse(Console.ReadLine());
            Console.Write("Nhap don gia nhap:");
            dgianhap = int.Parse(Console.ReadLine());
            Console.Write("Nhap ngay san xuat:");
            ngaysx = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ngay het han:");
            ngayhh = DateTime.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", maHangnhap, slgnhap, dgianhap, ngaysx, ngayhh);
        }
        public string Tostring()
        {
            return maHangnhap + " " + slgnhap + " " + dgianhap + " " + ngaysx + " " + ngayhh;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
