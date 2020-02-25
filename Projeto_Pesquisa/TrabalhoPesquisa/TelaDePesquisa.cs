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
    public partial class TelaDePesquisa : Form
    {
        private int matchCount = 0;

        public TelaDePesquisa()
        {
            InitializeComponent();
            lbl_Resultados.Text = "";
        }

        private void CaixaDePesquisa_TextChanged(object sender, EventArgs e)
        {
            realizarPesquisa();
            if(matchCount > 0) lbl_Resultados.Text = "Resultados: " + matchCount;
            else lbl_Resultados.Text = "";
        }


        private void realizarPesquisa()
        {
            //Zera resultados e limpa marcações
            limparMarcacoes();
            if (String.IsNullOrEmpty(caixaDePesquisa.Text) || caixaDePesquisa.Text.Trim().Length == 0) return;

            List<string> textoPesquisado = new List<string>();
            if (cb_ResultadoPerfeito.Checked) textoPesquisado.Add(caixaDePesquisa.Text);
            else foreach (string palavra in caixaDePesquisa.Text.Split(' ')) textoPesquisado.Add(palavra);
             
            foreach (string palavra in textoPesquisado)
            {
                //pega todos os index
                foreach (int index in allIndexOf(palavra))
                {
                    caixaDeTexto.SelectionStart = index;
                    caixaDeTexto.SelectionLength = palavra.Length;
                    caixaDeTexto.SelectionBackColor = Color.Yellow;
                    matchCount++;
                }

            }
        }

        private List<int> allIndexOf(string palavra)
        {
            List<int> searchIndex = new List<int>();
            int textLengh = caixaDeTexto.Text.Length;
            int start = 0;
            int at = 0;
            int count = 0;

            while ((start <= textLengh) && (at > -1))
            {
                count = textLengh - start;
                at = caixaDeTexto.Text.IndexOf(palavra, start, count);
                if (at == -1) break;
                searchIndex.Add(at);
                start = at + 1;
            }

            return searchIndex;
        }

        private void limparMarcacoes()
        {
            caixaDeTexto.SelectionStart = 0;
            caixaDeTexto.SelectAll();
            caixaDeTexto.SelectionBackColor = Color.White;
            matchCount = 0;
        }


        private void Button_Clear_Click(object sender, EventArgs e)
        {
            limparMarcacoes();
            lbl_Resultados.Text = "";
        }

        private void Cb_ResultadoPerfeito_CheckedChanged(object sender, EventArgs e)
        {
            realizarPesquisa();
            if (matchCount > 0) lbl_Resultados.Text = "Resultados: " + matchCount;
            else lbl_Resultados.Text = "";
        }
    }
}
