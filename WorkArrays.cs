using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.ComponentsForWorkWithArray;

namespace CodeWars
{
    public class WorkArrays
    {
        private readonly Action<int[]> Writer;
        private readonly Func<int[]> GetArray;
        private readonly Func<int[], int[]> Sorter;
        private readonly Action<int[]> Searcher;

        //В будущем можно использовать паттерн строитель для инициализации этих полей 
        public WorkArrays(Action<int[]> writer, Func<int[]> getArray, Func<int[], int[]> sorter, Action<int[]> searcher)
        {
            Writer = writer;
            GetArray = getArray;
            Sorter = sorter;
            Searcher = searcher;
        }
    }

}
