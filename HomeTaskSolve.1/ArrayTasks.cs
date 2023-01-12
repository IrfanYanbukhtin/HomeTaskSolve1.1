using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskSolve._1
{
    internal class ArrayTasks
    {
        internal int[] EnterArray()
        {
            Console.WriteLine("The lengh of massive");
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];


            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine($"mass [{i}]=");
                mass[i] = int.Parse(Console.ReadLine());
            }

            return mass;

        }
        internal int[] SqrtArray(int[] mass)
        {
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                {
                    count++;
                }
            }

            int[] sqrtMass=new int[count];
            count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                {
                    sqrtMass[count++]=mass[i];
                }
            }
            return sqrtMass;
        }
        internal void print(int[] mass)
        {
            foreach (var item in mass)
            {
                Console.Write(item + ' ');
            }
        }
    }
}