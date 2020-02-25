using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PesquisaOrdenacao.Model
{
    public abstract class Sort : ISort
    {
        //Read all the numbers and add to the list
        private string methodName = "";
        protected List<int> listOfUnsortedNumbers = new List<int>();
        protected Int64 comparisons = 0;
        protected Int64 exchanges = 0;
        protected Stopwatch stopwatch; //Stores the execution time of the ordering method
        protected Statistic statistic; //Stores all the data of time, exchanges and comparations.
        private bool isFinished = false; //Return true if the sorter is finished.

        //Returns the name of sort method. 
        public string MethodName { get => methodName; set => methodName = value; }
        protected bool IsFinished { get => isFinished; set => isFinished = value; }

        public void setupList()
        {
            //Read the archive and add values in the list
            listOfUnsortedNumbers = Control.FileManager.ReadUnsortedNumbers();
        }

        public void sort()
        {
            setupList();
            stopwatch = Stopwatch.StartNew();
            StartSorter();
            stopwatch.Stop();
            statistic = new Statistic(MethodName, stopwatch.Elapsed.ToString(), comparisons.ToString(), exchanges.ToString());
            IsFinished = true;
        }

        public void Record()
        {
            Control.FileManager.RecordUnsortedNumbers(listOfUnsortedNumbers, MethodName);
        }

        public Statistic getStatistics()
        {            
            return statistic;
        }

        protected abstract void StartSorter();

        public string getMethodName()
        {
            return MethodName;
        }
    }
}
