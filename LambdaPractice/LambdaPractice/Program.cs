using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a funTime List
            List<string> funTimeList = new List<string>() { "blueberry", "apple", "boisonberry", "pear", "strawberry" };

            //print out each item in the fun time list
            //oredered alphabetically
            Console.WriteLine("Ordered alphabetically");
            Console.WriteLine(string.Join(", ", funTimeList.OrderBy(x=> x)));

            //write to the console only the items containing the word 'berry'
            Console.WriteLine("\nOnly contains the word 'berry'");
            Console.WriteLine(string.Join(", ", funTimeList.Where(x=> x.Contains("berry"))));
            Console.WriteLine();

            //write all the non-berry items to the console
            //ordered by the length of the string
            Console.WriteLine(string.Join(", ", funTimeList.Where(x => !x.Contains("berry")).OrderByDescending(x => x.Length)));

            //write only the items that have five or more characters
            Console.WriteLine(string.Join(", ", funTimeList.Where(x=> x.Length >= 5)));

            //write the total number of characters in the funtimelist to the console
            Console.WriteLine("Total numbers of characters: " + funTimeList.Sum(x => x.Length));

            //write the avrage number of characters in the list to the fun time console
            Console.WriteLine("Avrage number of characters: " + funTimeList.Average(x => x.Length));

            //write to the console the number of vowels in each item in the funtimelist
            Console.WriteLine(string.Join("\n", funTimeList.Select( x=> x + " has " + x.Count(y => "aeiou".Contains(y))+ " vowels")));

            //return the shortest string within the list
            Console.WriteLine(funTimeList.OrderBy(x => x.Length).First());



            Console.ReadKey();

            funTimeList[0].ToUpper();

        }
    }
}
