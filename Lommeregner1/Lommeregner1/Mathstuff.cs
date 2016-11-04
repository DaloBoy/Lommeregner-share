using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner1
{
    class Mathstuff
    {
        public double tal1 { get; set; }
        public double tal2 { get; set; }
        public double result { get; set; }
        public string plus = "+";

        public double plus1()
        {
            
            result = tal1 + tal2;
            
            return result;
        }


    }

}
