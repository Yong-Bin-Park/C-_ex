using System;



namespace ex2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("섭씨 온도값 입력: ");
            int cel = int.Parse(Console.ReadLine());

            double fah = (9 / 5.0) * cel + 32;

            Console.WriteLine("화씨 온도값은: " + fah);

        }
}
}
