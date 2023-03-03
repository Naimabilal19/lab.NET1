using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApp20
{
    //1
    class Program
    {
        static void Main(string[] args)
        {
            //1
            try
            {
                int[] arr = new int[100];
                StreamWriter sw = new StreamWriter("MyFile.txt", true);
                StreamWriter sw1 = new StreamWriter("MyFile2.txt", true);
                Random r = new Random();
                int j = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(100);
                }
                Console.SetOut(sw);
                for (int i=0;i<arr.Length;i++)
                {
                    if(arr[i]%1==0)
                    {
                        Console.WriteLine("{ 0 }", arr[i]);
                    }
                }
                sw.Close();

                Console.SetOut(sw1);
                for (int i = 0; i < arr.Length; i++)
                {
                    int a = 0,b=1;
                    int tenp = a;
                    a = b;
                    b = tenp + b;
                    Console.WriteLine("{0}", arr[i]);
                }
                sw1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }
    //2
   class Stringwr
    {
        static void Main(string[] args)
        {
            FileStream File = new FileStream("File.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(File);
            string Data = "1" + "\n" + "2 " + "\n" + "3" + "\n" + "4";
            SW.WriteLine(Data);
            SW.WriteLine("- - - -");
            SW.WriteLine(Data.Replace("line", "str"));
            SW.Close();
            File.Close();
        }
}
   //3
    class Moder3
    {
        static void Main(string[] args)
        {
            FileStream File = new FileStream("File.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(File);
            string Data = "1 line" + "\n" + "2 line" + "\n" + "3 line" + "\n" + "4 line";
            SW.WriteLine(Data);
            SW.WriteLine("- - - -");
            string Word = Console.ReadLine();
            string Stars = string.Concat(Enumerable.Repeat("*", Word.Length));
            SW.WriteLine(Data.Replace(Word, Stars));
            SW.Close();
            File.Close();
        }
    }

    //4
    class File4
    {
        static void Main(string[] args)
        {
            string Path = Console.ReadLine();
            FileStream FileFromUser = new FileStream(Path, FileMode.Open, FileAccess.Read);
            StreamReader SR = new StreamReader(FileFromUser);
            string DataFromFile = SR.ReadToEnd();
            string ReverseData = DataFromFile.MyReverse();
            SR.Close();
            FileFromUser.Close();
            FileStream ReverseFile = new FileStream("ReverseFile.txt", FileMode.Create, FileAccess.Write);
            StreamWriter SW = new StreamWriter(ReverseFile);
            SW.WriteLine(ReverseData);
            SW.Close();
            ReverseFile.Close();
        }
    }
}
