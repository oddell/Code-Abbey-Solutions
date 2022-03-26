using System;
using System.Collections.Generic;
using System.Linq;

namespace Code_Abbey_Solutions
{
    class Program
    {


        static void Main(string[] args)
        {
            //Console.WriteLine(Problem1());
            //Console.WriteLine(Problem2());
            //Problem3().ForEach(Console.WriteLine);
            //Problem4().ForEach(Console.WriteLine);
            //Problem5().ForEach(Console.WriteLine);
            //Problem6().ForEach(Console.WriteLine);
            //Problem7().ForEach(Console.WriteLine);
            //Problem8().ForEach(Console.WriteLine);
            //Problem9().ForEach(Console.WriteLine);
            //Problem10().ForEach(Console.WriteLine);
            Console.WriteLine(Problem15());        }

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

            for (int i = 0; i < intData.Count; i += 2)
            {
                solution.Add(intData[i] + intData[i + 1]);
            }

            return solution;
        }

        /// <summary>
        /// Minimum of Two
        /// </summary>
        static List<int> Problem4()
        {
            Console.WriteLine("Problem4()");
            List<int> intData = Utilities.ReadFile("4");

            List<int> solution = new List<int>();

            for (int i = 0; i < intData.Count; i += 2)
            {
                if (intData[i] < intData[i + 1])
                {
                    solution.Add(intData[i]);
                }
                else
                {
                    solution.Add(intData[i + 1]);
                }
            }
            return solution;
        }
        /// <summary>
        /// Minimum of Three
        /// </summary>
        static List<int> Problem5()
        {
            Console.WriteLine("Problem5()");
            List<int> intData = Utilities.ReadFile("5");

            List<int> solution = new List<int>();

            for (int i = 0; i < intData.Count; i += 3)
            {
                solution.Add(new List<int> { intData[i], intData[i + 1], intData[i + 2] }.AsQueryable().Min());
            }
            return solution;
        }
        /// <summary>
        /// Rounding
        /// Learned that double from two divided integers wont give
        /// decimals, needs to be double from two divided doubles
        /// </summary>
        static List<int> Problem6()
        {
            Console.WriteLine("Problem6()");
            List<int> intData = Utilities.ReadFile("6");

            List<int> solution = new List<int>();
            double comparable;

            for (int i = 0; i < intData.Count; i += 2)
            {
                comparable = (double)intData[i] / (double)intData[i + 1];
                solution.Add(Convert.ToInt32(Math.Round(comparable, MidpointRounding.AwayFromZero)));
            }

            return solution;
        }
        /// <summary>
        /// Fahrenheit to Celsius
        /// </summary>
        static List<int> Problem7()
        {
            Console.WriteLine("Problem7()");
            List<int> intData = Utilities.ReadFile("7");

            List<int> solution = new List<int>();

            for (int i = 1; i < intData.Count; i += 1)
            {
                solution.Add(Convert.ToInt32(((double)intData[i] - 32) / 1.8));
            }

            return solution;
        }
        /// <summary>
        /// Arithmetic Progression
        /// Used for loop with (a1 + (n-1)d). Can this be done better with actual equation?
        /// https://wikimedia.org/api/rest_v1/media/math/render/svg/1ab378eeed4413f133e486dd0caf0daf34e79daa
        /// </summary>
        static List<int> Problem8()
        {
            Console.WriteLine("Problem8()");
            List<int> intData = Utilities.ReadFile("8");

            List<int> solution = new List<int>();
            int sum;

            for (int i = 1; i < intData.Count; i += 3)
            {
                sum = 0;
                for (int count = 1; count < intData[i + 2] + 1; count += 1)
                {
                    sum += intData[i] + ((count - 1) * intData[i + 1]);
                }

                solution.Add(sum);
            }

            return solution;
        }

        /// <summary>
        /// Triangles
        /// </summary>
        static List<int> Problem9()
        {
            Console.WriteLine("Problem9()");
            List<int> intData = Utilities.ReadFile("9");

            List<int> solution = new List<int>();

            for (int i = 1; i < intData.Count; i += 3)
            {
                int[] sides = { intData[i], intData[i + 1], intData[i + 2] };
                Array.Sort(sides);

                if ((sides[0] + sides[1]) > sides[2])
                {
                    solution.Add(1);
                }
                else
                {
                    solution.Add(0);
                }

            }

            return solution;
        }
        /// <summary>
        /// Linear Function
        /// (y - y1) / (x - x1) = m
        /// y = mx + c
        /// y - mx = c
        /// </summary>
        static List<string> Problem10()
        {
            Console.WriteLine("Problem10()");
            List<int> intData = Utilities.ReadFile("10");

            List<string> solution = new List<string>();

            int m;
            int c;

            for (int i = 1; i < intData.Count; i += 4)
            {
                m = (intData[i + 1] - intData[i + 3]) / (intData[i] - intData[i + 2]);

                c = intData[i + 1] - (m * intData[i]);

                solution.Add($"({m} {c})");

            }

            return solution;
        }
        static List<int> Problem11()
        {
            Console.WriteLine("Problem11()");
            List<int> intData = Utilities.ReadFile("11");

            List<int> solution = new List<int>();

            for (int i = 1; i < intData.Count; i += 3)
            {
                solution.Add((intData[i]*intData[i+1])+intData[i+2]);

            }

            return solution;
        }

        //<summary>
        //Maximum of Array
        //Use linear search to return greatest value
        //</summary>

        static string Problem15()
        {
            Console.WriteLine("Problem15()");
            List<int> intData = Utilities.ReadFile("15");

            string solution;

            int maximum = intData[0];

            int minimum = intData[0];

            for (int i = 1; i < intData.Count; i += 1)
            {
                if (intData[i] > maximum)
                {
                    maximum = intData[i];
                }

                if (intData[i] < minimum)
                {
                    minimum = intData[i];
                }
            }

            solution = ($"{maximum} {minimum}");

            return solution;
        }
    }
}

