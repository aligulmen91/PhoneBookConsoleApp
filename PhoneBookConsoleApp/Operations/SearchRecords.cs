using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsoleApp.Operations
{
    public static class SearchRecords
    {
        private enum Desicion : byte
        {
            WithNameOrSurname = 1,
            WithNumber = 2
        }

        public static void SearchRecordsWithParameter(this List<Person> listToSearch)
        {
            List<Person> PeopleFound = new();
            Desicion desicion = 0;
            string nameToFind;
            string numberToFind;

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            desicion = (Desicion)TryParseIfPossible.FromStringToByte(Console.ReadLine());

            switch (desicion)
            {
                case Desicion.WithNameOrSurname:
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    nameToFind = Console.ReadLine().Trim().ToLower();
                    PeopleFound = listToSearch.Where(p => p.Name.ToLower() == nameToFind || p.Surname.ToLower() == nameToFind).ToList();
                    break;
                case Desicion.WithNumber:
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    numberToFind = Console.ReadLine().Trim();
                    PeopleFound = listToSearch.Where(p => p.PhoneNumber == numberToFind).ToList();
                    break;
                default: Console.WriteLine("Hatalı Seçim!"); MainMenu.Show(); break;
            }

            Console.WriteLine("Arama Sonuçlarınız");
            Console.WriteLine("**********************************************");
            foreach (var item in PeopleFound)
            {
                Console.WriteLine("isim: {0}", item.Name);
                Console.WriteLine("Soyisim: {0}", item.Surname);
                Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                Console.WriteLine("-");
            }

        }
    }
}
