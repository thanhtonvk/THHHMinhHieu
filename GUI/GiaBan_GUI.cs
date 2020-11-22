﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.BLL;
using THHHMinhHieu.DocGhiFile;
namespace THHHMinhHieu.GUI
{
    class GiaBan_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Nhập giá bán                 |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Hiện giá bán                 |");
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
                        GiaBan_BLL.NhapGiaBan(arrayList);
                        GiaBan_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        GiaBan_BLL.HienThiAll(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        GiaBan_BLL.HienThiAll(arrayList);
                        GiaBan_BLL.TimKiem(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        GiaBan_BLL.HienThiAll(arrayList);
                        GiaBan_BLL.Sua(arrayList);
                        GiaBan_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        GiaBan_BLL.HienThiAll(arrayList);
                        GiaBan_BLL.Xoa(arrayList);
                        GiaBan_DAL.GhiFile(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
