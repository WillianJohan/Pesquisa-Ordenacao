using PesquisaOrdenacao.Control;
using PesquisaOrdenacao.Model;
using PesquisaOrdenacao.Model.SortMethods;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace Projeto_PesquisaOrdenacao_WPF
{

    public partial class MainWindow : Window
    {
        private int numerosParaGerar = 0;
        private List<Statistic> listOfStatistics;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private int AmoutCheckBoxSelected
        {
            get
            {
                int i = 0;
                if (cb_BubbleSort.IsChecked == true) i++;
                if (cb_CombSort.IsChecked == true) i++;
                if (cb_InsertionSort.IsChecked == true) i++;
                if (cb_MergeSort.IsChecked == true) i++;
                if (cb_QuickSort.IsChecked == true) i++;
                if (cb_SelectionSort.IsChecked == true) i++;
                if (cb_ShakeSort.IsChecked == true) i++;
                if (cb_ShellSort.IsChecked == true) i++;
                return i;
            }
        }

        private void GerarOrdenarNumeros()
        {
            int progresso = 0;
            int methodsLengh = AmoutCheckBoxSelected;

            Console.WriteLine("Lengh OK");

            //Gera os numeros aleatórios            
            atualizarProgresso(progresso, methodsLengh, "Gerando Numeros");
            Console.WriteLine("Atuializou progresso");

            SorterSetup.setup(numerosParaGerar);
            listOfStatistics = new List<Statistic>();
            Console.WriteLine("gerou numeros");

            if (cb_BubbleSort.IsChecked == true)
            {                
                Bubble bubble = new Bubble();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, bubble.MethodName);
                bubble.sort();
                bubble.Record();
                listOfStatistics.Add(bubble.getStatistics());
            }
            if (cb_CombSort.IsChecked == true)
            {
                Comb comb = new Comb();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, comb.MethodName);
                comb.sort();
                comb.Record();
                listOfStatistics.Add(comb.getStatistics());
            }
            if (cb_InsertionSort.IsChecked == true)
            {
                Insertion insertion = new Insertion();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, insertion.MethodName);
                insertion.sort();
                insertion.Record();
                listOfStatistics.Add(insertion.getStatistics());
            }
            if (cb_MergeSort.IsChecked == true)
            {
                Merge merge = new Merge();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, merge.MethodName);
                merge.sort();
                merge.Record();
                listOfStatistics.Add(merge.getStatistics());
            }
            if (cb_QuickSort.IsChecked == true)
            {
                Quick quick = new Quick();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, quick.MethodName);
                quick.sort();
                quick.Record();
                listOfStatistics.Add(quick.getStatistics());
            }
            if (cb_SelectionSort.IsChecked == true)
            {
                Selection selection = new Selection();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, selection.MethodName);
                selection.sort();
                selection.Record();
                listOfStatistics.Add(selection.getStatistics());
            }
            if (cb_ShakeSort.IsChecked == true)
            {
                Shake shake = new Shake();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, shake.MethodName);
                shake.sort();
                shake.Record();
                listOfStatistics.Add(shake.getStatistics());
            }
            if (cb_ShellSort.IsChecked == true)
            {
                Shell shell = new Shell();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, shell.MethodName);
                shell.sort();
                shell.Record();
                listOfStatistics.Add(shell.getStatistics());
            }

            //Finaliza o método.
            atualizarProgresso(progresso, methodsLengh, "null");
        }

        // ================================== BOTOES E COMPONENTES DAS TELAS ===================================//
        
            //Update the progress in TextBlock
        private void atualizarProgresso(int atual, int total, string nomeMetodo)
        {
            lbl_TitleStatus.Content = $"Ordenando! ({atual}/{total})";
            barraProgresso.Value = (atual * 100) / total;
            
            if (nomeMetodo == null) return;
            lbl_StatusProgress.Content = $"Método em Execução: {nomeMetodo}"; // Repensar nessa atribuição

            if (txtBlock_log.Text.Length > 0) //Check if the text box has something.
            {
                int previousText = txtBlock_log.Text.IndexOf("Em Andamento", 0); //Search for "Em Andamento" text index.
                txtBlock_log.Text = txtBlock_log.Text.Substring(0, previousText) + "(OK)\n";               
                
                if (nomeMetodo.Equals("null"))
                {
                    txtBlock_log.Text += "\n===== Ordenação Concluiía!! =====\n\n";
                    txtBlock_log.Text += $"Amostra original: {numerosParaGerar} numeros desordenados de 0 a 1000\n";
                    foreach (Statistic info in listOfStatistics) txtBlock_log.Text += info.getStatistic();
                    return;
                }
            }
            txtBlock_log.Text += nomeMetodo + "..... \tEm Andamento\n";
        }

        //Check if the user write letter in txtBox
        private void OnlyNumbers_KeyUp(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(N_ToGenerate.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, Digite apenas números.");
                N_ToGenerate.Text = N_ToGenerate.Text.Remove(N_ToGenerate.Text.Length - 1);
            }
        }

        //Start sort process
        private void Button_GerarNumerosOrdenar(object sender, RoutedEventArgs e)
        {
            int.TryParse(N_ToGenerate.Text, out numerosParaGerar);
            if (numerosParaGerar <= 0) MessageBox.Show("Digite a quantidade de numeros desejada para ordenar que seja maior que zero!");
            if (AmoutCheckBoxSelected == 0) MessageBox.Show("Selecione ao menos UM metodo de ordenação!!");
            GerarOrdenarNumeros(); //Iniciar nova thread
        }

        private void Button_ResetProgress(object sender, RoutedEventArgs e)
        {
            //Titulo: Status
            lbl_TitleStatus.Content = "Status";
            //Status: Esperando a seleção dos metodos
            lbl_StatusProgress.Content = "Esperando a seleção dos métodos.";
            //Limpa o bloco de texto
            txtBlock_log.Text = null;
            //Zera barra de progresso
            barraProgresso.Value = 0;
        }
    }
}