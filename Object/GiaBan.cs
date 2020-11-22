using System;
using System.Collections.Generic;
using System.Text;

namespace THHHMinhHieu.Object
{
    class GiaBan
    {
        private int magiachothue;
        private int maxe;
        private double giachothue;
        private string donvitinh;
        private string ngayad;
        private string ngaythoiad;
        override
            public string ToString()
        {
            return magiachothue + "#" + maxe + "#" + giachothue + "#" + donvitinh + "#" + ngayad + "#" + ngaythoiad;
        }
        public GiaBan()
        {

        }
        public GiaBan(int magiachothue,int maxe,double giachothue,string donvitinh,string ngayad,string ngaythoiad)
        {
            this.magiachothue = magiachothue;
            this.maxe = maxe;
            this.giachothue = giachothue;
            this.donvitinh = donvitinh;
            this.ngayad = ngayad;
            this.ngaythoiad = ngaythoiad;
        }
        public int Magiachothue { get => magiachothue; set => magiachothue = value; }
        public int Maxe { get => maxe; set => maxe = value; }
        public double Giachothue { get => giachothue; set => giachothue = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public string Ngayad { get => ngayad; set => ngayad = value; }
        public string Ngaythoad { get => ngaythoiad; set => ngaythoiad = value; }
    }
}
