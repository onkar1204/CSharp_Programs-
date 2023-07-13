using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Example
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];
            age[0] = 10;
            age[1] = 15;
            age[2] = 20;
            age[3] = 25;
            age[4] = 30;
            for (int i = 5-1; i >= 0; i--)
            {
                Console.WriteLine(age[i]);
            }
            Console.ReadLine();
        }
    }
}
