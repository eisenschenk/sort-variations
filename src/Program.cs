using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortVariations
{
    class Program
    {
        static Random random = new Random();
        public static void AddItemsToList(List<int> Elements)
        {
            for (int i = 10; i > 0; i--)
            {
                Elements.Add(random.Next(100));
            }
        }
        public static void WriteList(List<int> Elements)
        {
            foreach (int item in Elements)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine(); Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> Unsorted = new List<int>();
            List<int> Elements = new List<int>();

            AddItemsToList(Unsorted);
            Elements = Unsorted.ToList();
            WriteList(Unsorted);


            BubbleSort.BubbleSortMain(Elements);
            WriteList(Elements);
            Elements = Unsorted.ToList();

            Elements = QuickSort.QuickSortMain(Elements);
            WriteList(Elements);
            Elements = Unsorted.ToList();

            Elements = MergeSort.MergeSortMain(Elements);
            WriteList(Elements);
            Elements = Unsorted.ToList();

            Elements = TreeSort.TreeSortMain(Elements);
            WriteList(Elements);
            Elements = Unsorted.ToList();

            Console.ReadKey();
        }
    }
}
