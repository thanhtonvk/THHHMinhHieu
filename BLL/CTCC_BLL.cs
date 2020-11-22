using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.BLL
{
    class CTCC_BLL
    {
        public static void NhapCTCC(ArrayList arrayList)
        {
            //int mactcc,string tenctcc,string diachi,string sdt
            int mactcc = arrayList.Count + 1000;
            Console.WriteLine("Nhập ten CTCC");
            string tenctcc = Nhap.NhapString();
            Console.WriteLine("Nhập địa chỉ");
            string diachi = Nhap.NhapString();
            Console.WriteLine("Nhập số điện thoại");
            string sdt = Nhap.NhapString();
            arrayList.Add(new CTCC(mactcc, tenctcc, diachi, sdt));
        }
        public static void HienThiCTCC(CTCC cTCC)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", cTCC.Mactcc, cTCC.Tenctcc, cTCC.Diachi, cTCC.Sdt);
        }
        public static void HienThiAllCTCC(ArrayList arrayList)
        {
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Mã CTCC", "Tên CTCC", "Địa chỉ", "Số điện thoại");
            foreach (CTCC cTCC in arrayList)
            {
                HienThiCTCC(cTCC);
            }
        }
        public static CTCC Find(ArrayList arrayList)
        {
            CTCC kq = null;
            Console.WriteLine("Nhập mã ctcc: ");
            string tk = Nhap.NhapString();
            foreach (CTCC cTCC in arrayList)
            {
                if (tk == cTCC.Mactcc.ToString())
                {
                    kq = cTCC;
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
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", "Mã CTCC", "Tên CTCC", "Địa chỉ", "Số điện thoại");
            HienThiCTCC(Find(arrayList));
        }
        public static void Sua(ArrayList arrayList)
        {
            CTCC cTCC = Find(arrayList);
            Console.WriteLine("Nhập tên CTCC");
            cTCC.Tenctcc = Nhap.NhapString();
            Console.WriteLine("Nhập địa chỉ");
            cTCC.Diachi = Nhap.NhapString();
            Console.WriteLine("Nhập số điện thoại");
            cTCC.Sdt = Nhap.NhapString();
        }
    }
}
