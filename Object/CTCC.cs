using System;
using System.Collections.Generic;
using System.Text;

namespace THHHMinhHieu.Object
{
    class CTCC
    {
        private int mactcc;
        private string tenctcc, diachi, sdt;
        public CTCC()
        {

        }
        public CTCC(int mactcc,string tenctcc,string diachi,string sdt)
        {
            this.mactcc = mactcc;
            this.tenctcc = tenctcc;
            this.diachi = diachi;
            this.sdt = sdt;
        }
        override
        public string ToString() => mactcc + "#" + tenctcc + "#" + diachi + "#" + sdt;
        public int Mactcc { get => mactcc; set => mactcc = value; }
        public string Tenctcc { get => tenctcc; set => tenctcc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
