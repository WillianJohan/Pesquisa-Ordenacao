using System;
using System.Collections.Generic;
using System.IO;

namespace PesquisaOrdenacao.Model.SortMethods
{
    public static class SorterSetup
    {
        private static string path = "n.txt";
        public static void setup(int total)
        {
            Random rand = new Random();
            List<int> randomNumbers = new List<int>();
            for(int i = 0; i < total; i++) randomNumbers.Add(rand.Next(0, 1000));

            Stream output = File.Open(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(output);
            foreach(int i in randomNumbers) writer.WriteLine(i);
            writer.Close();
            output.Close();
        }
    }
}