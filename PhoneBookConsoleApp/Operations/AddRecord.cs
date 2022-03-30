using System;
using System.Collections.Generic;

namespace PhoneBookConsoleApp.Operations
{
    public static class AddRecord
    {
        public static void AddNewRecord(this List<Person> listToInsert)
        {
            Person PersonToAdd = new();

            Console.WriteLine("Lütfen isim giriniz             :");
            PersonToAdd.Name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            PersonToAdd.Surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            PersonToAdd.PhoneNumber = Console.ReadLine();

            listToInsert.Add(PersonToAdd);
        }
    }
}
