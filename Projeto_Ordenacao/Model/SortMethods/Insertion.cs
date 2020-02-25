namespace Ordenacao.Model.SortMethods
{
    public class Insertion : Sort
    {
        public Insertion()
        {
            MethodName = "InsertionSort";
        }

        protected override void StartSorter()
        {
            int aux;
            int i, j;

            for (i = 1; i < listOfUnsortedNumbers.Count; i++)
            {
                aux = listOfUnsortedNumbers[i];
                for (j = i - 1; j >= 0 && listOfUnsortedNumbers[j] > aux; j--)
                {
                    // move the entire collection to the right
                    listOfUnsortedNumbers[j + 1] = listOfUnsortedNumbers[j];
                    comparisons++;
                    exchanges++;
                }
                listOfUnsortedNumbers[j + 1] = aux;
                comparisons++;
                exchanges++;
            }
        }
    }
}