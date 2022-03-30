using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBookConsoleApp.Operations
{
    public static class DeleteRecord
    {
        private enum Desicion : byte
        {
            End =1,
            Retry = 2
        }
       

        public static void DeleteSelectedRecords(this List<Person> listToDeleteFrom)
        {
            Person PersonToDelete = new();
            string nameToFind;
            Console.WriteLine("");
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            nameToFind = Console.ReadLine().Trim().ToLower();

            PersonToDelete =  listToDeleteFrom.Where(p => p.Name.ToLower() == nameToFind || p.Surname.ToLower() == nameToFind).FirstOrDefault();
            if (PersonToDelete is null)
            {
                Desicion desicion = 0;
                Console.WriteLine("");
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                desicion = (Desicion)TryParseIfPossible.FromStringToByte(Console.ReadLine());

                switch (desicion)
                {
                    case Desicion.End:  break;
                    case Desicion.Retry: listToDeleteFrom.DeleteSelectedRecords(); break;
                    default: Console.WriteLine("Hatalı Seçim!");  break;
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", PersonToDelete.Name);
                char confirmation = Console.ReadLine()[0];

                switch (confirmation)
                {
                    case 'y': listToDeleteFrom.Remove(PersonToDelete);  break;
                    case 'n': listToDeleteFrom.DeleteSelectedRecords(); break;
                    default: Console.WriteLine("Hatalı Seçim!");  break;

                }
            }

          
        }
    }
}
