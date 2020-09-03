using System;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(1);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(5,11));
            }

            Console.ReadLine();
        }
    }
}
