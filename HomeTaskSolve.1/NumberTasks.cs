using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSolve._1
{
    internal class NumberTasks
    {
        internal int EnterNumber()
        {
             Console.WriteLine("Enter the number");
          int n = int.Parse(Console.ReadLine());

            return n;
        }
        
        internal int GetReverseNumber(int number)
        {
            int r;
            int reverseNumber = 0;
            int n = (int)Math.Log10(number);

            while (number != 0)
            {
                r = number % 10;
                reverseNumber += r * (int)Math.Pow(10, n--);
                number /= 10;
            }

            return reverseNumber;
        }
    }
   
}
