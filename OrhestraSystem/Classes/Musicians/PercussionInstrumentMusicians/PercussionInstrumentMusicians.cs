using OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians;
using System;
using System.Collections.Generic;

namespace OrhestraSystem.Classes
{
    class PercussionInstrumentMusicians: IMusicians
    {
        private List<Piece> pieces;


        public PercussionInstrumentMusicians(List<Piece> pieces)
        {
            this.pieces = pieces;

        }
        public PercussionInstrumentMusicians() { }
        public virtual void Play(int y,int z) { }
        public void playPiece(int y,int z)
        {
            PercussionInstrumentMusicians bellplayer = new BellPlayer(pieces);
            PercussionInstrumentMusicians drummer = new Drummer(pieces);
            if (pieces[y].ListOfParts.Count - z < 3)
            {
            drummer.Play(y, z);
            bellplayer.Play(y, z);
            }
        }
    }
}
