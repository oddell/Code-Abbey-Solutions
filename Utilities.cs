using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Abbey_Solutions
{
    public class Utilities
    {
        
        public static string[] ReadFile(string problem)
        {
            string absolutePath = @"C:\Users\Matt\source\repos\Code Abbey Solutions";
            string input = System.IO.File.ReadAllText(absolutePath+@$"\Text Files\Problem {problem}.txt");

            string[] output = input.Split(" ");
            return output;
        }

        public static List<int> FetchProblemData(string problemNo)
        {
            List<int> intData = new List<int>();
            string[] stringData = ReadFile(problemNo);
            foreach (string number in stringData)
            {
                intData.Add(Int32.Parse(number));
            }

            return intData;
        }
    }
}
