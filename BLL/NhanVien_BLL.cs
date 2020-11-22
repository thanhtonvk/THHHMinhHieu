using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.BLL
{
    class NhanVien_BLL
    {
        public static void NhapNhanVien(ArrayList arrayList)
        {
            //int manv, string tennv, string ngaysinh, string gioitinh, string ngayvaolv, string pass, string loainv
            int manv = arrayList.Count + 1000;
            Console.WriteLine("Nhập tên nhân viên");
            string tenv = Nhap.NhapString();
            Console.WriteLine("Nhập ngày sinh");
            string ngaysinh = Nhap.NhapString();
            Console.WriteLine("Nhập giới tính");
            string gioitinh = Nhap.NhapString();
            Console.WriteLine("Nhập ngày vào làm việc");
            string ngayvao = Nhap.NhapString();
            Console.WriteLine("Nhập pass: ");
            string pass = Nhap.NhapString();
            Console.WriteLine("Nhập loại nhân viên");
            string loainv = Nhap.NhapString();
            arrayList.Add(new NhanVien(manv, tenv, ngaysinh, gioitinh, ngayvao, pass, loainv));
        }
        public static void HienThi(NhanVien ob)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}||{6,-20}|", ob.Manv, ob.Tennv, ob.Ngaysinh, ob.Gioitinh, ob.Ngayvaolv, ob.Pass, ob.Loainv);
        }
        public static void HienThiAll(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}||{6,-20}|", "Mã nhân viên", "Tên nhân viên", "Ngày sinh", "Giới tính", "Ngày vào làm việc", "Pass", "Loại nhân viên");
            foreach (NhanVien ob in arrayList)
            {
                HienThi(ob);
            }
        }
        public static NhanVien Find(ArrayList arrayList)
        {
            NhanVien kq = null;
            Console.WriteLine("Nhập mã nhân viên: ");
            string tk = Nhap.NhapString();
            foreach (NhanVien ob in arrayList)
            {
                if (tk == ob.Manv.ToString())
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}||{6,-20}|", "Mã nhân viên", "Tên nhân viên", "Ngày sinh", "Giới tính", "Ngày vào làm việc", "Pass", "Loại nhân viên");
            HienThi(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            NhanVien ob = Find(arrayList);
            Console.WriteLine("Nhập tên nhân viên");
            ob.Tennv = Nhap.NhapString();
            Console.WriteLine("Nhập ngày sinh");
            ob.Ngaysinh = Nhap.NhapString();
            Console.WriteLine("Nhập giới tính");
            ob.Gioitinh = Nhap.NhapString();
            Console.WriteLine("Nhập ngày vào làm việc");
            ob.Ngayvaolv = Nhap.NhapString();
            Console.WriteLine("Nhập pass: ");
            ob.Pass = Nhap.NhapString();
            Console.WriteLine("Nhập loại nhân viên");
            ob.Loainv = Nhap.NhapString();
        }
    }
}
