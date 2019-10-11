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
            int i, ini = 0, fim = vetor.Count;
            int aux;
            bool houveTroca;

            do
            {
                houveTroca = false;
                for (i = ini; i < fim - 1; i++)
                {
                    if (vetor[i] > vetor[i + 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
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
                    if (vetor[i] < vetor[i - 1])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i - 1];
                        vetor[i - 1] = aux;
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