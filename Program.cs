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

        }

        static int Problem1()
        {
            List<int> intData = Utilities.FetchProblemData("1");

            int solution = intData.Sum();

            return solution;
        }
        
        static int Problem2()
        {
            List<int> intData = Utilities.FetchProblemData("2");

            int solution = intData.Sum();

            return solution;

        }
    }
}
