using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.Nhap
{
    class NhapKhoXe
    {
        //int maxe, string tenxe, string maloai, int slnhapve, int slhienco
        public void NhapThongTinKhoXe(ArrayList arrayList)
        {
            arrayList.Add(new KhoXe(maxe(arrayList),tenxe(),maloai(),slnhapve(),slhienco()));
        }
        public int slhienco()
        {
            int slhienco;
            while (true)
            {
                Console.WriteLine("Nhập số lượng hiện có: ");
                slhienco = int.Parse(Console.ReadLine());
                if (slhienco > 0) break;
            }
            return slhienco;
        }
        public int slnhapve()
        {
            int slnhapve;
            while (true)
            {
                Console.WriteLine("Nhập số lượng nhập về: ");
                slnhapve = int.Parse(Console.ReadLine());
                if (slnhapve > 0) break;
            }
            return slnhapve;
        }
        public string maloai()
        {
            string maloai;
            while (true)
            {
                Console.WriteLine("Nhập mã loại: ");
                maloai = Console.ReadLine();
                if (maloai != "") break;
            }
            return maloai;
        }
        public int maxe(ArrayList arrayList)
        {
            int maxe = arrayList.Count;
            return maxe;
        }
        public string tenxe()
        {
            string tenxe;
            while (true)
            {
                Console.WriteLine("Nhập tên xe: ");
                tenxe = Console.ReadLine();
                if (tenxe != "") break;
            }
            return tenxe;
        }
    }
}
