using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.Nhap
{
    class NhapCTCC
    {
        public void NhapThongTinCTCC(ArrayList arrayList)
        {
            arrayList.Add(new CTCC(mactcc(arrayList),tenctcc(),diachi(),sdt()));
        }
        //int mactcc,string tenctcc,string diachi,string sdt
        public int mactcc(ArrayList arrayList)
        {
            int mactcc = arrayList.Count;
            return mactcc + 1000;
           
        }
        public string tenctcc()
        {
            string ten;
            while (true)
            {

                Console.WriteLine("Nhập tên CTCC: ");
                ten = Console.ReadLine();
                if (ten != "") break;
            }
            return ten;
        }
        public string diachi()
        {
            string diachi;
            while (true)
            {

                Console.WriteLine("Nhập địa chỉ: ");
                diachi = Console.ReadLine();
                if (diachi != "") break;
            }
            return diachi;
        }
        public string sdt()
        {
            string sdt;
            while (true)
            {

                Console.WriteLine("Nhập số điện thoại: ");
                sdt = Console.ReadLine();
                if (sdt != "") break;
            }
            return sdt;
        }
    }
}
