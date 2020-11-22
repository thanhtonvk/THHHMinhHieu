using System;
using System.Collections.Generic;
using System.Text;

namespace THHHMinhHieu.BLL
{
    class Nhap
    {
        public static string NhapString()
        {
            string str;
            while (true)
            {
                str = Console.ReadLine();
                if (str != "") break;
            }
            return str;
        }
        public static float NhapFloat()
        {
            float fl;
            while (true)
            {
                fl = float.Parse(Console.ReadLine());
                if (fl > 0) break;
            }
            return fl;
        }
        public static double NhapDouble()
        {
            double fl;
            while (true)
            {
                fl = double.Parse(Console.ReadLine());
                if (fl > 0) break;
            }
            return fl;
        }
        public static int NhapInt()
        {
            int fl;
            while (true)
            {
                fl = int.Parse(Console.ReadLine());
                if (fl > 0) break;
            }
            return fl;
        }
    }
}
