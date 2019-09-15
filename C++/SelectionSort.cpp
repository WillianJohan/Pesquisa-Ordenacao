#include "Sorter.h"

vector<int> Sorter::sort(vector<int> vetor)
{
    long long int i, j, posMenor;
    int aux;

    for (i = 0; i < vetor.size() - 1; i++)
    {
        posMenor = i;
        for (j = i + 1; j < vetor.size(); j++)
        {
            if (vetor[j] < vetor[posMenor])
            {
                posMenor = j;
            }
        }
        if (i != posMenor)
        {
            aux = vetor[i];
            vetor[i] = vetor[posMenor];
            vetor[posMenor] = aux;
        }
    }
    return vetor;
}
