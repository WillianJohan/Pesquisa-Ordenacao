using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.SortMethods
{
    public class ShakeSort : Sort
    {
        public Shake()
        {
            MethodName = "ShakeSort";
        }

        public override void sort()
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
                        trocas++;
                    }
                    comparacoes++;
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
                        trocas++;
                    }
                    comparacoes++;
                }
                ini++;

            } while (houveTroca && ini <= fim);            
        }
    }
}