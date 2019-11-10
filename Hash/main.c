#include <stdlib.h>
#include <stdio.h>
#define TAM 10

typedef struct {
    int idade;
    char nome[100];
} Aluno;

typedef struct no {
    Aluno pessoa;
    struct no *prox;
} Celula;

Celula *inserir(Aluno a, Celula *l) {
    Celula *novo;
    Celula *pR, *p;
    novo = (Celula *)malloc(sizeof(Celula));
    novo->pessoa = a;
    novo->prox = NULL;

    if (!l) return novo;

    for (pR = NULL, p = l; p; pR = p, p = p->prox) {
        if (a.idade < p->pessoa.idade) break;
    }
    if (!pR) {
        novo->prox = p;
        return novo;
    }
    if (!p) {
        pR->prox = novo;
        return l;
    }
    pR->prox = novo;
    novo->prox = p;
    return l;
}


void inicializarTabelaHash(Celula *tabela[], int n){
    int i;
    for (i = 0; i < n; i++) {
        tabela[i] = NULL;
    }
}

int hash(Aluno a) {
    int i, endereco = 0;
    for(i = 0; a.nome[i+1] != NULL ; i++) endereco += a.nome[i];
    endereco = endereco%TAM;
    return endereco;
}

int main() {
    Celula *tabelaHash[TAM];
    inicializarTabelaHash(tabelaHash, TAM);

    int opcao;
    Aluno a;
    int endereco;
    do {
        //Opcoes
        system("cls"); // Limpa Tela
        printf("1 - Inserir\n");
        printf("2 - Pesquisar\n");
        printf("4 - Remover\n");
        printf("5 - Sair\n");
        printf("Opcao: ");
        scanf("%d", &opcao);

        switch (opcao) {
            case 1: //receber dados do usuario: idade e nome
                    printf("\n=====================\n\n");
                    printf("Digite sua idade: ");
                    scanf("%d", &a.idade);
                    printf("Digite seu nome: ");
                    scanf("%s", a.nome);
                    endereco = hash(a); //executar a funcao hash para saber o endereco na tabelaHash

                    //inserir na tabelaHash
                    printf("%s foi inserido no endereco: %d\n", a.nome,endereco);
                    tabelaHash[endereco] = inserir(a,tabelaHash[endereco]);
                    system("Pause");
                    break;
            case 2: //receber o atributo que eh usado no calculo hash
                    printf("Digite o nome da pessoa: ");
                    scanf("%s", a.nome);
                    endereco = hash(a);
                    printf("\n== Resultados ==========\n");
                    if (tabelaHash[endereco] != NULL){
                        Celula *c;
                        int i;
                        for(i = 0, c = tabelaHash[endereco]; c; c = c->prox, i++){
                            printf("%d - Nome: %s , Idade: %d\n", i, c->pessoa.nome ,c->pessoa.idade);
                        }
                        system("Pause");
                    }
                    break;
            case 4:
                    break;
            case 5: printf("Obrigado por usar o sistema\n");
                    break;
            default : printf("Opcao invalida\n");
        }
    } while (opcao != 5);
    return 1;
}
