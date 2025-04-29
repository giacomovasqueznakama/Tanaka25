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
            Console.WriteLine("Bien respawneas en tu cama mientras te llaman para que desayunes, como flojo no quieres levantarte ni moverte hasta el momento que te acuerdas que hoy tienes clases temprano, te alistas rápido pero ahora tu pasaje no da para mucho, que decides hacer?");
            Console.WriteLine("1.Tomar 1 taxi");
            Console.WriteLine("2.Tomar micro");
            Console.WriteLine("3.Ir corriendo");
        }

        public void MostrarOpciones1()
        {
            Console.WriteLine("Ante este momento de desesperacion que tendrias que hacer?");
            Console.WriteLine("1.Parar el taxi e ir a hablarle");
            Console.WriteLine("2.Saltar del carro en movimiento");
            Console.WriteLine("3.Seguir llendo a tu uni");
        }

        public void MostrarOpciones2()
        {
            Console.WriteLine("Mientras estan en el apretado micro escuchas  desde adelante que el chico raro era un choro que empieza a amenazar a la gente para que le den plata, que haces?");
            Console.WriteLine("1.Finges 1 ataque al corazon");
            Console.WriteLine("2.Te haces el heroe");
            Console.WriteLine("3.Tu no tienes enemigos");
        }

        public void MostrarOpciones3()
        {
            Console.WriteLine("Las opcionesson pocas pero debes actuar, que haces?");
            Console.WriteLine("1.Corres");
            Console.WriteLine("2.Acortas camino");
            Console.WriteLine("3.Pides ayuda");
        }

    }
}

