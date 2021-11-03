using System;
using MyLibrary.MyCollection;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            KeeperList<string> list = new KeeperList<string>();
            list.Add("Hello ");
            list.Add("my ");
            list.Add("friends. ");
            list.Add("Bay");
            list.Add("friend");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(list.FirstGet());
            Console.WriteLine("-------------------------------------------");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            list.Remove("Bay");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(list.LastGet() +"\n");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(list.LastGet() + "\n");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(list.LastGet() + "\n");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(list.LastGet() + "\n");
            foreach (var item in (KeeperList<string>)list)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
