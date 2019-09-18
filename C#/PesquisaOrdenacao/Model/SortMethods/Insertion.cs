namespace PesquisaOrdenacao.SortMethods
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

            for (i = 1; i < vetor.Count; i++)
            {
                aux = vetor[i];
                for (j = i - 1; j >= 0 && vetor[j] > aux; j--)
                {
                    // move the entire collection to the right
                    vetor[j + 1] = vetor[j];
                    comparacoes++;
                    trocas++;
                }
                vetor[j + 1] = aux;
                comparacoes++;
                trocas++;
            }
        }
    }
}