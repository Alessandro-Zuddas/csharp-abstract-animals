using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animals, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("Vermi");
        }

        public override void Verso()
        {
            Console.WriteLine("Cip cip!");
        }

        public void Vola()
        {
            Console.WriteLine("Il passerotto vola!");
        }
    }
}
