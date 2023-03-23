using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animals
    {
        public void Dormi()
        {
            Console.WriteLine("Zzzzzz...");
        }

        public abstract void Verso();

        public abstract void Mangia();
    }
}