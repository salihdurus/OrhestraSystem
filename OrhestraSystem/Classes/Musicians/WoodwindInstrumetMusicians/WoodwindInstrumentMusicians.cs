using OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OrhestraSystem.Classes
{
    class WoodwindInstrumentMusicians : IMusicians
    {
        private List<Piece> pieces;


        public virtual void Play(int y, int z) { }
        public WoodwindInstrumentMusicians(List<Piece> pieces)
        {
            this.pieces = pieces;

        }

        public WoodwindInstrumentMusicians() { }

        public void playPiece(int y, int z)
        {
            WoodwindInstrumentMusicians flutist = new Flutist(pieces);
            flutist.Play(y, z);
        }
    }
}



