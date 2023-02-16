using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.ComponentsForWorkWithArray
{
    internal class WriterOnConsole
    {
        public static  void WriteArray(int[] arr)
        {
            Console.WriteLine("\nYour array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = " + arr[i] + ", ");
            }         
        }
    }
}
