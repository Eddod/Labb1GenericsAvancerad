using System;
using System.Linq;
using System.Collections.Generic;

namespace Labb1GenericsAvancerad
{
    class Program
    {
        static void Main(string[] args)
        {
            LådaCollection LList = new LådaCollection();

            LList.Add(new Låda(10, 10, 10));
            LList.Add(new Låda(30, 30, 30));
            LList.Add(new Låda(15, 55, 22));
            LList.Add(new Låda(12, 55, 21));
            LList.Add(new Låda(40, 45, 52));



            Display(LList);

            LList.Add(new Låda(10, 10, 10));

            Console.WriteLine("--------------");
            Console.WriteLine("Remove låda med 30x15x30 dimension");
            LList.Remove(new Låda(30, 30, 30));
            Display(LList);

            //Contains method compare two objects
            Låda LådTestContains = new Låda(10, 10, 10);
            Console.WriteLine("Contains {0}x{1}x{2} : {3}",
                LådTestContains.höjd.ToString(), LådTestContains.längd.ToString(),
                LådTestContains.bredd.ToString(), LList.Contains(LådTestContains, new LådaSameValue()).ToString());


            Console.ReadKey();
        }
        public static void Display(LådaCollection lådaList)
        {
            Console.WriteLine("\nHöjd\tLängd\tBredd\tHash Code");

            foreach (Låda l in lådaList)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    l.höjd.ToString(),
                    l.längd.ToString(),
                    l.bredd.ToString(),
                    l.GetHashCode().ToString());
            }
        }

    }

}
