using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.DocGhiFile
{
    class TinhLuong_DAL
    {
        //int matl, int manv, float songaylv, double thuong, double luongcoban
        static string filepath = "tinhluong.txt";
        public static void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new TinhLuong(int.Parse(line.Split("#")[0]),int.Parse(line.Split("#")[1]),float.Parse(line.Split("#")[2]),double.Parse(line.Split("#")[3]),double.Parse(line.Split("#")[4])));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void GhiFile(ArrayList arrayList)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(filepath))
                {
                    foreach (TinhLuong tinhLuong in arrayList)
                    {
                        streamWriter.WriteLine(tinhLuong.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
