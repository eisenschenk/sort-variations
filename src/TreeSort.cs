using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVariations
{
    class TreeSort
    {
        public class branch
        {
            public int Branchvalue;
            public branch smaller;
            public branch larger;




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

            public void sort(List<int> TreeSorted)
            {
                if (Branchvalue == 0)
                {
                    return;
                }
                smaller.sort(TreeSorted);
                TreeSorted.Add(Branchvalue);
                larger.sort(TreeSorted);

            }
        }
        public static List<int> SortTree(branch TreeStart, List<int> TreeSorted)
        {


            if (TreeStart.smaller.Branchvalue != 0)
            {
                SortTree(TreeStart.smaller, TreeSorted);
            }
            TreeSorted.Add(TreeStart.Branchvalue);
            if (TreeStart.larger.Branchvalue != 0)
            {
                SortTree(TreeStart.larger, TreeSorted);
            }           
            return TreeSorted;

        }

        public static List<int> TreeSortMain(List<int> Elements)
        {
            branch TreeStart = new branch();
            List<int> TreeSorted = new List<int>(Elements.Count);
            for (int index = 0; index < Elements.Count; index++)
            {
                TreeStart.insert(Elements[index]);
            }
            //TreeStart.sort(TreeSorted);
            ////return TreeSorted;
            return Elements = SortTree(TreeStart, TreeSorted);

        }

    }
}
