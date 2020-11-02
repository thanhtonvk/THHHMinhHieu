using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.DocGhiFile
{
    class ReadDangNhap
    {
        static string filepath = "dangnhap.txt";
        public void DangNhap(ArrayList arrayList)
        {
            try
            {
                using(StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new DangNhap(line.Split("#")[0], line.Split("#")[1]));
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void SignUp()
        {
            using (StreamWriter streamWriter = new StreamWriter(filepath))
            {
                streamWriter.WriteLine(new DangNhap(UserName(), Password()));
            }
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
