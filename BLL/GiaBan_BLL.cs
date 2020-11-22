using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.BLL
{
    class GiaBan_BLL
    {
        public static void NhapGiaBan(ArrayList arrayList)
        {
            //int magiachothue,int maxe,double giachothue,string donvitinh,string ngayad,string ngaythoiad
            int magiachothue = arrayList.Count + 1000;
            Console.WriteLine("Nhập mã xe");
            int maxe = Nhap.NhapInt();
            Console.WriteLine("Nhập giá cho thuê");
            double giachothue = Nhap.NhapDouble();
            Console.WriteLine("Nhập đơn vị tính");
            string donvitinh = Nhap.NhapString();
            Console.WriteLine("Nhập ngày áp dụng");
            string ngayad = Nhap.NhapString();
            Console.WriteLine("Nhập ngày thôi áp dụng");
            string ngaythoiad = Nhap.NhapString();
            arrayList.Add(new GiaBan(magiachothue, maxe, giachothue, donvitinh, ngayad, ngaythoiad));
        }
        public static void HienThi(GiaBan ob)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", ob.Magiachothue, ob.Maxe, ob.Giachothue, ob.Donvitinh, ob.Ngayad, ob.Ngaythoad);
        }
        public static void HienThiAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã giá cho thuê", "Mã xe", "Giá cho thuê", "Đơn vị tính", "Ngày áp dụng", "Ngày thôi áp dụng");
            foreach (GiaBan ob in arrayList)
            {
                HienThi(ob);
            }
        }
        public static GiaBan Find(ArrayList arrayList)
        {
            GiaBan kq = null;
            Console.WriteLine("Nhập mã tính lương: ");
            string tk = Nhap.NhapString();
            foreach (GiaBan ob in arrayList)
            {
                if (tk == ob.Magiachothue.ToString())
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "Mã giá cho thuê", "Mã xe", "Giá cho thuê", "Đơn vị tính", "Ngày áp dụng", "Ngày thôi áp dụng");
            HienThi(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            GiaBan ob = Find(arrayList);
            Console.WriteLine("Nhập mã xe");
            ob.Maxe = Nhap.NhapInt();
            Console.WriteLine("Nhập giá cho thuê");
            ob.Giachothue = Nhap.NhapDouble();
            Console.WriteLine("Nhập đơn vị tính");
            ob.Donvitinh = Nhap.NhapString();
            Console.WriteLine("Nhập ngày áp dụng");
            ob.Ngayad = Nhap.NhapString();
            Console.WriteLine("Nhập ngày thôi áp dụng");
            ob.Ngaythoad = Nhap.NhapString();
        }
    }
}
