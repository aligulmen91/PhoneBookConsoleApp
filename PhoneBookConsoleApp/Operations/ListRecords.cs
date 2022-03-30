using System;
using System.Collections.Generic;

namespace PhoneBookConsoleApp.Operations
{
   public static class ListRecords
    {
        public static void ListAll(this List<Person> listToShow)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach(var item in listToShow)
            {
                Console.WriteLine("isim: {0}", item.Name);
                Console.WriteLine("Soyisim: {0}", item.Surname);
                Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                Console.WriteLine("-");
            }
        }
    }
}
