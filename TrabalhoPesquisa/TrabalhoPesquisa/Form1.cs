using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPesquisa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CaixaDePesquisa_TextChanged(object sender, EventArgs e)
        {
            caixaDeTexto.SelectionStart = 0;
            caixaDeTexto.SelectAll();
            caixaDeTexto.SelectionBackColor = Color.White;

            string[] words = caixaDePesquisa.Text.Split(' ');
            foreach (string palavra in words)
            {
                int startIndex = 0;
                while (startIndex < caixaDeTexto.TextLength)
                {
                    int wordStartIndex = caixaDeTexto.Find(palavra, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        caixaDeTexto.SelectionStart = wordStartIndex;
                        caixaDeTexto.SelectionLength = palavra.Length;
                        caixaDeTexto.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;
                    }
                    startIndex += wordStartIndex + palavra.Length;
                }
            }

        }

        private void CaixaDeTexto_TextChanged(object sender, EventArgs e)
        {
            
        }


        public void realizarPesquisa()
        {
            //Checa se caixa da pesquisa ta vazio


        }

        public void clear()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }
    }
}
