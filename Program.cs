﻿using System.Collections.Generic;
using System.Net;
using System.Reflection;
using CodeWars.ComponentsForWorkWithArray;

namespace CodeWars
{

    internal class Program
    {
        public static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }       

        static void Main(string[] args)
        {
          
        }
    }
}