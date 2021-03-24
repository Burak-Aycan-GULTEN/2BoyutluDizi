using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BoyutluDiziÖdevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç ögrenci girmek istiyorsunuz:");
            int osayısı = int.Parse(Console.ReadLine());
            string[] ogrenci = new string[osayısı];
            int[] not = new int[osayısı];
            for (int i = 0; i < osayısı; i++)
            {
                Console.Write("Ögrenci Adını Girin:");
                ogrenci[i] = Console.ReadLine();
                Console.Write("Ögrenci Soyadını Girin:");
                ogrenci[i] = Console.ReadLine();
                Console.Write("Ögrenci Vize Notunu Girin:");
                not[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ögrenci Final Notunu Girin:");
                not[1] = Convert.ToInt32(Console.ReadLine());
                double donemsonuNotu = (not[0]*4/10 + not[1]*6/10);
                Console.WriteLine("Donem sonu notunuz"+donemsonuNotu);
                double harfnotu = (donemsonuNotu) / 25;
                Console.WriteLine("Donem sonu harf notunuz" + harfnotu);               
            }
            Console.ReadKey();           
        }           
    }
}
