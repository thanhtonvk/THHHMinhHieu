using System;
using System.Collections;
using THHHMinhHieu.GUI;
using System.Text;
namespace THHHMinhHieu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            DangNhap_GUI.Chon(arrayList);
        }
    }
}
