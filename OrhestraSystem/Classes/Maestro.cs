using OrhestraSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class Maestro
    {
        private List<Piece> pieces;
        private List<Part> part;

        public Maestro(List<Piece> pieces)
        {
            this.pieces = pieces;
            SetTempoOfParts();
            SetTempoOfPieces();
        }

        public void SetTempoOfParts()
        {

            for (int i = 0; i < pieces.Count; i++)
            {
                for (int j = 0; j < pieces[i].ListOfParts.Count; j++)
                {
                    if (pieces[i].ListOfParts[j].TotalNumberOfBeats < 8) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.PRETISSIMO.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 8 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 16) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.VIVACE.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 16 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 18) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.ALLEGRETTO.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 18 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 22) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.MODERATO.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 22 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 23) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.ADAGIETTO.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 23 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 24) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.ANDANTE.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 24 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 27) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.LARGHETTO.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 27 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 29) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.LENTO.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 29 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 33) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.GRAVE.ToString(); }
                    else if (pieces[i].ListOfParts[j].TotalNumberOfBeats >= 33 && pieces[i].ListOfParts[j].TotalNumberOfBeats < 37) { pieces[i].ListOfParts[j].TempoOfPart = PartTempo.LARGHISSIMO.ToString(); }
                }
            }

        }

        public void SetTempoOfPieces()
        {
            for (int i = 0; i < pieces.Count; i++)
            {
                if (pieces[i].TotalNumberOfBeatsInPiece < 83) { pieces[i].TempoOfPiece = PieceTempo.LENTANDO.ToString(); }
                else if (pieces[i].TotalNumberOfBeatsInPiece >= 83 && pieces[i].TotalNumberOfBeatsInPiece < 125) { pieces[i].TempoOfPiece = PieceTempo.RITENUTO.ToString(); }
                else if (pieces[i].TotalNumberOfBeatsInPiece >= 125 && pieces[i].TotalNumberOfBeatsInPiece < 132) { pieces[i].TempoOfPiece = PieceTempo.STRETTO.ToString(); }
                else if (pieces[i].TotalNumberOfBeatsInPiece >= 132 && pieces[i].TotalNumberOfBeatsInPiece < 152) { pieces[i].TempoOfPiece = PieceTempo.ACCELERANDO.ToString(); }
            }

        }
    }
}

