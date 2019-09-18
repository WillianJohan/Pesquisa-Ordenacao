using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.SortMethods
{
    public class Bubble : Sort
    {
        public BubbleSort()
        {
            MethodName = "BubbleSort";
        }

        public override void sort()
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
                        trocas++;
                    }
                    comparacoes++;
                }

            } while (houveTroca);
        }
    }
}