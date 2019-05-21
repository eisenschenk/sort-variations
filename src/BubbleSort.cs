using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVariations
{
    class BubbleSort
    {
        //Swap 2 Elements
        public static void SwapElements(List<int> Elements, int index)
        {
            int SwapVariable;
            SwapVariable = Elements[index];
            Elements[index] = Elements[index + 1];
            Elements[index + 1] = SwapVariable;
        }
        
        public static void BubbleSortMain(List<int> Elements)
        {
           
            bool Swapped = true;         
            //loop untill all items are swapped
            while (Swapped)
            {
                Swapped = false;
                //loop to compare 2 items until end of list is reached
                for (int index = 0; index + 1 < Elements.Count; index++)
                {
                    if (Elements[index] > Elements[index + 1])
                    {
                        SwapElements(Elements, index);
                        Swapped = true;
                    }
                }
            }
           
        }
    }

}
