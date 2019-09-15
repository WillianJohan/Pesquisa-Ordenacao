#include "Sorter.h"

    using namespace std;

vector<int> Sorter::sort(vector<int> vetor){
    long long int i, aux;
    int houveTroca;
	int i = 0;
	int ini = 0;
    int fim = vetor.size() - 1;

    do{
        houveTroca = 0;    
        for(;i < fim; i++){
            if (vetor[i] > vetor[i + 1])
            {
                aux = vetor[i];
                vetor[i] = vetor[i + 1];
                vetor[i + 1] = aux;

                houveTroca = 1;
            }
        } 
        if(!houveTroca) return;
		fim--;		
		
		for(;i > ini; i--){
            if (vetor[i] < vetor[i - 1])
            {
                aux = vetor[i];
                vetor[i] = vetor[i - 1];
                vetor[i - 1] = aux;

                houveTroca = 1;
            }
        }
		ini++;
		    
    }while(houveTroca);    
}

