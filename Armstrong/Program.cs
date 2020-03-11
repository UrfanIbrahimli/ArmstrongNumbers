using System;
using System.Collections.Generic;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Intervali daxil edin\n");
                Console.Write("a -dan = ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("b -ye = ");
                int b = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                Console.WriteLine("\n-----------------------");
                for (int i = a; i < b; i++)
                {
                    var result = GetArmstrongNumber(i);
                    if (result.Item1)
                    {
                        counter++;
                        Console.WriteLine(result.Item2);
                    }
                }
                Console.WriteLine($"\nArmstronq ededlerin sayi: {counter}");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private static Tuple<bool,int> GetArmstrongNumber(int number)
        {
            int n = 0;
            int currentNumber = number;
            while (number > 0)
            {
                int q = number % 10;
                number /= 10;
                n += CustomPow(q, 3);
            }
            if(currentNumber==n)
                return Tuple.Create<bool, int>(true, n);
            return Tuple.Create<bool, int>(false, n);
        }


        private static int CustomPow(int x, short y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}
