namespace PesquisaOrdenacao.Model.SortMethods
{
    public class Comb : Sort
    {

        public Comb()
        {
            MethodName = "CombSort";
        }

        protected override void StartSorter()
        {
            int i;
            double distancia = vetor.Count;
            int aux;
            bool houveTroca;
            do
            {
                distancia = (int) distancia / 1.3;
                if (distancia < 1) distancia = 1; //significa que virou bolha
                //Console.WriteLine(distancia);
                houveTroca = false;
                for (i = 0; i + distancia < vetor.Count; i++)
                {
                    if (vetor[i] > vetor[i + (int) distancia])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + (int) distancia];
                        vetor[i + (int) distancia] = aux;
                        houveTroca = true;
                        exchanges++;
                    }
                    comparisons++;
                }
            } while (distancia > 1 || houveTroca);
        }
    }    
}