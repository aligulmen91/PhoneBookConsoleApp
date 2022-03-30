using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsoleApp.Operations
{
    public static class UpdateRecord
    {
        private enum Desicion : byte
        {
            End = 1,
            Retry = 2
        }
        public static void UpdateExistingRecord(this List<Person> listToUpdate)
        {
            Person PersonToUpdate = new();
            Person PersonExist = new();
            string nameToFind;

            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            nameToFind = Console.ReadLine().Trim().ToLower();

            PersonToUpdate = listToUpdate.Where(p => p.Name.ToLower() == nameToFind || p.Surname.ToLower() == nameToFind).FirstOrDefault();
            if (PersonToUpdate is null)
            {
                Desicion desicion = 0;
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                desicion = (Desicion)TryParseIfPossible.FromStringToByte(Console.ReadLine());

                switch (desicion)
                {
                    case Desicion.End:  break;
                    case Desicion.Retry: listToUpdate.UpdateExistingRecord(); break;
                    default: Console.WriteLine("Hatalı Seçim!");  break;

                }
            }

            else
            {
                PersonExist = PersonToUpdate;  
                Console.WriteLine("Lütfen isim giriniz             :");
                Console.WriteLine("Güncel İsim : {0}",PersonToUpdate.Name);
                PersonToUpdate.Name = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz          :");
                Console.WriteLine("Güncel Soyisim : {0}", PersonToUpdate.Surname);
                PersonToUpdate.Surname = Console.ReadLine();
                Console.WriteLine("Lütfen telefon numarası giriniz :");
                Console.WriteLine("Güncel Numara : {0}", PersonToUpdate.PhoneNumber);
                PersonToUpdate.PhoneNumber = Console.ReadLine();
                listToUpdate.Remove(PersonExist);
                listToUpdate.Add(PersonToUpdate);
            }


        }
    }
}
