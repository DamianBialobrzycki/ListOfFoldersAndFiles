using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ListOfFoldersAndfoldersArrays
{
    class Program
    {
        //static long ShowFiles(string location)
        //{
        //    long totalSize = 0;
        //    FileInfo finfo;
        //    string[] filesArray = Directory.GetFiles(location);
        //    for (int j = 0; j < filesArray.Length; j++)
        //    {
        //        finfo = new FileInfo(filesArray[j]);

        //        long length = finfo.Length;
        //        totalSize += length;
        //        Console.WriteLine(filesArray[j] + " " + length + " B");
        //       // Console.WriteLine(length);

        //    }
        //    return totalSize;
        //}
        static void Show(string location)
        {
            string[] filesArray = Directory.GetFiles(location);
            string[] foldersArray = Directory.GetDirectories(location);
            FileInfo finfo;
            long sum = 0;

            for (int j = 0; j < filesArray.Length; j++)
            {
                finfo = new FileInfo(filesArray[j]);

                long length = finfo.Length;
                sum += length;
                Console.WriteLine(filesArray[j] + " " + length + " B");
                //Console.WriteLine(length);

            }
           // Console.WriteLine("Sum: " + sum);

            for (int i = 0; i < foldersArray.Length; i++)
            {
                
                Console.WriteLine(foldersArray[i]);
                Show(foldersArray[i]);
            }

            
        }



        static void Main(string[] args)
        {
            //FileInfo f = new FileInfo(".\\Program.cs");
           // Console.WriteLine(f.Length);
            Show("C:\\VS");
            Console.WriteLine();
        }
    }
}
