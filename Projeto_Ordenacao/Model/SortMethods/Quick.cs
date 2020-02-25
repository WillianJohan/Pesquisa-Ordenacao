using System.Collections.Generic;

namespace Ordenacao.Model.SortMethods
{
    class Quick : Sort
    {
        public Quick()
        {
            MethodName = "QuickSort";
        }

        protected override void StartSorter()
        {
            listOfUnsortedNumbers = quicksort(listOfUnsortedNumbers);
        }

        private List<int> quicksort(List<int> unsorted)
        {
            if (unsorted.Count <= 1) return unsorted;
            int pivotPosition = unsorted.Count / 2;
            int pivotValue = unsorted[pivotPosition];
            unsorted.RemoveAt(pivotPosition);
            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            foreach (int item in unsorted)
            {
                if (item < pivotValue)
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
                exchanges++;
                comparisons++;
            }
            List<int> sorted = quicksort(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(quicksort(greater));
            return sorted;
        }

    }
}
