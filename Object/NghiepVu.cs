using System;
using System.Collections.Generic;
using System.Text;

namespace THHHMinhHieu.Object
{
    class NghiepVu
    {
        private int mahdn, manvnhan, soluong, maxechothue, tongtien;
        private string tenhdn, tennvgiao, mahd, tenxechothue;
        private double giachothue;
        static NhanVien nhanvien = new NhanVien();
        public NghiepVu()
        {

        }
        public NghiepVu(int mahdn,string tenhdn,string tennvgiao,string mahd,string tenxechothue,int soluong,int maxechothue,int tongtien,double giachothue)
        {
            this.mahdn = mahdn;
            this.tenhdn = tenhdn;
            this.tennvgiao = tennvgiao;
            manvnhan = nhanvien.Manv;
            this.mahd = mahd;
            this.tenxechothue = tenxechothue;
            this.soluong = soluong;
            this.maxechothue = maxechothue;
            this.tongtien = tongtien;
            this.giachothue = giachothue;
        }
        override
            public string ToString() => mahd + "#" + tenhdn + "#" + tennvgiao + "#" + mahd + "#" + tenxechothue + "#" + soluong + "#" + maxechothue + "#" + tongtien + "#" + giachothue;
        public int Mahdn { get => mahdn; set => mahdn = value; }
        public int Manvnhan { get => manvnhan; set => manvnhan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Maxechothue { get => maxechothue; set => maxechothue = value; }
        public int Tongtien { get => tongtien; set => tongtien = value; }
        public string Tenhdn { get => tenhdn; set => tenhdn = value; }
        public string Tennvgiao { get => tennvgiao; set => tennvgiao = value; }
        public string Mahd { get => mahd; set => mahd = value; }
        public string Tenxechothue { get => tenxechothue; set => tenxechothue = value; }
        public double Giachothue { get => giachothue; set => giachothue = value; }
    }
}
