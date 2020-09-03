using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next(5,11)); // set a min and non inclusive max

            //    Console.WriteLine(random.NextDouble() * 10); // get a random double 

            //    //SimpleMethod(random); // Best practice - do this, don't create a new random object each time
            //}

            List<PersonModel> people = new List<PersonModel>
            { 
                new PersonModel {FirstName = "Tim"},
                new PersonModel {FirstName = "Sue"},
                new PersonModel {FirstName = "Mary"},
                new PersonModel {FirstName = "George"},
                new PersonModel {FirstName = "Jane"},
                new PersonModel {FirstName = "Nancy"},
                new PersonModel {FirstName = "Bob"}

            };

            //var sortedPeople = people.OrderBy(x => x.FirstName);

            //foreach (var p in sortedPeople)
            //{
            //    Console.WriteLine(p.FirstName);
            //}
            
            Console.WriteLine("============================");

            // The following is not the most performant, but ok for lists of fifty or so objects
            // For performant shuffles of large datasets - use Fisher-Yates algorithm - see https://stackoverflow.com/questions/273313/randomize-a-listt/1262619#1262619

            var shuffledPeople = people.OrderBy(x => random.Next());

            foreach (var p in shuffledPeople)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next()); // Beware - do NOT create a new random object here with a seed as that leads to potential security holes,
        }
    }

    
    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}
