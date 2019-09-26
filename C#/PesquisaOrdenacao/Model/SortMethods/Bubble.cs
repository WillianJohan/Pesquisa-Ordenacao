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

                for (i = 0; i < vetor.Count - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        houveTroca = true;
                        exchanges++;
                    }
                    comparisons++;
                }

            } while (houveTroca);
        }
    }
}