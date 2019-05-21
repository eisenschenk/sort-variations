using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVariations
{
    class MergeSort

    {
        public static List<int> SortByMerging(List<int> Elements)
        {
            if (Elements.Count <= 1)
            {
                return Elements;
            }
            else
            {
                List<int> left = new List<int>();
                List<int> right = new List<int>();
                int half = Elements.Count / 2;

                for (int index = 0; index < half; index++)
                {
                    left.Add(Elements[index]);
                }
                for (int index = half; index < Elements.Count; index++)
                {
                    right.Add(Elements[index]);
                }
                left = SortByMerging(left);
                right = SortByMerging(right);
                return Merge(left, right);
            }
        }
        public static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> Sorted = new List<int>();
            while (left.Count != 0 && right.Count != 0)
            {
                if (left.First() <= right.First())
                {
                    Sorted.Add(left.First());
                    left.Remove(left.First());
                }
                else
                {
                    Sorted.Add(right.First());
                    right.Remove(right.First());
                }
            }
            while (left.Count != 0)
            {
                Sorted.Add(left.First());
                left.Remove(left.First());
            }
            while (right.Count != 0)
            {
                Sorted.Add(right.First());
                right.Remove(right.First());
            }
            return Sorted;

        }

        public static List<int> MergeSortMain(List<int> Elements)
        {           
                 
            return SortByMerging(Elements);
           
           
        }
    }
}
