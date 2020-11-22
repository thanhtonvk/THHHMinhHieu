using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.BLL
{
    class TinhLuong_BLL
    {
        public static void NhapTinhLuong(ArrayList arrayList)
        {
            //int matl, int manv, float songaylv, double thuong, double luongcoban
            int matl = arrayList.Count + 1000;
            Console.WriteLine("Nhập mã nhân viên");
            int manv = Nhap.NhapInt();
            Console.WriteLine("Nhập số ngày làm việc ");
            float songaylv = Nhap.NhapFloat();
            Console.WriteLine("Nhập thưởng");
            double thuong = Nhap.NhapDouble();
            Console.WriteLine("Nhập lương cơ bản");
            double lcb = Nhap.NhapDouble();
            arrayList.Add(new TinhLuong(matl,manv,songaylv,thuong,lcb));
        }
        public static void HienThi(TinhLuong ob)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", ob.Matl, ob.Manv, ob.Songaylv, ob.Thuong, ob.Luongcoban, ob.Thanhtien());
        }
        public static void HienThiAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã tính lương", "Mã nhân viên", "Số ngày làm việc", "Thưởng", "Lương cơ bản", "Thành tiền");
            foreach (TinhLuong ob in arrayList)
            {
                HienThi(ob);
            }
        }
        public static TinhLuong Find(ArrayList arrayList)
        {
            TinhLuong kq = null;
            Console.WriteLine("Nhập mã tính lương: ");
            string tk = Nhap.NhapString();
            foreach (TinhLuong ob in arrayList)
            {
                if (tk == ob.Matl.ToString())
                {
                    kq = ob;
                }
            }
            return kq;
        }
        public static void Xoa(ArrayList arrayList)
        {
            arrayList.Remove(Find(arrayList));
        }
        public static void TimKiem(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã tính lương", "Mã nhân viên", "Số ngày làm việc", "Thưởng", "Lương cơ bản", "Thành tiền");
            HienThi(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            TinhLuong ob = Find(arrayList);
            Console.WriteLine("Nhập tên nhân viên");
            ob.Matl= arrayList.Count + 1000;
            Console.WriteLine("Nhập mã nhân viên");
           ob.Manv = Nhap.NhapInt();
            Console.WriteLine("Nhập số ngày làm việc ");
            ob.Songaylv = Nhap.NhapFloat();
            Console.WriteLine("Nhập thưởng");
            ob.Thuong = Nhap.NhapDouble();
            Console.WriteLine("Nhập lương cơ bản");
           ob.Luongcoban = Nhap.NhapDouble();
        }
    }
}
