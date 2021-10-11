using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{

    class List
    {
        List<string> name;
        int maxsize = 0;
        int size;
//       +  объединить два
//списка; --  удалить элемент из начала(--list); = =  проверка на
//равенство; true  проверка, пустой ли список
        public List()
        {
            this.name = new List<string>(200);
            this.maxsize = 200;
            this.size = 0;
        }public List(int size)
        {
            this.name = new List<string>(size);
            this.maxsize = size;
            this.size = 0;
        }
        public List add (string a)
        {
            if (this.size+1>this.maxsize)
            {
                Console.WriteLine("Превышен размер списка, элемент не добавлен");
                return this;
            }
            this.name.Add(a);
            this.size++;
            return this;
        }
       
        public static List operator +(List a, List b)
        {
            List n = new List(a.size+b.size);
            foreach (string i in b.name)
            {
                a.name.Add(i);
            }
            n = a;
            return n;
           
        }

        public static List operator --(List a)
        {
            a.name.RemoveAt(0);
            return a;
        }
        public static bool operator ==(List a, List b)
        {
            int j = 0;
            foreach (string i in a.name)
            {
                if (i != b.name[j]) return false;
                j++;
            }
            return true;
        }
        public static bool operator !=(List a, List b)
        {
            int j = 0;
            foreach (string i in a.name)
            {
                if (i != b.name[j]) return true;
                j++;
            }
            return false;
        }
        public static bool operator true(List a)
        {
            if (a.maxsize == 0) return true;
            else return false;
        }
        public static bool operator false(List a)
        {

            if (a.maxsize == 0) return false;
            else return true;
        }
        public static void Writelist(List a)
        {
           foreach(string i in a.name)
            {
                Console.WriteLine(i);
            }
        }
    }
}
