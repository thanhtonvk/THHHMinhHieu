using System;
using System.Collections;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.Nhap
{
    class NhapGiaBan
    {
        public void NhapThongTinGiaBan(ArrayList arrayList)
        {
            arrayList.Add(new GiaBan(magiachothue(arrayList),maxe(),giachothue(),donvitinh(),ngayad(),ngaythoiad()));
        }
        //int magiachothue,int maxe,double giachothue,string donvitinh,string ngayad,string ngaythoiad
        public string ngayad()
        {
            string ngayad;
            while (true)
            {
                Console.WriteLine("Nhập ngày áp dụng : ");
                ngayad = Console.ReadLine();
                if (ngayad != "") break;
            }
            return ngayad;
        }
        public string ngaythoiad()
        {
            string ngaythoiad;
            while (true)
            {
                Console.WriteLine("Nhập ngày thôi áp dụng : ");
                ngaythoiad = Console.ReadLine();
                if (ngaythoiad != "") break;
            }
            return ngaythoiad;
        }
        public string donvitinh()
        {
            string donvitinh;
            while (true)
            {
                Console.WriteLine("Nhập đơn vị tính : ");
                donvitinh = Console.ReadLine();
                if (donvitinh != "") break;
            }
            return donvitinh;
        }
        public int magiachothue(ArrayList arrayList)
        {
            int magia = arrayList.Count;
            return magia + 1000;
        }
        public int maxe()
        {
            int maxe;
            while (true)
            {
                Console.WriteLine("Nhập mã xe: ");
                maxe = int.Parse(Console.ReadLine());
                if (maxe > 0) break;
            }
            return maxe;
        }
        public double giachothue()
        {
            double gia;
            while (true)
            {
                Console.WriteLine("Nhập giá cho thuê: ");
                gia = double.Parse(Console.ReadLine());
                if (gia > 0) break;
            }
            return gia;
        }
    }
}
