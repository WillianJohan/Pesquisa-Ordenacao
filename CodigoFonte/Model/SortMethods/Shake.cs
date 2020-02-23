namespace PesquisaOrdenacao.Model.SortMethods
{
    public class Shake : Sort
    {
        public Shake()
        {
            MethodName = "ShakeSort";
        }

        protected override void StartSorter()
        {
            int i, ini = 0, fim = listOfUnsortedNumbers.Count;
            int aux;
            bool houveTroca;

            do
            {
                houveTroca = false;
                for (i = ini; i < fim - 1; i++)
                {
                    if (listOfUnsortedNumbers[i] > listOfUnsortedNumbers[i + 1])
                    {
                        aux = listOfUnsortedNumbers[i];
                        listOfUnsortedNumbers[i] = listOfUnsortedNumbers[i + 1];
                        listOfUnsortedNumbers[i + 1] = aux;
                        houveTroca = true;
                        exchanges++;
                    }
                    comparisons++;
                }
                fim--;
                if (!houveTroca) break;

                houveTroca = false;
                for (i = fim; i > ini; i--)
                {
                    if (listOfUnsortedNumbers[i] < listOfUnsortedNumbers[i - 1])
                    {
                        aux = listOfUnsortedNumbers[i];
                        listOfUnsortedNumbers[i] = listOfUnsortedNumbers[i - 1];
                        listOfUnsortedNumbers[i - 1] = aux;
                        houveTroca = true;
                        exchanges++;
                    }
                    comparisons++;
                }
                ini++;

            } while (houveTroca && ini <= fim);            
        }
    }
}