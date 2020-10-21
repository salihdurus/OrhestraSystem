using OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class StringInstrumentMusicians :IMusicians
    {
        private List<Piece> pieces;

        public StringInstrumentMusicians(List<Piece> pieces)
        {
            this.pieces = pieces;
        }
        public StringInstrumentMusicians() { }
        public void playPiece(int y, int z)
        {
            StringInstrumentMusicians violinist = new Violinist(pieces);
            StringInstrumentMusicians celloist = new Celloist(pieces);
            StringInstrumentMusicians violist = new Violist(pieces);
            violinist.Play(y,z);
            celloist.Play(y, z);
            violist.Play(y, z);
        }
      public virtual void Play(int y,int z) { }
    

        
    }
}
