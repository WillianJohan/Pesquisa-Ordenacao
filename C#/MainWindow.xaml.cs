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

    //https://stackoverflow.com/questions/20949742/change-backgorund-of-button-in-wpf-when-it-has-focus -> Botão background foco
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tabs.SelectedIndex = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tabs.SelectedIndex = 0;
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