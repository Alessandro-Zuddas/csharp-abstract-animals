﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animals, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("Piccoli mammiferi");
        }

        public override void Verso()
        {
            Console.WriteLine("Grido");
        }

        public void Vola()
        {
            Console.WriteLine("L'aquila vola!");
        }
    }
}
