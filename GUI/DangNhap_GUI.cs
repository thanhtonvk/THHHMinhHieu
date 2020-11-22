using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.ChucNang;
using THHHMinhHieu.DAL;

namespace THHHMinhHieu.GUI
{
    class DangNhap_GUI
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Đăng nhập                    |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Đăng kí                      |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Thoát                        |");
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
                if (chon == 3) break;
                switch (chon)
                {
                    case 1:
                        bool kt=true;
                        if(kt == Login.DangNhap(arrayList))
                        {
                            Console.WriteLine("Đăng nhập thành công");
                            //menu main
                            RunProgram.Run();
                        }
                        else
                        {
                            Console.WriteLine("Đăng nhập thất bại");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Login.TaoTK(arrayList);
                        DangNhap_DAL.GhiFile(arrayList);
                        Console.Clear();
                        break;
                    default: break;


                }
            }
        }
    }
}
