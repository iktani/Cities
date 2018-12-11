using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            if (x.Population.CompareTo(y.Population) != 0)
            {
                return x.Population.CompareTo(y.Population);
            }
            else
            {
                return 0;
            }
        }
    }
}
