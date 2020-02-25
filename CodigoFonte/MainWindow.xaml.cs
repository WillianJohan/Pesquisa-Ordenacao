using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using PesquisaOrdenacao.Control;
using PesquisaOrdenacao.Model;
using PesquisaOrdenacao.Model.SortMethods;


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

        //Get All the sorter methods selected by User.
        private List<ISort> getAllSorterMethods()
        {
            List <ISort> allSelectedMethods = new List<ISort>();
            if ((bool)cb_BubbleSort.IsChecked)      allSelectedMethods.Add(new Bubble());
            if ((bool)cb_CombSort.IsChecked)        allSelectedMethods.Add(new Comb());
            if ((bool)cb_InsertionSort.IsChecked)   allSelectedMethods.Add(new Insertion());
            if ((bool)cb_MergeSort.IsChecked)       allSelectedMethods.Add(new Merge());
            if ((bool)cb_QuickSort.IsChecked)       allSelectedMethods.Add(new Quick());
            if ((bool)cb_SelectionSort.IsChecked)   allSelectedMethods.Add(new Selection());
            if ((bool)cb_ShakeSort.IsChecked)       allSelectedMethods.Add(new Shake());
            if ((bool)cb_ShellSort.IsChecked)       allSelectedMethods.Add(new Shell());

            return allSelectedMethods;
        }


        private void GerarOrdenarNumeros()
        {
            //Get All methods
            List<ISort> sorterMethods = getAllSorterMethods();

            int currentIndexMethod = 0;
            int totalMethods = sorterMethods.Count;

            //Instantiate a new list of all sorter methods information
            listOfStatistics = new List<Statistic>();
            
            //Update progress "Generating random Numbers."
            atualizarProgresso(currentIndexMethod, totalMethods, "Gerando Numeros");
            SorterSetup.setup(numerosParaGerar);
            
            //Foreach method it will update progress and execute the sorter.
            foreach(ISort sortMethod in sorterMethods) 
            {
                currentIndexMethod++;
                atualizarProgresso(currentIndexMethod, totalMethods, sortMethod.getMethodName());
                sortMethod.sort();
                listOfStatistics.Add(sortMethod.getStatistics());
            }
            
            //Finaliza o método.
            atualizarProgresso(currentIndexMethod, totalMethods, "null");
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
            if (getAllSorterMethods().Count == 0) MessageBox.Show("Selecione ao menos UM metodo de ordenação!!");
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