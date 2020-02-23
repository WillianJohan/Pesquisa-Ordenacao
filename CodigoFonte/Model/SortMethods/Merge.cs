using System.Collections.Generic;
using System.Linq;

namespace PesquisaOrdenacao.Model.SortMethods
{
    public class Merge : Sort
    {

        public Merge()
        {
            MethodName = "MergeSort";
        }

        protected override void StartSorter()
        {
            listOfUnsortedNumbers = mergeSort(listOfUnsortedNumbers);
        }

        private List<int> mergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = mergeSort(left);
            right = mergeSort(right);
            return merge(left, right);
        }

        private List<int> merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                comparisons++;
                if (left.Count > 0 && right.Count > 0)
                {
                    comparisons++;
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                    exchanges++;
                }
                else if (left.Count > 0)
                {
                    comparisons++;
                    exchanges++;
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    comparisons++;
                    exchanges++;
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
