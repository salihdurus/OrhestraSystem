using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians
{
    class BellPlayer : PercussionInstrumentMusicians
    {
        private List<Piece> pieces;
        public BellPlayer(List<Piece> pieces) { this.pieces = pieces; }
        public override void Play(int y, int z)
        {
            if (pieces[y].TempoOfPiece == "GRAVE" || pieces[y].TempoOfPiece == "STRETTO")
            {
                Console.WriteLine("Bell is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                {
                    if (pieces[y].ListOfParts[z].Notes[i].Symbol == 'F' || pieces[y].ListOfParts[z].Notes[i].Symbol == 'G' || pieces[y].ListOfParts[z].Notes[i].Symbol == 'A' || pieces[y].ListOfParts[z].Notes[i].Symbol == 'B')
                    {
                        Console.Write(pieces[y].ListOfParts[z].Notes[i].Symbol + " ");
                    }
                    else
                    {
                        Console.Write("X" + " ");
                    }
                }
                Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                Console.WriteLine();
            }


        }
    }
}
