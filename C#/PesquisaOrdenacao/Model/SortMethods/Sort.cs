using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PesquisaOrdenacao.Model.SortMethods
{
    public abstract class Sort
    {
        //Read all the numbers and add to the list
        private string methodName = "";
        protected List<int> vetor = new List<int>();
        protected Int64 comparisons = 0;
        protected Int64 exchanges = 0;
        protected Stopwatch sw; //Calculate the time
        protected Statistic statistic;
        private bool isFinished = false; //Return true if the sorter is finished

        //Returns the name of sort method. 
        public string MethodName { get => methodName; set => methodName = value; }
        protected bool IsFinished { get => isFinished; set => isFinished = value; }

        public void setupList()
        {
            //Read the archive and add values in the list
            vetor = Control.FileManager.ReadUnsortedNumbers();
        }

        public void sort()
        {
            setupList();
            sw = Stopwatch.StartNew();
            StartSorter();
            sw.Stop();
            statistic = new Statistic(MethodName, sw.ElapsedMilliseconds.ToString(), comparisons.ToString(), exchanges.ToString());
            isFinished = true;
        }

        public Statistic getStatistics()
        {            
            return statistic;
        }

        protected abstract void StartSorter();
    }
}
