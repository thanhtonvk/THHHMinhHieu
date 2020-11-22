using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace THHHMinhHieu.Object
{
    class TinhLuong
    {

        private int matl;
        private int manv;
        private float songaylv;
        private double thuong, luongcoban;
        public TinhLuong()
        {

        }
        public TinhLuong(int matl, int manv, float songaylv, double thuong, double luongcoban)
        {
            this.matl = matl;
            this.manv = manv;
            this.songaylv = songaylv;
            this.thuong = thuong;
            this.luongcoban = luongcoban;

        }
        override
            public string ToString() => matl + "#" + manv + "#" + songaylv + "#" + thuong + "#" + luongcoban;
        public int Matl { get => matl; set => matl = value; }
        public int Manv { get => manv; set => manv = value; }
        public float Songaylv { get => songaylv; set => songaylv = value; }
        public double Thuong { get => thuong; set => thuong = value; }
        public double Luongcoban { get => luongcoban; set => luongcoban = value; }
        public double Thanhtien()
        {
            return luongcoban*songaylv + thuong;
        }
    }
}
