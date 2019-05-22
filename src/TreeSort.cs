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
           public branch larger ;

           


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
        public static List<int> SortSmaller(branch TreeStart)
        {
            List<int> TreeSorted = new List<int>();
            branch TreeTest = new branch();
            if (TreeStart.smaller != null)
            {
                SortSmaller(TreeStart.smaller);
            }
            else if (TreeStart.Branchvalue != 0)
            {
                TreeSorted.Add(TreeStart.Branchvalue);
            }
             if (TreeStart.larger != null)
            {
                SortSmaller(TreeStart.larger);
            }

            return TreeSorted;
           
        }
        
        public static List<int> TreeSortMain(List<int> Elements)
        {
            branch TreeStart = new branch();
            List<int> SortedElements = new List<int>();
            for (int index = 0; index < Elements.Count; index++)
            {
                TreeStart.insert(Elements[index]);
            }
           return SortSmaller(TreeStart);
          //return Elements = Sorte(TreeStart);
          //  return null;
        }

    }
}
