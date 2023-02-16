using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Builders
{
    public class WorkArraysBuilders
    {
        private WorkArrays _workArrays;

        public WorkArraysBuilders()
        {
            _workArrays = new WorkArrays();
        }

        public WorkArraysBuilders SetWriter(Action<int[]> writer)
        {
            _workArrays.Writer = writer;
            return this;
        }
        public WorkArraysBuilders SetGetArray(Func<int[]> getArray)
        {
            _workArrays.GetArray = getArray;
            return this;
        }

        public WorkArraysBuilders SetSorter(Func<int[], int[]> sorter)
        {
            _workArrays.Sorter = sorter;
            return this;
        }
        public WorkArraysBuilders SetSercher(Action<int[]> searcher)
        {
            _workArrays.Searcher = searcher;
            return this;
        }
        public WorkArrays Build()
        {
            return _workArrays;
        }


    }
}
