using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}