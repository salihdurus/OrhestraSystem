using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class Concert
    {

        private List<Piece> pieces;

        private Maestro maestro;
        IMusicians SIM;
        IMusicians WWIM; 
        IMusicians PIM; 
        public Concert(List<Piece> pieces)
        {
            this.pieces = pieces;
            setChoros();
            maestro = new Maestro(pieces);
            SIM = new StringInstrumentMusicians(pieces);
            WWIM = new WoodwindInstrumentMusicians(pieces);
            PIM = new PercussionInstrumentMusicians(pieces);

        }
        public void Start()
        {
            CreateMusicians();
        }

        public void setChoros()
        {
            for (int i = 0; i < this.pieces.Count; i++)
            {
                this.pieces[i].SetChorosOfPieces();
            }
        }

        public void CreateMusicians()
        {
            ///değişiklik
            for (int i = 0; i < pieces.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Piece " + (i + 1) + " is played " + pieces[i].TempoOfPiece);

                for (int j = 0; j < pieces[i].ListOfParts.Count; j++)
                {
                    SIM.playPiece(i, j);
                    WWIM.playPiece(i, j);
                    PIM.playPiece(i, j);
                   
                }
                Console.WriteLine();
            }
        }
       
    }
}
