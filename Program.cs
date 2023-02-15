using System.Net;

namespace CodeWars
{
    internal class Program
    {
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            return arr;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("How much numbers y'll write?");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Write nums");
            int[] arr = new int[length];
            int First = 0;
            int Last = length - 1;
            int middle = 0;

            for (int i =0; i < length ;i++)
            {
                arr[i] = Int32.Parse( Console.ReadLine() );
            }
            // SORT
            Sort(arr);

            Console.WriteLine("\nYour sorted array:");
            for (int i = 0; i<arr.Length; i++)
            {
                Console.Write($"arr[{i}] = " + arr[i] + ", ");
            }
            int find = -9999;
            while (find <0 || find > 9999)
            {
                try
                {
                    Console.WriteLine("\nEnter num from arr");
                    find = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    continue;
                }
            }
            while (arr[middle] != find)
            {
                middle = (First + Last) / 2;
                if ( find < arr[middle])
                {
                    Last = middle - 1;
                }
                else if (find > arr[middle])
                {
                    First = middle + 1;
                }
            }
            Console.WriteLine("Position entered num " + find + " - " + middle);
            Console.ReadKey();
        }
    }
}