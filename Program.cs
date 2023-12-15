using System;
using System.Collections.Generic;

namespace StudentAdministrasjonsSystem
{
    internal class Program
    {
        private new static readonly List<List<Fag>> fag = new List<List<Fag>>
        {
            new List<Fag>
            {
            new Fag("INF140", "Introduksjon til datasikkerheit", 10),
            new Fag("INF100", "Innføring i programmering", 10),
            new Fag("MAT111", "Grunnkurs i matematikk", 10),
            },
            new List<Fag>
            {
                new Fag("LOGO318", "Statistikkinnføring for logopeder", 5),
                new Fag("LOGO319", "Forskningsmetode og etikk – master i Logopedi", 10),
                new Fag("LOGO310", "Innføring i logopedi", 15),
            },
            new List<Fag>
            {
                new Fag("PED311", "Pedagogisk filosofi", 15),
                new Fag("PED313", "Kunnskap og kunnskapsprosessar", 15),
            }
        };

        private new static readonly List<Student> student = new List<Student>
        {
            new Student("Ine", 19, fag[0], 1),
            new Student("Tommy", 36, fag[1], 2),
            new Student("Arthur", 26, fag[2], 3),
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                switch (AskInt("1. se en student\n2. se fag\n3. se karakter"))
                {
                    case 1:
                        student[AskInt("Hvilken Student vil du se\n1. Ine\n2. Tommy\n3. Arthur") - 1].SkrivUtInfo();
                        break;
                    case 2:
                        fag[AskInt("Vil du se fagene til:\n1. Ine\n2. Tommy\n3. Arthur") - 1][AskInt("Vil du se:\n1. første fag\n2. andre faget\n3. tredje faget\n(Arthur har bare 2 fag)") - 1].SkrivUtInfo();
                        break;
                    case 3:
                        int studentNumb = AskInt("Hvilken student vil du se?\n1. Ine\n2. Tommy\n3. Arthur");
                        int fagNumb = AskInt("Vil du se:\n1. første fag\n2. andre faget\n3. tredje faget\n(Arthur har bare 2 fag)");
                        Random random = new Random();
                        new Karakter(student[studentNumb - 1], fag[studentNumb - 1][fagNumb - 1], random.Next(0, 7)).SkrivUtInfo();
                        break;
                    default:
                        Environment.Exit(1);
                        break;
                }

                Console.ReadLine();
            }
        }
        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int AskInt(string question)
        {
            return Convert.ToInt32(Ask(question));
        }
    }
}