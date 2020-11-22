using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.BLL
{
    class KhoXe_BLL
    {
        public static void NhapKhoXe(ArrayList arrayList)
        {
            //int maxe, string tenxe, string maloai, int slnhapve, int slhienco
            int maxe = arrayList.Count + 1000;
            Console.WriteLine("Nhập tên xe");
            string tenxe = Nhap.NhapString();
            Console.WriteLine("Nhập mã loại");
            string maloai = Nhap.NhapString();
            Console.WriteLine("Nhập số lượng nhập về");
            int slnhap = Nhap.NhapInt();
            Console.WriteLine("Nhập số lượng hiện có");
            int slco = Nhap.NhapInt();
            arrayList.Add(new KhoXe(maxe, tenxe, maloai, slnhap, slco + slnhap));
        }
        public static void HienThi(KhoXe ob)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", ob.Maxe, ob.Tenxe, ob.Maloai, ob.Slnhapve, ob.Slhienco);
        }
        public static void HienThiAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã xe", "Tên xe", "Mã loại", "Số lượng nhập", "Số lượng có");
            foreach (KhoXe ob in arrayList)
            {
                HienThi(ob);
            }
        }
        public static KhoXe Find(ArrayList arrayList)
        {
            KhoXe kq = null;
            Console.WriteLine("Nhập mã xe: ");
            string tk = Nhap.NhapString();
            foreach (KhoXe ob in arrayList)
            {
                if (tk == ob.Maxe.ToString())
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|", "Mã xe", "Tên xe", "Mã loại", "Số lượng nhập", "Số lượng có");
            HienThi(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            KhoXe ob = Find(arrayList);
            Console.WriteLine("Nhập tên xe");
            ob.Tenxe = Nhap.NhapString();
            Console.WriteLine("Nhập mã loại");
            ob.Maloai = Nhap.NhapString();
            Console.WriteLine("Nhập số lượng nhập về");
            ob.Slnhapve = Nhap.NhapInt();
            Console.WriteLine("Nhập số lượng hiện có");
            ob.Slhienco = Nhap.NhapInt();
        }
    }
}

