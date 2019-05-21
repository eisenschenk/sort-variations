using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVariations
{
    class TreeSort
    {
        class branch
        {
            int Branchvalue;
            branch smaller;
            branch larger ;


            public void insert(int value)
            {
                if (Branchvalue == 0)
                {
                    smaller = new branch();
                    larger = new branch();
                    Branchvalue = value;
                }
                else if (value < Branchvalue)
                {
                    smaller.insert(value);
                }
                else
                {
                    larger.insert(value);
                }
            }

        }
        public static List<int> TreeSortMain(List<int> Elements)
        {
            branch TreeStart = new branch();
            for (int index = 0; index < Elements.Count; index++)
            {
                TreeStart.insert(Elements[index]);
            }
            return null;
        }

    }
}
