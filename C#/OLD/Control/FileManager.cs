using System.Collections.Generic;
using System.IO;

namespace PesquisaOrdenacao.Control
{
	public static class FileManager
	{
        //Path
        private static string path_Statistics = "MyStatistic.txt";
        private static string path_UnsortedNumbers = "unsortedNumbers.txt";

        public static string Path_UnsortedNumbers { get => path_UnsortedNumbers; set => path_UnsortedNumbers = value; }

        public static void RecordStatics(List<Statistic> statistics)
        {
            Stream output = File.Open(path_Statistics, FileMode.Create);
            StreamWriter writer = new StreamWriter(output);
            foreach (Statistic item in statistics) writer.WriteLine(item);                       
            writer.Close();
            output.Close();
        }

        public static List<Statistic> ReadStatistics(string name)
        {
            string path = name + ".txt";
            //Read the archive and add values in the list
            List<Statistic> statistics = new List<Statistic>();
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach(string line in lines) {
                    string[] split = line.Split(';');
                    Statistic newStatistic = new Statistic(split[0], split[1], split[2], split[3]);
                    statistics.Add(newStatistic);
                }
            }
            return statistics;
        }
        public static List<Statistic> ReadStatistics()
        {
            //Read the archive and add values in the list
            List<Statistic> statistics = new List<Statistic>();
            if (File.Exists(path_Statistics))
            {
                string[] lines = File.ReadAllLines(path_Statistics);
                foreach (string line in lines)
                {
                    string[] split = line.Split(';');
                    Statistic newStatistic = new Statistic(split[0], split[1], split[2], split[3]);
                    statistics.Add(newStatistic);
                }
            }
            return statistics;
        }

        public static void RecordUnsortedNumbers(List<int> unsorted)
        {
            Stream output = File.Open(Path_UnsortedNumbers, FileMode.Create);
            StreamWriter writer = new StreamWriter(output);
            foreach (int item in unsorted) writer.WriteLine(item);
            writer.Close();
            output.Close();
        }

        public static void RecordUnsortedNumbers(List<int> unsorted, string name)
        {
            string path = name + ".txt";
            Stream output = File.Open(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(output);
            foreach (int item in unsorted) writer.WriteLine(item);
            writer.Close();
            output.Close();
        }

        public static List<int> ReadUnsortedNumbers()
        {
            //Read the archive and add values in the list
            List<int> unsorted = new List<int>();
            if (File.Exists(Path_UnsortedNumbers))
            {
                Stream entrada = File.Open(Path_UnsortedNumbers, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = null;
                linha = leitor.ReadLine();
                do
                {                    
                    unsorted.Add(int.Parse(linha));
                    linha = leitor.ReadLine();
                } while (linha != null);

                leitor.Close();
                entrada.Close();
            }
            return unsorted;
        }

        public static List<int> ReadUnsortedNumbers(string name)
        {
            //Read the archive and add values in the list
            string path = name + ".txt";
            List<int> unsorted = new List<int>();
            if (File.Exists(path))
            {
                Stream entrada = File.Open(path, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = null;
                do
                {
                    linha = leitor.ReadLine();
                    unsorted.Add(int.Parse(linha));
                } while (leitor.ReadLine() != null);

                leitor.Close();
                entrada.Close();
            }
            return unsorted;
        }
    }
}