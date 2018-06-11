using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq.Expressions;


namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            var counts = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                double parsedNum = double.Parse(num);
                if (counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum]++;
                }
                else
                {
                    counts[parsedNum] = 1;
                }
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, counts[num]);
            }

        }

    }

}
