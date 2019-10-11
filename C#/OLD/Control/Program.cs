using System;
using System.Windows.Forms;

namespace PesquisaOrdenacao
{
    using Model.SortMethods;

    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SorterSetup.setup(1000000);

            Quick quick = new Quick();
            quick.sort();
            Console.WriteLine(quick.getStatistics().getStatistic());
            quick.Record();

            Merge merge = new Merge();
            merge.sort();
            Console.WriteLine(merge.getStatistics().getStatistic());
            merge.Record();

            Shell shell = new Shell();
            shell.sort();
            Console.WriteLine(shell.getStatistics().getStatistic());
            shell.Record();

            Comb comb = new Comb();
            comb.sort();
            Console.WriteLine(comb.getStatistics().getStatistic());
            comb.Record();

            Bubble bubble = new Bubble();
            bubble.sort();
            Console.WriteLine(bubble.getStatistics().getStatistic());
            bubble.Record();

            Shake shake = new Shake();
            shake.sort();
            Console.WriteLine(shake.getStatistics().getStatistic());
            shake.Record();


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new View.MainWindow());
        }
    }
}
