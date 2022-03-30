using System.Collections.Generic;

namespace PhoneBookConsoleApp
{
   public static class SampleData
    {
        public static void Load(this List<Person> listToInsert)
        {
            listToInsert.Add(new Person { Name = "Crawford", Surname = "Ramage", PhoneNumber = "406-381-2161" });
            listToInsert.Add(new Person { Name = "Jacquelynn", Surname = "Otter", PhoneNumber = "867-256-9148" });
            listToInsert.Add(new Person { Name = "Carolynn", Surname = "Corington", PhoneNumber = "775-337-8157" });
            listToInsert.Add(new Person { Name = "Ashby", Surname = "Shillabear", PhoneNumber = "797-187-5340" });
            listToInsert.Add(new Person { Name = "Daisie", Surname = "Sullly", PhoneNumber = "658-881-2090" });

        }
    }
}
