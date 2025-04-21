using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class MF: Distritoss
    {
        public MF() : base("Por fin hasta que decidiste vivir la vida que nunca tendras y sentir el no tener sueldo mínimo, disfruta tu vida en Miraflores Brother", "Dificultad: Facilongo pero igual te puedes morir causha")
        {
        }

        public override void MostrarOpciones()
        {
            Console.WriteLine("");
            Console.WriteLine("1.");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
        }
    }
}
