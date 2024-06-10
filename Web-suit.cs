using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleDZ3
{
     class Web_suit
    {
        public string name { get; set; }       // название
        public string description { get; set; }  // описание
        public string title { get; set; }      // путь
        public string url { get; set; }     // ip адрес
        public string Name() { return name; } 
        public string Description() { return description; } 
        public string Title () { return title; } 
        public string Url () { return url; }
        public void Print()
        {
            Console.WriteLine($"Название сайта: {name}, Описание: {description}, Путь: {title}, Ip адрес: {url} ");
        }
    }
}
