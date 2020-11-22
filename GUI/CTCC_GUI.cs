using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.BLL;
using THHHMinhHieu.DocGhiFile;

namespace THHHMinhHieu.GUI
{
    class CTCC_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập CTCC                    |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện CTCC                    |");
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
                        CTCC_BLL.NhapCTCC(arrayList);
                        CTCC_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        CTCC_BLL.HienThiAllCTCC(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        CTCC_BLL.HienThiAllCTCC(arrayList);
                        CTCC_BLL.TimKiem(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        CTCC_BLL.HienThiAllCTCC(arrayList);
                        CTCC_BLL.Sua(arrayList);
                        CTCC_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        CTCC_BLL.HienThiAllCTCC(arrayList);
                        CTCC_BLL.Xoa(arrayList);
                        CTCC_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:break;


                }
            }
        }
    }
}
