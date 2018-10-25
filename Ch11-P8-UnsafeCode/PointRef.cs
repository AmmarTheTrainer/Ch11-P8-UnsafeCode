using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P8_UnsafeCode
{
    class PointRef // <= Renamed and retyped.
    {
        public int x;
        public int y;
        public override string ToString() => $"({x}, {y})";
    }
}
