using System;
using System.Collections.Generic;

namespace StudentAdministrasjonsSystem
{
    internal class Student
    {
        private string _navn;
        private int _alder;
        private List<Fag> _studieProgram;
        private int _studieID;

        public Student(string navn, int alder, List<Fag> studieProgram, int studieId)
        {
            _navn = navn;
            _alder = alder;
            _studieProgram = studieProgram;
            _studieID = studieId;
        }

        public void SkrivUtInfo()
        {
            Console.Clear();
            Console.WriteLine($"Student {_navn} er {_alder} år gammel, deres StudieID er {_studieID} og har: {SkrivUtStudiePorgram()}");
            Console.WriteLine($"\nGjennomsnittskarakteren er {gjennomsnittsKarakter.ToString("F2")}");
            Console.WriteLine($"\nStudenten for totalt {studiePoeng} studiepoeng for studie de går");
        }

        public double gjennomsnittsKarakter;
        public int studiePoeng;
        private string SkrivUtStudiePorgram()
        {
            string StudyProgram = null;

            Random random = new Random();
            int rand = 0;
            foreach (var program in _studieProgram)
            {
                StudyProgram += $"\n* {program.SkrivUtFagNavn} karakter: {rand = random.Next(0, 7)}";
                gjennomsnittsKarakter += rand;
                studiePoeng += program.SkrivUtStudiePoeng;
            }

            gjennomsnittsKarakter /= _studieProgram.Count;
            return StudyProgram;
        }

        public string SkrivUtStudentNavn => _navn;
    }
}
