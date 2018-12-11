using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City> 
    {
        public int Compare(City x, City y)
        {
            if (x.Area.CompareTo(y.Area) != 0)
            {
                return x.Area.CompareTo(y.Area);
            }
            else
            {
                return 0;
            }
        }
    }
}
