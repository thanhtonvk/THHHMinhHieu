﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using THHHMinhHieu.Object;

namespace THHHMinhHieu.DocGhiFile
{
    class DocGhiFileGiaBan
    {
        static string filepath = "giaban.txt";
        public void DocFile(ArrayList arrayList)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        arrayList.Add(new GiaBan(int.Parse(line.Split("#")[0]),double.Parse(line.Split("#")[1]),line.Split("#")[2],line.Split("#")[3],line.Split("#")[3]));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GhiFile(ArrayList arrayList)
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
