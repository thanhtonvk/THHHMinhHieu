using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.DocGhiFile
{
    class NghiepVu_DAL
    {
        static string filepath = "nghiepvu.txt";
        public static void DocFile(ArrayList arrayList)
        {
            //int mahdn,string tenhdn,string tennvgiao,string mahd,string tenxechothue,int soluong,int maxechothue,int tongtien,double giachothue
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new NghiepVu(int.Parse(line.Split("#")[0]), line.Split("#")[1], line.Split("#")[2], line.Split("#")[3], line.Split("#")[4],int.Parse(line.Split("#")[5]),int.Parse(line.Split("#")[6]),int.Parse(line.Split("#")[7]),double.Parse(line.Split("#")[7])));
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
                    foreach (NghiepVu nghiepVu in arrayList)
                    {
                        streamWriter.WriteLine(nghiepVu.ToString());
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
