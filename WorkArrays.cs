using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class WorkArrays
    {
        public static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Program.Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            return arr;
        }
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
        public static int[] WriteArray(int[] arr)
        {
            Console.WriteLine("\nYour sorted array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = " + arr[i] + ", ");
            }
            return arr;
        }
    }

}
