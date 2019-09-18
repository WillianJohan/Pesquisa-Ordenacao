namespace PesquisaOrdenacao.SortMethods
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

            for (i = 0; i < vetor.Count; i++)
            {
                smallest_Index = i;
                for (j = i + 1; j < vetor.Count; j++)
                {
                    comparacoes++;
                    if (vetor[j] < vetor[smallest_Index])
                    {
                        smallest_Index = j;
                    }
                }
                if (vetor[smallest_Index] != vetor[i])
                {
                    trocas++;
                    int aux = vetor[smallest_Index];
                    vetor[smallest_Index] = vetor[i];
                    vetor[i] = aux;
                }
            }
        }
    }
}