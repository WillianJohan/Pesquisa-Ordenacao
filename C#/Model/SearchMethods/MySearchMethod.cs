using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.Model.SearchMethods
{
    class MySearchMethod
    {
        /*
         * Algorítimo deve ler arquivo e procurar por palavras
         * Ler um lbl, texto, String
         * 
         * 
         */

        private string text = null;
        private string word = null;

        public string Text { get => text; set => text = value; }
        public string Word { get => word; set => word = value; }

        public MySearchMethod(string _text)
        {
            Text = _text;
        }

        public MySearchMethod(){}

        public Boolean canIFoundThisInText(string _word)
        {

            return false;
        }

        public Boolean canIFoundThisInText(string _word, string _text)
        {

            return false;
        }
    }
}
