using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.DocGhiFile;

namespace THHHMinhHieu.GUI
{
    class RunProgram
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  1.Quản lí CTCC                 |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  2.Quản lí Giá bán              |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  3.Quản lí kho xe               |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  4.Quản lí nghiệp vụ            |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  5.Quản lí nhân viên            |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  6.Tính lương                   |");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("|                  7.Thoát                        |");
            Console.WriteLine("---------------------------------------------------");
        }
        static ArrayList ctcc = new ArrayList();
        static ArrayList giaban = new ArrayList();
        static ArrayList khoxe = new ArrayList();
        static ArrayList nghiepvu = new ArrayList();
        static ArrayList nhanvien = new ArrayList();
        static ArrayList tinhluong = new ArrayList();
        public static void Run()
        {
            int chon;
            while (true)
            {
                Menu();
                chon = int.Parse(Console.ReadLine());
                Console.Clear();
                if (chon == 7) break;
                switch (chon)
                {
                    case 1:
                        CTCC_DAL.DocFile(ctcc);
                        CTCC_GUI.Chon(ctcc);
                        break;
                    case 2:
                        GiaBan_DAL.DocFile(giaban);
                        GiaBan_GUI.Chon(giaban);
                        break;
                    case 3:
                        KhoXe_DAL.DocFile(khoxe);
                        KhoXe_GUI.Chon(khoxe);
                        break;
                    case 4:
                        NghiepVu_DAL.DocFile(nghiepvu);
                        NghiepVu_GUI.Chon(nghiepvu);
                        break;
                    case 5:
                        NhanVien_DAL.DocFile(nhanvien);
                        NhanVien_GUI.Chon(nhanvien);
                        break;
                    case 6:
                        TinhLuong_DAL.DocFile(tinhluong);
                        TinhLuong_GUI.Chon(tinhluong);
                        break;
                    default: break;

                }

            }
        }
    }
}
