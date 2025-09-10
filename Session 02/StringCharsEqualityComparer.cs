using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02
{
    internal class StringCharsEqualityComparer : IEqualityComparer<string> 
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null)
                return false;

            var a = new string(x.Trim().OrderBy(Char => Char).ToArray()).ToLower();
            var b = new string(y.Trim().OrderBy(Char => Char).ToArray()).ToLower();

            return a.Equals(b);
        }

        public int GetHashCode(string obj)
        {
            return new string(obj.Trim().OrderBy(Char => Char).ToArray()).ToLower().GetHashCode();

        }
    }
}
