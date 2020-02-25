using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaOrdenacao.Model
{
    interface ISort
    {        
        void sort();
        void setupList();
        void Record();
        string getMethodName();
        Statistic getStatistics();        
    }
}
