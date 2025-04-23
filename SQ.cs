using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class SQ: Distritoss
    {
        public SQ() : base("Preparate mano para el aburrimiento, tas en tu vida promedio en Surquillo.Nadie te quiere pues eres promedio,suerte Causha", "Dificultad: Normal por que ya vives esa vida mediocre")
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
