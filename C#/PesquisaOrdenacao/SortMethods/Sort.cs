using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.SortMethods
{
    public abstract class Sort
    {
        //Read all the numbers and add to the list
        private string methodName = "";
        protected List<int> vetor = new List<int>();
        protected Int64 comparacoes = 0;
        protected Int64 trocas = 0;
        protected Stopwatch sw; //Calculate the time
        protected bool isFinished = false; //Return is the sorter is finished

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
            string[] information = new string[5];
            information[0] = methodName;
            information[1] = vetor.Count.ToString();
            information[2] = comparacoes.ToString();
            information[3] = trocas.ToString();
            information[4] = sw.ElapsedMilliseconds.ToString();

            return information;
        }

        //Abstracts methods
        public abstract void sort(); //Renomear para "StartSorter"

        /*
        public void sort()
        {
            setupList();
            sw = Stopwatch.StartNew();
            startSorter();
            sw.Stop();
            isFinished = true;
        }

        public bool isFinished()
        {
            return isFinished;
        }

        public String[] getStatistics()
        {
            string[] information = new string[5];
            information[0] = methodName;
            information[1] = vetor.Count.ToString();
            information[2] = comparacoes.ToString();
            information[3] = trocas.ToString();
            information[4] = sw.ElapsedMilliseconds.ToString();

            return information;
        }

        public abstract void startSorter();
        */
    }
}
