using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2.Ders
{
    public class Ev
    {
        private int kapiNumarasi;

        public int odaSayisi { get; set; }
        public int KapiNumarasi
        {
            get
            {
                return kapiNumarasi;
            }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Kapı Numarası 100'den büyük olamaz !!!");
                }
                else
                {
                    this.kapiNumarasi = value;
                }
            }
        }
    }
}
