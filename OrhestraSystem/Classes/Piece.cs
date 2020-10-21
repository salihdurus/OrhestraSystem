using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace OrhestraSystem.Classes
{
    public class Piece
    {
        private string tempoOfPiece;
        private List<Part> listOfParts;
        private double totalNumberOfBeatsInPiece;

        public Piece(List<Part> listOfPart)
        {
            this.ListOfParts = listOfPart;
        }

        public List<Part> ListOfParts { get => listOfParts; set => listOfParts = value; }
        public double TotalNumberOfBeatsInPiece { get => totalNumberOfBeatsInPiece; set => totalNumberOfBeatsInPiece = value; }
        public string TempoOfPiece { get => tempoOfPiece; set => tempoOfPiece = value; }

        public void SetChorosOfPieces()
        {
            for (int i = 0; i < this.listOfParts.Count; i++)
            {
                for (int j = i; j < this.listOfParts.Count; j++)
                {
                    bool result = CompareNotesOfParts(this.listOfParts[i], this.listOfParts[j]);
                    this.ListOfParts[i].IsChoros = result;
                    this.listOfParts[j].IsChoros = result;
                }
            }

        }

        public bool CompareNotesOfParts(Part firstPart, Part secondPart)
        {
            bool result = false;
            List<bool> listOfBool = new List<bool>();

            if (firstPart.Notes.Count != secondPart.Notes.Count)
            {
                firstPart.IsChoros = false;
                secondPart.IsChoros = false;
            }
            else
            {
                for (int i = 0, j = 0; i < firstPart.Notes.Count && j < secondPart.Notes.Count; i++, j++)
                {
                    result = CompareNotes(firstPart.Notes[i], secondPart.Notes[j]);
                    listOfBool.Add(result);

                }
                firstPart.IsChoros = MergeResult(listOfBool);
                secondPart.IsChoros = firstPart.IsChoros;
            }

            return firstPart.IsChoros;
        }

        public bool CompareNotes(Note firstNote, Note secondNote)
        {
            if (firstNote.Symbol.Equals(secondNote.Symbol) && firstNote.Beat == secondNote.Beat)
            {
                return true;
            }
            else { return false; }
        }

        public bool MergeResult(List<bool> listOfBool)
        {
            bool actualResult = listOfBool[0];

            for (int i = 1; i < listOfBool.Count; i++)
            {
                actualResult = actualResult & listOfBool[i];
            }

            return actualResult;
        }

    }
}
