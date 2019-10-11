using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_PesquisaOrdenacao_WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}


/*
 * SorterSetup.setup(1000000);

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
 * 
 */