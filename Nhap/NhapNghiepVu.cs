﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.Nhap
{
    class NhapNghiepVu
    {
        //int mahdn,string tenhdn,string tennvgiao,string mahd,string tenxechothue,int soluong,int maxechothue,int tongtien,double giachothue
        public void NhapThongTinNghiepVu(ArrayList arrayList)
        {
            arrayList.Add(new NghiepVu(mahdn(arrayList),tenhdn(),tennvgiao(),mahd(),tenxechothue(),soluong(),maxechothue(),tongtien(),giachothue()));
        }
        public double giachothue()
        {
            Console.WriteLine("Nhập giá cho thuê: ");
            double gia = double.Parse(Console.ReadLine());
            return gia;
        }
        public int tongtien()
        {
            Console.WriteLine("Nhập tổng tiền: ");
            int tongtien = int.Parse(Console.ReadLine());
            return tongtien;
        }
        public int maxechothue()
        {
            Console.WriteLine("Nhập mã xe cho thuê: ");
            int maxechothue = int.Parse(Console.ReadLine());
            return maxechothue;
        }
        public int soluong()
        {
            Console.WriteLine("Nhập số lượng: ");
            int sl = int.Parse(Console.ReadLine());
            return sl;
        }
        public string tenxechothue()
        {
            Console.WriteLine("Nhập tên xe cho thuê: ");
            string tenxe = Console.ReadLine();
            return tenxe;
        }
        public string mahd()
        {
            Console.WriteLine("Nhập mã hóa đơn : ");
            string mahd = Console.ReadLine();
            return mahd;
        }
        public string tennvgiao()
        {
            Console.WriteLine("Nhập tên nhân viên giao: ");
            string ten = Console.ReadLine();
            return ten;
        }
        public int mahdn(ArrayList arrayList)
        {
            int mahdn = arrayList.Count;
            return mahdn + 1000;
        }
        public string tenhdn()
        {
            Console.WriteLine("Nhập tên hóa đơn nhập: ");
            string tenhdn = Console.ReadLine();
            return tenhdn;
        }

    }
}