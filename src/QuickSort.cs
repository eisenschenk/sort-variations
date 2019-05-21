using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVariations
{
    class QuickSort
    {
        private static List<int> Sorted(List<int> Elements)
        {
            if (Elements.Count <= 1)
                return Elements;
            else
            {
                List<int> left = new List<int>();
                List<int> right = new List<int>();
                int pivotIndex = Elements.Count / 2;
                int pivot = Elements[pivotIndex];                
                for (int index = 0; index < Elements.Count; index++)
                {
                    if (index == pivotIndex)
                        continue;
                    if (Elements[index] <= pivot)
                    {
                        left.Add(Elements[index]);
                    }
                    else if (Elements[index] > pivot)
                    {
                        right.Add(Elements[index]);
                    }
                }
                
                left = Sorted(left);
                right = Sorted(right);
                left.Add(pivot);
                return Merge(left, right);
            }
        }
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> SortedElements = new List<int>();
            while (left.Count != 0)
            {
                SortedElements.Add(left.First());
                left.Remove(left.First());
            }
            while (right.Count != 0)
            {
                SortedElements.Add(right.First());
                right.Remove(right.First());
            }
            return SortedElements;
        }
        public static List<int> QuickSortMain(List<int> Elements)
        {           
                                 
           return Sorted(Elements);
           
            
        }
    }
}
