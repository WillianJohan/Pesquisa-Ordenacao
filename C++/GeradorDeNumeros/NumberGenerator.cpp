#include "NumberGenerator.h"

long long int qdtNumeros;
long long int range;
string path;

NumberGenerator::NumberGenrierator(string path){
	//Cria um txt
	//inicializa o metodo de criacao dos numeros
	//create();
}

int NumberGenerator::create(){
	return -1;
}

int NumberGenerator::deleteArchive(string path){
	return -1;
}

int NumberGenerator::deleteArchive(){
	return -1;
}        
        


/*
int main()
{
	long long int qdtNumeros;
	long long int limite;

	cout << "Quantos numeros deseja gerar?\n>";
	cin >> qdtNumeros;
	cout << "\nQual o limite de cada numero? ex: 1000\nO programa ira criar numeros entre 0 e 1000\n>";
	cin >> limite;

	string nomeArquivo = to_string(qdtNumeros) + ".txt";
	ofstream arq;
	arq.open(nomeArquivo);

	srand(time(NULL));
	long long int valor;
	for (; qdtNumeros > 0; qdtNumeros--) {
		valor = rand() % limite+1;
		arq << valor << "\n";
	}

	arq.close();

	cout << "\n===== Operacao Concluida com sucesso. =====";

	return 0;
}
