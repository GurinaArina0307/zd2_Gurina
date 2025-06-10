using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace zd_2_Gurina
{
    class PhoneBook
    {
        private List<Contact> contacts = new List<Contact>();


        //Метод для добавления нового контакта
        private void AddContact(string name, string phone)
        {
            contacts.Add(new Contact(name, phone));
        }



        //Метод для добавления нового контакта (перегрузка)
        public void AddContact(Contact contact)
        {
            if (string.IsNullOrWhiteSpace(contact.Name))
            {
                throw new ArgumentException("Имя не может быть пустым");
            }

            if (contact.Name.Any(char.IsDigit))
            {
                throw new ArgumentException("Имя не может содержать цифры");
            }

            if (string.IsNullOrWhiteSpace(contact.Phone))
            {
                throw new ArgumentException("Телефон не может быть пустым");
            }

            if (contact.Phone.Length < 5 || contact.Phone.Length > 15)
            {
                throw new ArgumentException("Телефон должен содержать от 5 до 15 символов");
            }

            if (!IsValidNumber(contact.Phone))
            {
                throw new ArgumentException("Телефон содержит недопустимые символы ");
            }

            if (contacts.Any(c => c.Name == contact.Name))
            {
                throw new ArgumentException("Контакт с данным именем уже существует");
            }

            if (contacts.Any(c => c.Phone == contact.Phone))
            {
                throw new ArgumentException("Контакт с данным телефоном уже существует");
            }
            contacts.Add(contact);
        }


        //Метод для удаления контакта
        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }


        //Метод для удаления контакта (перегрузка)
        public void RemoveContact(string name)
        {
            var contact = contacts.FirstOrDefault(c => c.Name == name);
            if (contact != null)
            {
                contacts.Remove(contact);
            }
            else
            {
                throw new ArgumentException("Контакт не найден для удаления");
            }
        }



        //Поиск контактов
        public List<Contact> SearchContact(string seatch)
        {
            return contacts.Where(c => c.Name.ToLower().Contains(seatch.ToLower())).ToList();
        }



        //Метод для вывода контактов с группировкой по имени
        public List<Contact> GetAllContacts()
        {
            return contacts.OrderBy(g => g.Name).ToList();
        }



        //Метод для проверки наличия контакта
        public bool ContainsPhone(string name)
        {
            return contacts.Any(c => c.Name == name);
        }


        //Проверка на правильность ввода номера
        public bool IsValidNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return false;
            }

            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }

            return true;
        }



        public void RemoveAllContacts()
        {
            if (contacts.Count > 0)
            {
                contacts.Clear();
            }
            else
            {
                throw new ArgumentException("Список пуст");
            }
        }
    }
}

