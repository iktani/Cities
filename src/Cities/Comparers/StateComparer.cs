using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class StateComparer : IComparer<City> 
    {
        public int Compare(City x, City y)
        {
            if (x.State.CompareTo(y.State) != 0)
            {
                return x.State.CompareTo(y.State);
            }
            else
            {
                return 0;
            }
        }
    }
}
