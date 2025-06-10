using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_2_Gurina
{
    class Contact
    {
        public string Name { get; set; } //Имя
        public string Phone { get; set; }//Телефон

        public Contact(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name} - {Phone}";
        }
    }
}
