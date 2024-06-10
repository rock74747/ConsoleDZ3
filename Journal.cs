using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDZ3
{
     class Journal
    {
        public string name {  get; set; }
        public int age { get; set; }
        public string description { get; set; }
        public int contact { get; set; }
        public string email { get; set; }
        public string Name() { return name; }
        public int Age () { return age; }
        public string Description() { return description; }
        public int Contact () { return contact; }
        public string Email() { return email; }
        public void Print()
        {
            Console.WriteLine($"Название журнала: {name}, Год основания: {age}, Описание: {description}," +
                $" Телефон: {contact}, E-mail: {email} ");
        }
    }

}

