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

            SortMethods.Comb combSort = new SortMethods.Comb();
            combSort.sort();

            
        }

        private void MinN_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
