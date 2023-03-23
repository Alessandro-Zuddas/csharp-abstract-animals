using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class PulcinellaDiMare : Animals, IVolante, INuotante
    {
        public override void Mangia()
        {
            Console.WriteLine("Pesci e insetti");
        }

        public override void Verso()
        {
            Console.WriteLine("Cip cip cip!");
        }

        public void Vola()
        {
            Console.WriteLine("La pulcinella di mare vola!");
        }

        public void Nuota()
        {
            Console.WriteLine("La pulcinella di mare nuota!");
        }
    }
}
