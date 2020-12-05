using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Loaihang.Presentation;

namespace Loaihang
{
    public class Program1
    {
        public static void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(" *****************************************");
                Console.WriteLine(" |        F1: Quan li loai hang          |");
                Console.WriteLine(" |        F2: Quan li hang hoa           |");
                Console.WriteLine(" |        F3: Quan li nha cung cap       |");
                Console.WriteLine(" |        F4: Quan li nhan vien          |");
                Console.WriteLine(" |        F5: Quan li hoa don nhap       |");
                Console.WriteLine(" |        F6: Quan li hang nhap          |");
                Console.WriteLine(" |        F7: Quan li hoa don ban        |");
                Console.WriteLine(" |        F8: Quan li hang ban           |");
                Console.WriteLine(" |        F9: Ket thuc                   |");
                Console.WriteLine(" *****************************************");
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1:
                        frmLoaiHang frm1 = new frmLoaiHang();
                        frm1.Menu();
                        break;
                }
            } while (true);
        }
        static void Main1(string [] args)
        {
            Menu();
        }
    }
}
