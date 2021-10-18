using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumUpNumbers_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "2 apples, 12 oranges";
            int y = sumUpNumbers(s);
            Console.WriteLine(y);
        }

        static int sumUpNumbers(string inputString)
        {
            string cleanStr = Regex.Replace(inputString, "[^0-9]", " ");
            string[] arr = cleanStr.Split(' ');
            int totalItems = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int items = 0;
                if (Int32.TryParse(arr[i], out items))
                {
                    totalItems += items;
                }
            }

            return totalItems;
        }
    }
}
