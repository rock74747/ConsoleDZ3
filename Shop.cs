using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ3
{
     class Shop
    {
        public string name { get; set; }
        public string adress { get; set; }
        public string description { get; set; }
        public int contact { get; set; }
        public string email { get; set; }
        public string Name() { return name; }
        public string Adress() { return adress; }
        public string Description() { return description; }
        public int Contact() { return contact; }
        public string Email() { return email; }
        public void Print()
        {
            Console.WriteLine($"Название магазина: {name}, Адресс: {adress}, Описание: {description}," +
                $" Телефон: {contact}, E-mail: {email} ");
        }
    }
}
