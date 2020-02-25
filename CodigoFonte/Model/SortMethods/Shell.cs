namespace Ordenacao.Model.SortMethods
{
    public class Shell : Sort
    {
        public Shell()
        {
            MethodName = "ShellSort";
        }

        protected override void StartSorter()
        {
            int i, j, distancia = 1;
            int aux;

            do
            {
                distancia = 3 * distancia + 1;
            } while (distancia < listOfUnsortedNumbers.Count);

            do
            {
                distancia = (int)distancia / 3;
                for (i = distancia; i < listOfUnsortedNumbers.Count; i++)
                {
                    aux = listOfUnsortedNumbers[i];
                    for (j = i - distancia; j >= 0 && aux < listOfUnsortedNumbers[j]; j = j - distancia)
                    {
                        listOfUnsortedNumbers[j + distancia] = listOfUnsortedNumbers[j];
                        comparisons++;
                        exchanges++;
                    }
                    listOfUnsortedNumbers[j + distancia] = aux;
                    exchanges++;
                }
            } while (distancia > 1);
        }
    }
}