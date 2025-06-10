using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zd_2_Gurina
{
    class PhoneBookLoader
    {
        //выгрузка контактов из файла
        public static void Load(PhoneBook phoneBook, string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(fileName))
            {
                var part = line.Split(new[] { ';' }, 2);
                if (part.Length == 2)
                {
                    var contact = new Contact(part[0], part[1]);

                    if (!phoneBook.ContainsPhone(contact.Name))
                    {
                        phoneBook.AddContact(contact);
                    }
                }
            }
        }

        public static void Save(PhoneBook phoneBook, string fileName)
        {
            var lines = phoneBook.GetAllContacts().Select(g => $"{g.Name};{g.Phone}");
            File.WriteAllLines(fileName, lines);
        }
    }
}
