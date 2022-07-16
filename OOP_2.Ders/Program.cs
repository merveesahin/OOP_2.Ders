using System;

namespace OOP_2.Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            Ev ev = new Ev();
            ev.odaSayisi = 5;
            ev.KapiNumarasi = 511;

            Console.WriteLine("Kapı Numarası {0}", ev.KapiNumarasi);
            Console.WriteLine("Oda Sayısı {0}", ev.odaSayisi);
           
        }
    }
}
