﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    
        public class Canli
        {
            public int ayak;
            public int el;
            public string tur;
        }
        class Insan: Canli
        {
            public void Konus()
            {
                Console.WriteLine("benim {0} adet elim ve {1} ayagım var", el, ayak);
                Console.ReadLine();
            }
        }
        class Kopek : Canli
        {
            public void Havla()
            {
                Console.WriteLine("hav");
                Console.ReadLine();
            }
    }
}
