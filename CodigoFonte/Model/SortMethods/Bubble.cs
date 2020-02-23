namespace PesquisaOrdenacao.Model.SortMethods
{
    public class Bubble : Sort
    {
        public Bubble()
        {
            MethodName = "BubbleSort";
        }

        protected override void StartSorter()
        {
            bool houveTroca;
            int i;

            do
            {
                houveTroca = false;

                for (i = 0; i < listOfUnsortedNumbers.Count - 1; i++)
                {
                    if (listOfUnsortedNumbers[i] > listOfUnsortedNumbers[i + 1])
                    {
                        int aux = listOfUnsortedNumbers[i];
                        listOfUnsortedNumbers[i] = listOfUnsortedNumbers[i + 1];
                        listOfUnsortedNumbers[i + 1] = aux;
                        houveTroca = true;
                        exchanges++;
                    }
                    comparisons++;
                }

            } while (houveTroca);
        }
    }
}