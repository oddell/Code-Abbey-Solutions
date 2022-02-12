using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_Abbey_Solutions
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine(Problem1());
            Console.WriteLine(Problem2());
            Problem3().ForEach(Console.WriteLine);

        }

        /// <summary>
        /// Sum "A+B"
        /// </summary>
        static int Problem1()
        {
            Console.WriteLine("Problem1()");
            List<int> intData = Utilities.ReadFile("1");

            int solution = intData.Sum();

            return solution;
        }

        /// <summary>
        /// Sum in Loop (Full List)
        /// </summary>
        static int Problem2()
        {
            Console.WriteLine("Problem2()");
            List<int> intData = Utilities.ReadFile("2");

            int solution = intData.Sum();

            return solution;

        }

        /// <summary>
        /// Sum in Loop (Two Columns)
        /// </summary>
        static List<int> Problem3()
        {
            Console.WriteLine("Problem3()");
            List<int> intData = Utilities.ReadFile("3");

            List<int> solution = new List<int>();

            for(int i = 0; i < intData.Count; i += 2)
            {
                solution.Add(intData[i] + intData[i+1]);
            }

            return solution;
        }
    }
}
