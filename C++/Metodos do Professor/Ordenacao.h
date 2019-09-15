#include <vector>
#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <cstdlib>
#include <time.h>

using namespace std;

class Ordenacao { 
public:
  static void geraNumerosEmArquivo();
  static vector<int> leNumerosDeArquivo();
  static vector<int> popula(long long int qtd, vector<int> &vetor);
  static void exibe(const vector<int> &vetor);
  static vector<int> selecao(vector<int> &vetor);
  static vector<int> insercao(vector<int> &vetor);
  static vector<int> bolha(vector<int> &vetor);
  static vector<int> agitacao(vector<int> &vetor);
  static vector<int> pente(vector<int> &vetor);
  static vector<int> shell(vector<int> &vetor);
};