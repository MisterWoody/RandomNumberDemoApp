using System;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(random.Next(5,11));
                Console.WriteLine(random.NextDouble() * 10);
                //SimpleMethod(random); // Best practice - do this, don't create a new object each time
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next()); // Beware - do NOT create a new random object here with a seed as that leads to potential security holes,
        }
    }
}
