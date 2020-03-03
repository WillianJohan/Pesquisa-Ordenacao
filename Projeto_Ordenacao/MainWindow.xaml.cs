using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using Ordenacao.Control;
using Ordenacao.Model;
using Ordenacao.Model.SortMethods;
using System.ComponentModel;

namespace Projeto_Ordenacao_WPF
{

    public partial class MainWindow : Window
    {
        private int amountOfNumbersToGenerate = 0;
        private int currentIndexMethod = 0;
        private int totalMethods = 8;
        private string currentMethodName;
        private List<ISort> sorterMethods;
        private List<Statistic> listOfStatistics;        
        private BackgroundWorker worker;

        public MainWindow()
        {
            InitializeComponent();
            cancelButton.IsEnabled = false;
            generateAndStartSorting.IsEnabled = true;
            resetProgress();
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

        // Background Worker Methods ===============================
        private void worker_Start()
        {
            //reset status
            resetProgress();

            //Enable-Disable Buttons
            generateAndStartSorting.IsEnabled = false;
            cancelButton.IsEnabled = true;

            //Get All methods
            sorterMethods = getAllSorterMethods();

            currentIndexMethod = 0;
            totalMethods = sorterMethods.Count;

            //Instantiate a new list of all sorter methods information
            listOfStatistics = new List<Statistic>();

            //Update progress "Generating random Numbers."
            SorterSetup.setup(amountOfNumbersToGenerate);

            //Worker Setup
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.RunWorkerAsync();
        }
        
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            //Foreach method it will update progress and execute the sorter.
            foreach (ISort sortMethod in sorterMethods)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                currentIndexMethod++;
                currentMethodName = sortMethod.getMethodName();
                worker.ReportProgress(currentIndexMethod);                
                sortMethod.sort();
                listOfStatistics.Add(sortMethod.getStatistics());
            }                        
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbl_TitleStatus.Content = $"Ordenando! ({currentIndexMethod}/{totalMethods})";
            barraProgresso.Value = (currentIndexMethod * 100) / totalMethods;

            if (currentMethodName == null) return;
            lbl_StatusProgress.Content = $"Método em Execução: {currentMethodName}";

            if (txtBlock_log.Text.Length > 0) //Check if the text box has something.
            {
                int previousText = txtBlock_log.Text.IndexOf("Em Andamento", 0); //Search for "Em Andamento" text index.
                txtBlock_log.Text = txtBlock_log.Text.Substring(0, previousText) + "(OK)\n";
            }
            txtBlock_log.Text += currentMethodName + "..... \tEm Andamento\n";
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //was canceled
                txtBlock_log.Text += "\n===== Ordenação Cancelada!! =====\n\n";
                txtBlock_log.Text += $"Amostra original: {amountOfNumbersToGenerate} numeros desordenados de 0 a 1000\n";
                foreach (Statistic info in listOfStatistics) txtBlock_log.Text += info.getStatistic();
            }
            else
            {
                //complete
                txtBlock_log.Text += "\n===== Ordenação Concluiía!! =====\n\n";
                txtBlock_log.Text += $"Amostra original: {amountOfNumbersToGenerate} numeros desordenados de 0 a 1000\n";
                foreach (Statistic info in listOfStatistics) txtBlock_log.Text += info.getStatistic();
            }
            
            currentMethodName = null;
            currentIndexMethod = 0;
            totalMethods = 0;

            generateAndStartSorting.IsEnabled = true;
            cancelButton.IsEnabled = false;
        }


        // ================================== BOTOES E COMPONENTES DAS TELAS ===================================//

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
            int.TryParse(N_ToGenerate.Text, out amountOfNumbersToGenerate);
            if (amountOfNumbersToGenerate <= 0)
            {
                MessageBox.Show("Digite a quantidade de numeros desejada para ordenar que seja maior que zero!");
                return;
            }
            else if (getAllSorterMethods().Count <= 0)
            {
                MessageBox.Show("Selecione ao menos UM metodo de ordenação!!");
                return;
            }            
            worker_Start();
        }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }

        private void resetProgress()
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