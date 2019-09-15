#include "Sorter.h"

vector<int> Sorter::sort(vector<int> vetor)
{
    long long int i, aux;
    int houveTroca;

    do
    {
        houveTroca = 0;
        for (i = 0; i < vetor.size() - 1;; i++)
        {
            if (vetor[i] > vetor[i + 1])
            {
                aux = vetor[1];
                vetor[i] = vetor[i + 1];
                vetor[i + 1] = aux;
                houveTroca = 1;
            }
        }
    } while (houveTroca);
}
