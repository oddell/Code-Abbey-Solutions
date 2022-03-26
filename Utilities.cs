using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Abbey_Solutions
{
    public class Utilities
    {

        public static List<int> ReadFile(string problem)
        {
            string[] stringArray = new string[] {};

            foreach (var line in System.IO.File.ReadLines(Environment.CurrentDirectory + @$"/Text Files/Problem {problem}.txt"))
            {
                stringArray = stringArray.Concat(line.Split(" ")).ToArray();
            }

            return ArrayToList(stringArray);
        }

        public static List<int> ArrayToList(string[] stringArray)
        {
            List<int> intData = new List<int>();
            foreach (string number in stringArray)
            {
                intData.Add(Int32.Parse(number));
            }

            return intData;
        }
    }
}
