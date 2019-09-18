using System;

namespace PesquisaOrdenacao.SortMethods
{
    public class Comb : Sort
    {

        public Comb()
        {
            MethodName = "CombSort";
        }

        protected override void StartSorter()
        {
            int i, distancia = vetor.Count;
            int aux;
            bool houveTroca;
            do
            {
                distancia = (int)Math.Round(distancia / 1.3);
                Console.WriteLine(distancia);
                if (distancia < 1) distancia = 1; //significa que virou bolha
                houveTroca = false;
                for (i = 0; i + distancia < vetor.Count; i++)
                {
                    if (vetor[i] > vetor[i + distancia])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + distancia];
                        vetor[i + distancia] = aux;
                        houveTroca = true;
                        trocas++;
                    }
                    comparacoes++;
                }
            } while (distancia > 1 || houveTroca);
        }
    }    
}