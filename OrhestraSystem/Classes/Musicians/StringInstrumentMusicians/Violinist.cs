using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians
{
    class Violinist:StringInstrumentMusicians
    {
        private List<Piece> pieces;
        public Violinist(List<Piece> pieces) { this.pieces = pieces; }

        public override void Play(int y, int z)
        {
            if (pieces[y].ListOfParts[z].TempoOfPart != "PRETISSIMO")
            {
                Console.WriteLine("Violin is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                {
                    Console.Write(pieces[y].ListOfParts[z].Notes[i].Symbol + " ");
                }
                Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                Console.WriteLine();
            }
        }
    }
}
