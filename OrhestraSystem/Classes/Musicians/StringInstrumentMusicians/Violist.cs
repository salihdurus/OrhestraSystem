using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes.Musicians.WoodwindInstrumetMusicians
{
    class Violist:StringInstrumentMusicians
    {
        private List<Piece> pieces;
        public Violist(List<Piece> pieces) { this.pieces = pieces; }

        public override void Play(int y, int z)
        {
            if (pieces[y].TempoOfPiece== "RITENUTO")
            {
                if (z < 1)
                {
                    Console.WriteLine("Violo is played:");
                    Console.Write("Part" + (z + 1) + ": ");
                    for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                    {
                        Console.Write(pieces[y].ListOfParts[z].Notes[i].Symbol + " ");
                    }
                    Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Violo is played:");
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
