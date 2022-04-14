using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Reqem daxil edin ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (n != 0)
            {
                s = s + n % 10;
                n = n / 10;
            }
            Console.WriteLine("Reqemlerin cemi: {0}", s);
            
        }
    }
}
