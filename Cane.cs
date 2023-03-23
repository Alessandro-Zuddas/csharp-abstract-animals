using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Cane : Animals, INuotante
    {
        public override void Mangia()
        {
            Console.WriteLine("Crocchette");
        }

        public override void Verso()
        {
            Console.WriteLine("Bau!");
        }

        public void Nuota()
        {
            Console.WriteLine("Il cane nuota!");
        }
    }
}
