using System.Collections.Generic;
using System.Net;
using System.Reflection;
using CodeWars.ComponentsForWorkWithArray;

namespace CodeWars
{
    public delegate int[] Arrat(int[] arr);

    public delegate void Not(int[] arr);

    internal class Program
    {
        public static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        // func - prinyal / otdal

        // Action - sdelal


        static void Main(string[] args)
        {

            Console.ReadKey();
            Console.WriteLine("Stas kq");
        }
    }
}