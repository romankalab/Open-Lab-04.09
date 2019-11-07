using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Open_Lab_04._09
{
    class Dups
    {
        public string[] RemoveDups(string[] arr)
        {
            return arr.Distinct().ToArray();
        }
    }
}
