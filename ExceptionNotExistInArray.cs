using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class ExceptionNotExistInArray : Exception
    {
        public ExceptionNotExistInArray(string message) : base(message) { }
    }
}
