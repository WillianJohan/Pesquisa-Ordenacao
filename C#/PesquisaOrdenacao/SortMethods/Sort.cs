using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rename all Sort word to Sorter

namespace PesquisaOrdenacao.SortMethods
{
    public static class SorterSetup
    {
        private static string path = "n.txt";
        public static void setup(int total)
        {
            Random rand = new Random();
            List<int> randomNumbers = new List<int>();
            for(int i = 0; i < total; i++) randomNumbers.Add(rand.Next(0, 1000));

            Stream saida = File.Open(path, FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            foreach(int i in randomNumbers) escritor.WriteLine(i);
            escritor.Close();
            saida.Close();
        }
        //Gera os numeros desordenados
        //Grava em arquivo os numeros desordenados
    }

    public abstract class Sort
    {
        //Read all the numbers and add to the list
        private string methodName = "";
        protected List<int> vetor = new List<int>();
        protected float time = 0;
        protected Int64 comparacoes = 0;
        protected Int64 trocas = 0;

        //Returns the name of sort method. 
        public string MethodName { get => methodName; set => methodName = value; }

        public void setupList()
        {
            //Read the archive and add values in the list
            if (File.Exists("n.txt"))
            {
                Stream entrada = File.Open("n.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    vetor.Add(int.Parse(linha));
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }

        public String[] getStatistics()
        {
            //returns a string with: 
            //Name of Method
            //Lengh of list
            //Number of Comparisons
            //Numero de trocas
            //Tempo de execucao
            string[] information = new string[5];
            information[0] = methodName;
            information[1] = vetor.Count.ToString();
            information[2] = comparacoes.ToString();
            information[3] = trocas.ToString();
            information[4] = "@";

            return information;
        }

        //Abstracts methods
        public abstract void sort();
    }

    public class SelectionSort : Sort
    {
        public SelectionSort()
        {
            MethodName = "SelectionSort";
        }

        public override void sort()
        {
            int smallest_Index = 0;
            int i, j;

            for (i = 0; i < vetor.Count; i++)
            {

                smallest_Index = i;
                for (j = i + 1; j < vetor.Count; j++)
                {
                    comparacoes++;
                    if (vetor[j] < vetor[smallest_Index])
                    {
                        smallest_Index = j;
                    }
                }
                if (vetor[smallest_Index] != vetor[i])
                {
                    trocas++;
                    int aux = vetor[smallest_Index];
                    vetor[smallest_Index] = vetor[i];
                    vetor[i] = aux;
                }
            }





            Stream saida = File.Open("selection.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            foreach (int b in vetor) escritor.WriteLine(b);
            escritor.Close();
            saida.Close();

        }
    }

    public class InsertionSort : Sort
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
                comparacoes++;

                for (j = i - 1; j >= 0 && vetor[j] > aux; j--)
                {
                    // move the entire collection to the right
                    vetor[j + 1] = vetor[j];
                    comparacoes++;
                    trocas++;
                }
                vetor[j + 1] = aux;
                trocas++;
            }




            Stream saida = File.Open("Insertion.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            foreach (int b in vetor) escritor.WriteLine(b);
            escritor.Close();
            saida.Close();
        }
    }

    public class BubbleSort : Sort
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
                    comparacoes++;
                    if (vetor[i] > vetor[i + 1])
                    {
                        int aux = vetor[i];
                        vetor[i] = vetor[i + 1];
                        vetor[i + 1] = aux;
                        trocas++;
                        houveTroca = true;
                    }
                }

            } while (houveTroca);





            Stream saida = File.Open("Bubble.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(saida);
            foreach (int b in vetor) escritor.WriteLine(b);
            escritor.Close();
            saida.Close();

            
        }
    }

    public class ShakeSort : Sort
    {
        public ShakeSort()
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
                    }
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
                    }
                }
                ini++;

            } while (houveTroca && ini <= fim);            
        }
    }

    public class CombSort : Sort
    {

        public CombSort()
        {
            MethodName = "CombSort";
        }

        public override void sort()
        {
            int i, distancia = vetor.Count;
            int aux;
            bool houveTroca;
            do
            {
                distancia = (int)Math.Round(distancia / 1.3);
                Console.WriteLine(distancia);
                if (distancia < 1) distancia = 1; //significa que virou bolha
                houveTroca = false;
                for (i = 0; i + distancia < vetor.Count; i++)
                {
                    if (vetor[i] > vetor[i + distancia])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[i + distancia];
                        vetor[i + distancia] = aux;
                        houveTroca = true;
                    }
                }
            } while (distancia > 1 || houveTroca);
        }
    }

    public class ShellSort : Sort
    {
        public ShellSort()
        {
            MethodName = "ShellSort";
        }

        public override void sort()
        {
            int i, j, distancia = 1;
            int aux;

            do
            {
                distancia = 3 * distancia + 1;
            } while (distancia < vetor.Count);

            do
            {
                distancia = (int)distancia / 3;
                for (i = distancia; i < vetor.Count; i++)
                {
                    aux = vetor[i];
                    for (j = i - distancia; j >= 0 && aux < vetor[j]; j = j - distancia)
                    {
                        vetor[j + distancia] = vetor[j];
                    }
                    vetor[j + distancia] = aux;
                }
            } while (distancia > 1);
        }
    }
}
