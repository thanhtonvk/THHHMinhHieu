using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.DocGhiFile
{
    class GiaBan_DAL
    {
        static string filepath = "giaban.txt";
        public static void DocFile(ArrayList arrayList)
        {
            //int magiachothue,int maxe,double giachothue,string donvitinh,string ngayad,string ngaythoiad
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new GiaBan(int.Parse(line.Split("#")[0]),int.Parse(line.Split("#")[1]),double.Parse(line.Split("#")[2]),line.Split("#")[3],line.Split("#")[4],line.Split("#")[5]));
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
                    foreach (GiaBan giaBan in arrayList)
                    {
                        streamWriter.WriteLine(giaBan.ToString());
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
