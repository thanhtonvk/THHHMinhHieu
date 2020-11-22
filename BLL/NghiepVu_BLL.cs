using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.BLL
{
    class NghiepVu_BLL
    {
        public static void NhapNghiepVu(ArrayList arrayList)
        {
            //int mahdn,string tenhdn,string tennvgiao,string mahd,string tenxechothue,int soluong,int maxechothue,int tongtien,double giachothue
            int mahdn = arrayList.Count + 1000;
            Console.WriteLine("Nhập tên HDN");
            string tenhdn = Nhap.NhapString();
            Console.WriteLine("Nhập tên nhân viên giao");
            string tennvgiao = Nhap.NhapString();
            Console.WriteLine("Nhập mã HD");
            string mahd = Nhap.NhapString();
            Console.WriteLine("Nhập tên xe cho thuê");
            string tenxechothue = Nhap.NhapString();
            Console.WriteLine("Nhập số lượng");
            int soluong = Nhap.NhapInt();
            Console.WriteLine("Nhập mã xe cho thuê");
            int maxechothue = Nhap.NhapInt();
            Console.WriteLine("Nhập giá cho thuê");
            double giachothue = Nhap.NhapDouble();
            double tongtien = Convert.ToDouble(soluong)* giachothue;
            arrayList.Add(new NghiepVu(mahdn, tenhdn, tennvgiao, mahd, tenxechothue, soluong, maxechothue,Convert.ToInt32(tongtien),giachothue));
        }
        public static void HienThi(NghiepVu ob)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}||{6,-20}|{7,-20}|{8,-20}|", ob.Mahd, ob.Tenhdn, ob.Tennvgiao, ob.Mahd, ob.Tenxechothue, ob.Soluong,ob.Maxechothue,ob.Tongtien,ob.Giachothue);
        }
        public static void HienThiAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}||{6,-20}|{7,-20}|{8,-20}|", "Mã HDN", "Tên HDN", "Tên nhân viên giao", "Mã HD", "Tên xe cho thuê", "Số lượng","Mã xe cho thuê","Tổng tiền","Giá cho thuê");
            foreach (NghiepVu ob in arrayList)
            {
                HienThi(ob);
            }
        }
        public static NghiepVu Find(ArrayList arrayList)
        {
            NghiepVu kq = null;
            Console.WriteLine("Nhập mã tính lương: ");
            string tk = Nhap.NhapString();
            foreach (NghiepVu ob in arrayList)
            {
                if (tk == ob.Mahd.ToString())
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}||{6,-20}|{7,-20}|{8,-20}|", "Mã HDN", "Tên HDN", "Tên nhân viên giao", "Mã HD", "Tên xe cho thuê", "Số lượng", "Mã xe cho thuê", "Tổng tiền", "Giá cho thuê");
            HienThi(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            NghiepVu ob = Find(arrayList);
            Console.WriteLine("Nhập tên HDN");
            ob.Tenhdn = Nhap.NhapString();
            Console.WriteLine("Nhập tên nhân viên giao");
            ob.Tennvgiao = Nhap.NhapString();
            Console.WriteLine("Nhập mã HD");
           ob.Mahd = Nhap.NhapString();
            Console.WriteLine("Nhập tên xe cho thuê");
           ob.Tenxechothue = Nhap.NhapString();
            Console.WriteLine("Nhập số lượng");
            ob.Soluong = Nhap.NhapInt();
            Console.WriteLine("Nhập mã xe cho thuê");
            ob.Maxechothue = Nhap.NhapInt();
            Console.WriteLine("Nhập giá cho thuê");
            ob.Giachothue = Nhap.NhapDouble();
            ob.Tongtien = Convert.ToInt32(Convert.ToDouble(ob.Soluong) * ob.Giachothue);
        }
    }
}
