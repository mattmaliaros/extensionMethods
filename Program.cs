using System;
using System.Collections.Generic;
using System.Linq;

//Linq -- Language Integrated Query--- Capability to query objects

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed a very long blog post blah blah blah...";
            var shortened = post.Shorten(5);
            IEnumerable<int> numbers = new List<int>() {1,3,4,9,2,12,18};
            var largest = numbers.Max();
            Console.WriteLine(shortened); //shortens to 5 words
            Console.WriteLine(largest); // returns largest number in list
        }
    }
}
