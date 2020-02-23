namespace PesquisaOrdenacao.Model.SortMethods
{
    public class Selection : Sort
    {
        public Selection()
        {
            MethodName = "SelectionSort";
        }

        protected override void StartSorter()
        {
            int smallest_Index = 0;
            int i, j;

            for (i = 0; i < listOfUnsortedNumbers.Count; i++)
            {
                smallest_Index = i;
                for (j = i + 1; j < listOfUnsortedNumbers.Count; j++)
                {
                    comparisons++;
                    if (listOfUnsortedNumbers[j] < listOfUnsortedNumbers[smallest_Index])
                    {
                        smallest_Index = j;
                    }
                }
                if (listOfUnsortedNumbers[smallest_Index] != listOfUnsortedNumbers[i])
                {
                    exchanges++;
                    int aux = listOfUnsortedNumbers[smallest_Index];
                    listOfUnsortedNumbers[smallest_Index] = listOfUnsortedNumbers[i];
                    listOfUnsortedNumbers[i] = aux;
                }
            }
        }
    }
}