using System;

namespace StudentAdministrasjonsSystem
{
    internal class Fag
    {
        private string _fagKode;
        private string _fagNavn;
        private int _antallStudiePoeng;

        public Fag(string fagKode, string fagNavn, int antallStudiePoeng)
        {
            _fagKode = fagKode;
            _fagNavn = fagNavn;
            _antallStudiePoeng = antallStudiePoeng;
        }

        public void SkrivUtInfo()
        {
            Console.Clear();
            Console.WriteLine($"Faget {_fagNavn} er et fag en kan studere med fagkode: {_fagKode} og en kan få {_antallStudiePoeng} studiepoeng får å gå faget.");
        }

        public string SkrivUtFagNavn => _fagNavn;

        public int SkrivUtStudiePoeng => _antallStudiePoeng;
    }
}
