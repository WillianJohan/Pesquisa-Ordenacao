using PesquisaOrdenacao.Control;
using PesquisaOrdenacao.Model.SearchMethods;
using PesquisaOrdenacao.Model.SortMethods;
using System;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;


namespace Projeto_PesquisaOrdenacao_WPF
{

    public partial class MainWindow : Window
    {
        //Indices para as respectivas janelas
        private readonly int TAB_ORDENACAO = 0;
        private readonly int TAB_SETUP_ORDENACAO = 1;
        private readonly int TAB_HISTORICO = 2;
        private readonly int TAB_GRAFICO = 3;
        private readonly int TAB_ORDENANDO = 4;
        private readonly int TAB_PESQUISA = 5;
        

        private int numerosParaGerar = 0;
        private string textoDaPesquisa = null;
        MySearchMethod pesquisa = null;

        public MainWindow()
        {
            InitializeComponent();
        }
    // Metodos
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

            //Gera os numeros aleatórios            
            atualizarProgresso(progresso, methodsLengh, "Gerando Numeros");
            SorterSetup.setup(numerosParaGerar);
            
            if (cb_BubbleSort.IsChecked == true)
            {                
                Bubble bubble = new Bubble();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, bubble.MethodName);
                bubble.sort();
                bubble.Record();
            }
            if (cb_CombSort.IsChecked == true)
            {
                Comb comb = new Comb();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, comb.MethodName);
                comb.sort();
                comb.Record();
            }
            if (cb_InsertionSort.IsChecked == true)
            {
                Insertion insertion = new Insertion();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, insertion.MethodName);
                insertion.sort();
                insertion.Record();
            }
            if (cb_MergeSort.IsChecked == true)
            {
                Merge merge = new Merge();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, merge.MethodName);
                merge.sort();
                merge.Record();
            }
            if (cb_QuickSort.IsChecked == true)
            {
                Quick quick = new Quick();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, quick.MethodName);
                quick.sort();
                quick.Record();
            }
            if (cb_SelectionSort.IsChecked == true)
            {
                Selection selection = new Selection();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, selection.MethodName);
                selection.sort();
                selection.Record();
            }
            if (cb_ShakeSort.IsChecked == true)
            {
                Shake shake = new Shake();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, shake.MethodName);
                shake.sort();
                shake.Record();
            }
            if (cb_ShellSort.IsChecked == true)
            {
                Shell shell = new Shell();
                progresso++;
                atualizarProgresso(progresso, methodsLengh, shell.MethodName);
                shell.sort();
                shell.Record();
            }

            atualizarProgresso(progresso, methodsLengh, "Ordenação Concluiía!!");
            button_Ordenacao.IsEnabled = true;
            button_Pesquisa.IsEnabled = true;
            button_VerEstatisticas.IsEnabled = true;
        }



        private void atualizarProgresso(int atual, int total, string nomeMetodo)
        {
            barraProgresso.Value = (atual * 100) / total;
            lbl_TitleOrdenando.Content = "ORDENANDO!" + "(" + atual + "/" + total + ")";
            if (nomeMetodo == null) return;
            lbl_MetodoEmExecucao.Content = nomeMetodo;
            if (txtBlock_ListaProgresso.Text.Length > 0)
            {
                int previousText = txtBlock_ListaProgresso.Text.IndexOf("Em Andamento", 0);
                txtBlock_ListaProgresso.Text = txtBlock_ListaProgresso.Text.Substring(0, previousText) + "(OK)\n";
                if (nomeMetodo.Equals("Ordenação Concluiía!!"))
                {
                    txtBlock_ListaProgresso.Text += "===== " + nomeMetodo + "=====";
                    return;
                }
            }
            txtBlock_ListaProgresso.Text += nomeMetodo + "..... \tEm Andamento\n";
        }

        // ================ BOTOES DO MENU SUPERIOR ============================== //
        private void Ordenacao_ButtonClicked(object sender, RoutedEventArgs e)
        {
            Tabs.SelectedIndex = TAB_ORDENACAO;
        }

        private void Pesquisa_ButtonClicked(object sender, RoutedEventArgs e)
        {
            Tabs.SelectedIndex = TAB_PESQUISA;
            pesquisa = new MySearchMethod();
        }

        // ================================== BOTOES E COMPONENTES DAS TELAS ===================================//
        // PESQUISA ==========================================================================================//
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Content de caixa de texto mudou
            textoDaPesquisa = MyTxtBox.Text;
        }

        private void Pesquisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            MyTxtBox.Text = pesquisa.filter(textoDaPesquisa, txt_Pesquisa.Text);            
        }



        // ORDENACAO ========================================================================== //
        private void SetupOrdenacao_ButtonClick(object sender, RoutedEventArgs e){  Tabs.SelectedIndex = TAB_SETUP_ORDENACAO;   }
        private void Historico_ButtonClick(object sender, RoutedEventArgs e){       Tabs.SelectedIndex = TAB_HISTORICO;         }
        private void Grafico_ButtonClick(object sender, RoutedEventArgs e){         Tabs.SelectedIndex = TAB_GRAFICO;           }
        private void OnlyNumbers_KeyUp(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(N_ToGenerate.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, Digite apenas números.");
                N_ToGenerate.Text = N_ToGenerate.Text.Remove(N_ToGenerate.Text.Length - 1);
            }
        }

        //SetupOrdenacao ========================================================================//
        private void Button_GerarNumerosOrdenar(object sender, RoutedEventArgs e)
        {
            int.TryParse(N_ToGenerate.Text, out numerosParaGerar);
            if (numerosParaGerar <= 0) MessageBox.Show("Digite a quantidade de numeros desejada para ordenar que seja maior que zero!");
            if (AmoutCheckBoxSelected == 0) MessageBox.Show("Selecione ao menos UM metodo de ordenação!!");
            Tabs.SelectedIndex = TAB_ORDENANDO;
            button_Ordenacao.IsEnabled = false;
            button_Pesquisa.IsEnabled = false;
        }

        private void TxtBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MyTxtBox.Text = textoDaPesquisa;
        }
    }
}