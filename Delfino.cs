using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animals, INuotante
    {
        public override void Mangia()
        {
            Console.WriteLine("Pesce");
        }

        public override void Verso()
        {
            Console.WriteLine("Canto");
        }

        public void Nuota()
        {
            Console.WriteLine("Il delfino nuota!");
        }
    }
}
