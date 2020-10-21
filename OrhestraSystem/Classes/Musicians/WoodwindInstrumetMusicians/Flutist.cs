using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians
{
    class Flutist : WoodwindInstrumentMusicians
    {
        private List<Piece> pieces;
        public Flutist(List<Piece> pieces)
        {
            this.pieces = pieces;

        }
        public override void Play(int y, int z)
        {
            if (pieces[y].ListOfParts[z].IsChoros == true)
            {
                Console.WriteLine("Flute is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int j = 0; j < pieces[y].ListOfParts[z].Notes.Count; j++)
                {
                    Console.Write(pieces[y].ListOfParts[z].Notes[j].Symbol + " ");
                }
                Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                Console.WriteLine();
            }
        }
    }
}
