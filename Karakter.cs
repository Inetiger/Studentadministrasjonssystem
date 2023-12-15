using System;

namespace StudentAdministrasjonsSystem
{
    internal class Karakter
    {
        private Student _student;
        private Fag _fag;
        private int _karakterVerdi;

        public Karakter(Student student, Fag fag, int karakterVerdi)
        {
            _student = student;
            _fag = fag;
            _karakterVerdi = karakterVerdi;
        }

        public void SkrivUtInfo()
        {
            Console.Clear();
            Console.WriteLine($"Studenten {_student.SkrivUtStudentNavn} har fått {_karakterVerdi} i faget {_fag.SkrivUtFagNavn}");
        }
    }
}
