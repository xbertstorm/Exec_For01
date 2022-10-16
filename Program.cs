using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入三角形長度：");
            string thelength = Console.ReadLine();

            for (int i = int.Parse(thelength); i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            Console.Read();
        }
    }
}
