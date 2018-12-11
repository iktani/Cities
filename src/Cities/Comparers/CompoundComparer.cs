using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers { get; set; } = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            for (int i=0; i<Comparers.Count; i++)
            {
                while (Comparers[i].Compare(x, y) != 0)
                {
                    return Comparers[i].Compare(x, y);
                }
            }
            return 0;
        }


    }
}
