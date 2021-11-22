using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace kurs_22112021_42_HashTable_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            string devam;
            do
            {
                string eng;
                string tr;

                Console.WriteLine("Yeni kayıt eklemek ister misiniz? e/h");
            devam = Console.ReadLine();
            if (devam=="e")
            {
                
                Console.WriteLine("Eklemek istediğiniz kelimenin ingilizcesini giriniz:");
                eng = Console.ReadLine();


                if (h1.ContainsKey(eng))
                {
                    Console.WriteLine("bu değer daha önceden vardı.");
                }
                    else
                    {

                        Console.WriteLine("eklemek istediğiniz kelimenin türkçesini giriniz: ");
                        tr = Console.ReadLine();
                        h1.Add(eng, tr);
                    }
            }
            else if(devam=="h")
            {
                foreach (var item in h1.Keys)
                {
                    Console.WriteLine("eng: {0} - tr:{1}",item,h1[item]);
                }
            }

            } while (devam=="e");

            Console.ReadLine();

        }
    }
}