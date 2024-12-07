using System;

namespace for_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = a; i <= 2 * a; i++)
            {
                sum += i * i ;
            }
            Console.WriteLine(sum);
        }
    }
}