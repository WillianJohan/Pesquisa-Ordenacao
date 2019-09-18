using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.SortMethods
{
    public class Shell : Sort
    {
        public Shell()
        {
            MethodName = "ShellSort";
        }

        public override void sort()
        {
            int i, j, distancia = 1;
            int aux;

            do
            {
                distancia = 3 * distancia + 1;
            } while (distancia < vetor.Count);

            do
            {
                distancia = (int)distancia / 3;
                for (i = distancia; i < vetor.Count; i++)
                {
                    aux = vetor[i];
                    for (j = i - distancia; j >= 0 && aux < vetor[j]; j = j - distancia)
                    {
                        vetor[j + distancia] = vetor[j];
                        comparacoes++;
                        trocas++;
                    }
                    vetor[j + distancia] = aux;
                    trocas++;
                }
            } while (distancia > 1);
        }
    }
}