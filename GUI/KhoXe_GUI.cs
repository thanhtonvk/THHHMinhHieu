using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.BLL;
using THHHMinhHieu.DocGhiFile;
namespace THHHMinhHieu.GUI
{
    class KhoXe_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập kho xe                  |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện kho xe                  |");
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
                        KhoXe_BLL.NhapKhoXe(arrayList);
                        KhoXe_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        KhoXe_BLL.HienThiAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        KhoXe_BLL.HienThiAll(arrayList);
                        KhoXe_BLL.TimKiem(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        KhoXe_BLL.HienThiAll(arrayList);
                        KhoXe_BLL.Sua(arrayList);
                        KhoXe_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        KhoXe_BLL.HienThiAll(arrayList);
                        KhoXe_BLL.Xoa(arrayList);
                        KhoXe_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
