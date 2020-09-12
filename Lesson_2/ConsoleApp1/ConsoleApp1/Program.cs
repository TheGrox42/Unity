using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            //int n = 0;
            /*switch (n)
            {
            case 0:Console.WriteLine("H");
            break;
            case 1:Console.WriteLine("e");
            break;
            case 5:Console.WriteLine("l");
            break;
            default :Console.WriteLine("p");
            break;
            }*/
            switch (s)
            {
            case "0": Console.WriteLine("false");
            break;
            case "1": Console.WriteLine("true");
            break;
            case "1024":Console.WriteLine("ten!!");
            break;
            default: Console.WriteLine("none");
            break;
            }
            //Console.WriteLine(Convert.ToInt32("0101001101", 2));
            string p = "";
            long[] arr = new long[10];
            arr = new long[]{ 0L, 1L, 0L, 1L, 0L, 0L, 1L, 1L, 0L, 1L};
            for (int i = 0; i<arr.Length; i++)
            {
                p += arr[i];
                Console.WriteLine(Convert.ToInt32(p, 2));
            }
            int j = 0;
            for( ; ; )
            {
                j++;
                if (j > 10) { break; }
                Console.WriteLine(j);
            }
            int t = 10;
            while (t > 0)
            {
                Console.WriteLine(t);
                t--;
            }
            int a = -10;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
        }
    }
}
