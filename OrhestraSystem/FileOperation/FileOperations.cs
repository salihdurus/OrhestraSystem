using OrhestraSystem.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.FileOperations
{
    public class FileOperation
    {

        private string fileName;


        public FileOperation()
        {

        }

        public FileOperation(string fileName)
        {

            this.fileName = fileName;

        }
        public List<Piece> ReadPieces()
        {
            List<Piece> listOfPiece = new List<Piece>();
            for (var i = 0; i < 4; i++)
            {
                string[] lines = File.ReadAllLines(this.fileName + "piece" + (i + 1) + ".txt");
                lines = DiscardSpaces(lines);
                Piece currentPiece;
                List<Part> listOfPart = new List<Part>();
                for (var j = 0; j < lines.Length; j++)
                {
                    List<Note> listOfNotes = new List<Note>();
                    Part part;
                    string[] splitted = lines[j].Split();

                    for (var k = 0; k < splitted.Length; k++)
                    {
                        Note currentNode = new Note();
                        if (splitted[k].Length != 0)
                        {
                            currentNode = SeparateCharFromNumbers(splitted[k]);
                        }
                        listOfNotes.Add(currentNode);
                    }

                    part = new Part(listOfNotes);
                    listOfPart.Add(part);

                }

                currentPiece = new Piece(listOfPart);
                listOfPiece.Add(currentPiece);

            }

            for (var i = 0; i < listOfPiece.Count; i++)
            {
                List<Part> currentPartList = listOfPiece[i].ListOfParts;
                var totalNumberOfBeatsInPiece = 0.0;
                for (var j = 0; j < currentPartList.Count; j++)
                {
                    List<Note> listOfNotes = currentPartList[j].Notes;
                    var totalNumberOfBeat = 0.0;

                    for (var k = 0; k < listOfNotes.Count; k++)
                    {
                        Note currentNote = listOfNotes[k];
                        totalNumberOfBeat += currentNote.Beat;
                        totalNumberOfBeatsInPiece += currentNote.Beat;
                    }

                    currentPartList[j].TotalNumberOfBeats = totalNumberOfBeat;

                }

                listOfPiece[i].TotalNumberOfBeatsInPiece = totalNumberOfBeatsInPiece;

            }

            return listOfPiece;
        }

        public string[] DiscardSpaces(string[] lines)
        {

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Trim();
            }

            return lines;
        }


        private Note SeparateCharFromNumbers(string originalString)
        {
            string letters = string.Empty;
            string numbers = string.Empty;

            foreach (char c in originalString)
            {
                if (Char.IsLetter(c))
                {
                    letters += c;
                }

                if (Char.IsNumber(c))
                {
                    numbers += c;
                }
            }

            Note note = new Note(letters.Length == 1 ? letters[0] : ' ', numbers.StartsWith("0") ? Convert.ToDouble(numbers.Replace("0", "0,")) : Convert.ToDouble(numbers));



            return note;
        }



    }
}
