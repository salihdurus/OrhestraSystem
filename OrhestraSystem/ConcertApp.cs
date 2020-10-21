using OrhestraSystem.Classes;
using OrhestraSystem.FileOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem
{
    public class ConcertApp
    {

        public static string BASE_FILE_NAME = @"C:\Users\hp\Documents\Visual Studio 2015\Projects\OrhestraSystem\OrhestraSystem\pieces\";
        static void Main(string[] args)
        {
            List<Piece> pieces = new List<Piece>();
            FileOperation fileOperations = new FileOperation(BASE_FILE_NAME);
            pieces = fileOperations.ReadPieces();
            Concert concert = new Concert(pieces);
            concert.Start();
            Console.Read();
        }
    }
}
