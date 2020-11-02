using System;
using System.Collections.Generic;
using System.Text;

namespace THHHMinhHieu.Object
{
    class KhoXe
    {
        private int maxe, slnhapve, slhienco;
        private string tenxe, maloai;
        public KhoXe()
        {

        }
        public KhoXe(int maxe, string tenxe, string maloai, int slnhapve, int slhienco)
        {
            this.maxe = maxe;
            this.tenxe = tenxe;
            this.maloai = maloai;
            this.slnhapve = slnhapve;
            this.slhienco = slhienco;
        }
        override
        public string ToString() => maxe + "#" + tenxe + "#" + maloai + "#" + slnhapve + "#" + slhienco;
        public int Maxe { get => maxe; set => maxe = value; }
        public int Slnhapve { get => slnhapve; set => slnhapve = value; }
        public int Slhienco { get => slhienco; set => slhienco = value; }
        public string Tenxe { get => tenxe; set => tenxe = value; }
        public string Maloai { get => maloai; set => maloai = value; }
    }
}
