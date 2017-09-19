using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsAG.Model
{
    public class ThreadModelView
    {
        public float CurrentFitness { get; set; }
        public float TheBestFitness { get; set; }
        public int CurrentGeneration { get; set; }
        public bool IsTheBest { get; set; }

        public ThreadModelView()
        {
            IsTheBest = true;
        }
    }
}
