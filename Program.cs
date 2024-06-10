using System;
using System.Linq;
using System.Text;
using System.Xml.Linq;






namespace ConsoleDZ3
{
   
        
        

    
    class Program
    {
        
    static Web_suit GetWeb_suit()
        {
            Web_suit suit = new Web_suit();
            Console.WriteLine("Введите название сайта: ");
            suit.name = Console.ReadLine();
            Console.WriteLine("Описание: ");
            suit.description = Console.ReadLine();
            Console.WriteLine("Введите путь: ");
            suit. title = Console.ReadLine();
            Console.WriteLine("Введите ip адрес: ");
            suit. url = Console.ReadLine();
            return suit;
        }

        static Journal GetJournal()
        {
            Journal Journal = new Journal ();
            Console.WriteLine("Введите название журнала: ");
            Journal.name = Console.ReadLine();
            Console.WriteLine("Год основания: ");
            Journal.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Описание: ");
            Journal.description = Console.ReadLine();
            Console.WriteLine("Введите телефон: ");
            Journal.contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите email: ");
            Journal.email = Console.ReadLine();
            
            return Journal;
        }

        static Shop GetShop()
        {
            Shop Shop = new Shop();
            Console.WriteLine("Введите название магазина: ");
            Shop.name = Console.ReadLine();
            Console.WriteLine("Адресс магазина: ");
            Shop.adress = Console.ReadLine();
            Shop.description = Console.ReadLine();
            Console.WriteLine("Введите телефон: ");
            Shop.contact = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите email: ");
            Shop.email = Console.ReadLine();

            return Shop;
        }
        static void Change(ref int[] arr, int[] arr1)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr[i] == arr1[j]) {
                        int number = arr[i];
                        arr = arr.Where(e => e != number).ToArray();
                    }

                }
            Console.WriteLine(string.Join(" ", arr));

        }
        static void square(int s, char k)
        {
            for (int i = 0; i < s; i++)
            {
                for (int j = 0; j < s; j++)
                {
                    if (i == 0 || j == 0 || i == s - 1 || j == s - 1)
                    { Console.Write(k); }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
                
        }

        static bool Palindrom (ref string f)
        {
            int df = Convert.ToInt32(f);
            char[] ar = f.ToCharArray();
            Array.Reverse (ar); 
            string s = new string(ar);
            int d = Convert.ToInt32(s);
            if (d == df) { return true; }
            else { return false; }
        }
        static void Main(string[] args)
        {
         Console.WriteLine("Задача 1");
         Console.WriteLine("Введите сторону квадрата");
         int s = Convert.ToInt32 (Console.ReadLine());
         Console.WriteLine("Введите символ");
         char simbol = Convert.ToChar (Console.ReadLine());
         square(s, simbol);

         Console.WriteLine("Задача 2");
            Console.WriteLine("Введите число");
            string ch = Console.ReadLine();
            Console.WriteLine(Palindrom(ref ch)); ;


         Console.WriteLine("Задача 3");
         int[] arr = { 1, 2, 4, 5, 6, 7, 8, 9, 10};
         int[] arr1 = { 11, 7, 15, 16, 17, 1, 9, 12, 2,22};
         Change(ref arr, arr1);

         Console.WriteLine("Задача 4");

         Web_suit suit1 = GetWeb_suit ();
         suit1.Print();
         Console.WriteLine("Название сайта: " + suit1.Name());

         Console.WriteLine("Задача 5");

        Journal Journal1 = GetJournal ();
         Journal1.Print();
         Console.WriteLine("Название журнала: " + Journal1.Name());

         Console.WriteLine("Задача 6");
         Shop Shop1 = GetShop();
         Shop1.Print();
         Console.WriteLine("Название магазина: " + Shop1.Name());
        }
    }
}
