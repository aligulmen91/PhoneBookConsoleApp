using PhoneBookConsoleApp.Operations;
using System;
using System.Collections.Generic;

namespace PhoneBookConsoleApp
{
    class Program
    {
        public static List<Person> Phonebook = new List<Person>();
        static void Main(string[] args)
        {
            Operation selectedOperation = 0;
            Phonebook.Load();

            while (selectedOperation != Operation.Exit)
            {
                MainMenu.Show();
                selectedOperation = (Operation)Convert.ToByte(Console.ReadLine());

               

                
                switch (selectedOperation)
                {
                    case Operation.Add: Phonebook.AddNewRecord(); break;
                    case Operation.Delete: Phonebook.DeleteSelectedRecords(); break;
                    case Operation.Update: Phonebook.UpdateExistingRecord(); break;
                    case Operation.List: Phonebook.ListAll(); break;
                    case Operation.Search: Phonebook.SearchRecordsWithParameter(); break;
                    case Operation.Exit: Console.WriteLine("Çıkış Yapılıyor"); break;
                    default: Console.WriteLine("hatalı seçim!"); break;
                }




               
            }


        }
    }
}
