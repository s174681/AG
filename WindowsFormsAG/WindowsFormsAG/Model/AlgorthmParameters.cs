using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAG.Model
{
     public class AlgorthmParameters
    {
         public int NumberOfChromosomes { get; set; }
         public int ReplaceByGeneration { get; set; }
         public int TrackBest { get; set; }
         public int NumberOfCrossoverPoints { get; set; }
         public int MutationSize { get; set; }
         public int CrossoverProbability { get; set; }
         public int MutationProbability { get; set; }
    

        public AlgorthmParameters()
        {
            NumberOfChromosomes = 100;
            ReplaceByGeneration = 8;
            TrackBest = 30;
            NumberOfCrossoverPoints = 2;
            MutationSize = 2;
            CrossoverProbability = 80;
            MutationProbability = 3;
            
        }
    }
}

