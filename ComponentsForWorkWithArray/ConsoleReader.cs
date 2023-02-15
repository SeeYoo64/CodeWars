using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.ComponentsForWorkWithArray
{
    internal class ConsoleReader
    {
        public static int[] EnterArr()
        {
            Console.WriteLine("How much numbers y'll write?");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];
            Console.WriteLine("Write nums");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            return arr;

        }
    }
}
