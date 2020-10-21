using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians
{
    class Drummer:PercussionInstrumentMusicians
    {
        private List<Piece> pieces;
        public Drummer(List<Piece> pieces) { this.pieces = pieces; }
        public override void Play(int y, int z)
        {
            if (pieces[y].ListOfParts[z].TempoOfPart == "PRETISSIMO" || pieces[y].ListOfParts[z].TempoOfPart == "VIVACE" || pieces[y].ListOfParts[z].TempoOfPart == "ALLEGRETTO")
            {
                Console.WriteLine("Drum is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                {
                    if (pieces[y].ListOfParts[z].Notes[i].Symbol == 'C' || pieces[y].ListOfParts[z].Notes[i].Symbol == 'D' || pieces[y].ListOfParts[z].Notes[i].Symbol == 'E')
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
