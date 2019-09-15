#include "Sorter.h"

vector<int> Sorter::sort(vector<int> vetor){
    long long int i, j;
    int aux;

    for (i = 1; i < vetor.size(); i++)
    {
        aux = vetor[i];
        for (j = i - 1; j >= 0 && aux < vetor[j]; j--)
        {
            vetor[j + 1] = vetor[j];
        }
        vetor[j + 1] = aux;
    }
    return vetor;
}
