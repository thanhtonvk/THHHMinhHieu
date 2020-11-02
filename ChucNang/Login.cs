using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using THHHMinhHieu.DocGhiFile;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.ChucNang
{
    class Login
    {
        public bool DangNhap(ArrayList arrayList)
        {
            bool kt = false;
            ReadDangNhap readDangNhap = new ReadDangNhap();
            readDangNhap.DangNhap(arrayList);
            foreach (DangNhap dangNhap in arrayList)
            {
                if (dangNhap.User.Equals(UserName()) && dangNhap.Password.Equals(Password())){
                    kt = true;
                }
            }

            return kt;
        }
        private string UserName()
        {
            string tk;
            while (true)
            {
                Console.WriteLine("Nhập tài khoản: ");
                tk = Console.ReadLine();
                if (tk != "") break;
            }
            return tk;
        }
        private string Password()
        {
            string pass;
            while (true)
            {
                Console.WriteLine("Nhập mật khẩu: ");
                pass = Console.ReadLine();
                if (pass != "") break;
            }
            return pass;
        }
    }
}
