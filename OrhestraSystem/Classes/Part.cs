using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class Part
    {
        private string tempoOfPart;
        private List<Note> notes;
        private double totalNumberOfBeats;
        private bool isChoros;

        public Part(List<Note> listOfNotes) {

            Notes = new List<Note>();
            this.Notes = listOfNotes;
        }

        public List<Note> Notes { get => notes; set => notes = value; }
        public double TotalNumberOfBeats { get => totalNumberOfBeats; set => totalNumberOfBeats = value; }
        public string TempoOfPart { get => tempoOfPart; set => tempoOfPart = value; }
        public bool IsChoros { get => isChoros; set => isChoros = value; }
    }
}
