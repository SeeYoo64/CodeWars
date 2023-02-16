using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public class SearchEngins
    {
        public static void BinarySearch(int[] arr)
        {
            int First = 0;
            int Last = arr.Length - 1;
            int middle = 0;
            int find = -999;

            while (find < 0 || find > 999)
            {
                try
                {
                    Console.WriteLine("\nEnter num from arr");
                    find = Int32.Parse(Console.ReadLine());
                    if (Array.Exists(arr, element => element == find)) ;
                    else throw new ExceptionNotExistInArray("Your num doesnt exist in arr");
                }
                catch (ExceptionNotExistInArray e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

            while (arr[middle] != find)
            {
                middle = (First + Last) / 2;
                if (find < arr[middle])
                {
                    Last = middle - 1;
                }
                else if (find > arr[middle])
                {
                    First = middle + 1;
                }
            }

            Console.WriteLine("Position entered num " + find + " - " + middle);
        }


    }
}
