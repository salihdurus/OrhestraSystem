using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class Note
    {
        private char symbol;
        private double beat;

        public Note() { 
        
        }
        public Note(char symbol, double beat) {

            this.Beat=  beat;
            this.Symbol = symbol;
        }

        public char Symbol { get => symbol; set => symbol = value; }
        public double Beat { get => beat; set => beat = value; }
    }
}
