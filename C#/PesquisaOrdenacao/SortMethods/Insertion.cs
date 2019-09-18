using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.SortMethods
{
    public class Insertion : Sort
    {
        public InsertionSort()
        {
            MethodName = "InsertionSort";
        }

        public override void sort()
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