using System;
using System.Collections.Generic;

namespace PesquisaOrdenacao.Control
{
    /// <summary>
    /// Responsable to generate randon numbers and save to a file called "UnsortedNumbers.txt". 
    /// </summary>
    public static class SorterSetup
    {
        public static void setup(int total)
        {
            Random rand = new Random();
            List<int> randomNumbers = new List<int>();
            for(int i = 0; i < total; i++) randomNumbers.Add(rand.Next(0, 1000));
            FileManager.RecordUnsortedNumbers(randomNumbers);
        }
    }
}