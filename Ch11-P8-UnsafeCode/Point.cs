using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P8_UnsafeCode
{
    struct Point
    {
        public int x;
        public int y;
        //public Point()
        //{
        //    x = 2;
        //    x = 4;
        //}
        public override string ToString() => $"({x}, {y})";
    }
}
