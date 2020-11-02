using System;
using System.Collections.Generic;
using System.Text;

namespace THHHMinhHieu.Object
{
    class NhanVien
    {
        private int manv;
        private string tennv, ngaysinh, gioitinh, ngayvaolv, pass, loainv;
        public NhanVien()
        {

        }
        public NhanVien(int manv, string tennv, string ngaysinh, string gioitinh, string ngayvaolv, string pass, string loainv) {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.ngayvaolv = ngayvaolv;
            this.pass = pass;
            this.loainv = loainv;
        }
        override
        public string ToString() => manv + "#" + ngaysinh + "#" + gioitinh + "#" + ngayvaolv + "#" + pass + "#" + loainv;
        public int Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngayvaolv { get => ngayvaolv; set => ngayvaolv = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Loainv { get => loainv; set => loainv = value; }
    }
}
