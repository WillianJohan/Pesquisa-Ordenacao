using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesquisaOrdenacao
{
    public partial class MainWindow : Form
    {
        private Stopwatch sw;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int gerados = (int)totGerados.Value;
            SortMethods.SorterSetup.setup(gerados);
            //comaca aqui

            lbl_StatusBubble.Text = "Em Execucao";
            SortMethods.CombSort combSort = new SortMethods.CombSort();
            combSort.setupList();
            sw = Stopwatch.StartNew();
            combSort.sort();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();
            lbl_StatusBubble.Text = "Finalizado";


            lbl_StatusInsertion.Text = "Em Execucao";
            SortMethods.InsertionSort insertionSort = new SortMethods.InsertionSort();
            insertionSort.setupList();            
            sw = Stopwatch.StartNew();
            insertionSort.sort();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();
            lbl_StatusInsertion.Text = "Finalizado";
            
            lbl_StatusSelection.Text = "Em Execucao";
            SortMethods.SelectionSort selectionSort = new SortMethods.SelectionSort();
            selectionSort.setupList();
            sw = Stopwatch.StartNew();
            selectionSort.sort();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();
            lbl_StatusSelection.Text = "Finalizado";

            lbl_StatusBubble.Text = "Em Execucao";
            SortMethods.BubbleSort bubbleSort = new SortMethods.BubbleSort();
            bubbleSort.setupList();
            sw = Stopwatch.StartNew();
            bubbleSort.sort();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Stop();
            lbl_StatusBubble.Text = "Finalizado";


        }

        private void MinN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
