using System.Collections.Generic;

namespace PesquisaOrdenacao.Control
{
	public static class FileManager
	{
        //Path
        private static string path_Statics = "";
        private static string path_UnsortedNumbers = "unsortedNumbers.txt";

        private static string fileName = "";
		private static List<Statistic> statistics = new List<Statistic>();

        public static string Path_UnsortedNumbers { get => path_UnsortedNumbers; set => path_UnsortedNumbers = value; }

        public static void RecordStatics()
        {

        }

        public static List<Statistic> ReadStatistics(string name)
        {
            return null;
        }

        public static void RecordUnsortedNumbers(List<int> unsorted)
        {

        }

        public static void RecordUnsortedNumbers(List<int> unsorted, string name)
        {

        }

        public static List<int> ReadUnsortedNumbers()
        {
            return null;
        }

        public static List<int> ReadUnsortedNumbers(string name)
        {
            return null;
        }
    }
}