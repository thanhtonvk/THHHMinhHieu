using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.BLL;
using THHHMinhHieu.DocGhiFile;
namespace THHHMinhHieu.GUI
{
    class TinhLuong_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập lương                   |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện lương                   |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Tìm kiếm                     |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  4.Sửa                          |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  5.Xóa                          |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  6.Thoát                        |");
            Console.WriteLine("---------------------------------------------------");
        }
        public static void Chon(ArrayList arrayList)
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 6) break;
                switch (chon)
                {
                    case 1:
                        TinhLuong_BLL.NhapTinhLuong(arrayList);
                        TinhLuong_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        TinhLuong_BLL.HienThiAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        TinhLuong_BLL.HienThiAll(arrayList);
                        TinhLuong_BLL.TimKiem(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        TinhLuong_BLL.HienThiAll(arrayList);
                        TinhLuong_BLL.Sua(arrayList);
                        TinhLuong_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        TinhLuong_BLL.HienThiAll(arrayList);
                        TinhLuong_BLL.Xoa(arrayList);
                        TinhLuong_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
