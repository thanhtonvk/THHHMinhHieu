using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.Nhap
{
    class NhapNhanVien
    {
        //int manv, string tennv, string ngaysinh, string gioitinh, string ngayvaolv, string pass, string loainv
        public void NhapThongTinNhanVien(ArrayList arrayList)
        {
            arrayList.Add(new NhanVien());
        }
        public void pass()
        {
            Console.WriteLine("Nhập pass: ");
            string pass = Console.ReadLine();
            return pass;

        }
        public string ngayvaolamviec()
        {
            Console.WriteLine("Nhập ngày vào làm việc: ");
            string ngayvao = Console.ReadLine();
            return ngayvao;
        }
        public string ngaysinh()
        {
            Console.WriteLine("Nhập ngày sinh: ");
            string ngaysinh = Console.ReadLine();
            return ngaysinh;
        }
        public string tennv()
        {
            Console.WriteLine("Nhập tên nhân viên: ");
            string tennv = Console.ReadLine();
            return tennv;
        }
        public int manv(ArrayList arrayList)
        {
            int manv = arrayList.Count;
            return manv + 1000;
        }

    }
}
