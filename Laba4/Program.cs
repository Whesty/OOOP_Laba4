using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            List a1 = new List();
            a1.add("b");
            a1.add("c");
            a1.add("d");
            a1.add("e");
            a1.add("f");       
            List a2 = new List();
            a2.add("h");
            a2.add("v");
            a2.add("n");
            a2.add("m");
            a2.add("l");

            Console.WriteLine("\n+ Обьеденение двух списков");
            List a3 = new List();
            a3 = a1 + a2;
            List.Writelist(a3);

            Console.WriteLine("\n== Равны ли два списка: ");
            if (a1 == a1) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.WriteLine("\n-- Удаление элемента с начала списка");
            List.Writelist(a1);
            Console.WriteLine("-");
            --a1;
            List.Writelist(a1);

            Console.WriteLine("true пустой ли список?");

            if (a1) Console.WriteLine("true");
            else Console.WriteLine("false");
        }
    }
}
