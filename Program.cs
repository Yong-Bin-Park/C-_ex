using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, w;

            Console.WriteLine("키 입력:");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("몸무게 입력:");
            w = int.Parse(Console.ReadLine());

            double sw = (h - 100) * 0.9;
            double b = (w / sw) * 100;

            Console.WriteLine("비만도는 " + b);

        }
}
}
