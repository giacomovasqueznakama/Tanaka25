using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class SQ : Distritoss, IOpciones
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
            Console.WriteLine("Mientras estan en el apretado micro escuchas desde adelante que el chico raro era un choro que empieza a amenazar a la gente para que le den plata, que haces?");
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

        public void ProcesarOpcion1(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Sales corriendo y la ves defrente, era tan hermosa como la viste y sin esperar mas le hablas, tras años de lindos momentos se casan y viven felices, lo hicise bien muchacho");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Ves una luz intensa mientras te elevas en los aires hasta que llegas a cielo, al parecer saltar de 1 carro en movimiento no fue la mejor de tus ideas ya que ni bien saliste te estampaste la cara contra el suelo, suerte para la proxima amigo");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Pasas años estudiando y sin haber podido amar denuevo, llegas a tener una empresa multimillonaria pero termina quebrando asi como ru corazon que esta hecho pesazos te sumes en la depresion y terminas chambeando en al tolouse");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        public void ProcesarOpcion2(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ni bien lo ves acercandose te tiras al piso haciendote el morido, no das tiempo a pensar al choro cuando se tira donde estas e intenta darte respiracion boca a boca para intentar salvarte, no es algo que te enorgullescas pero al menos detuviste el asalto, la gente nunca lo olvidara");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Recuerdas todos los animes que has visto hasta ahora y te armas de valor para atacarlo. Cargas contra el pero la combi seguia en movimiento y terminas perdiendo el equilibrio y callendo sobre el, para tu suerte lo noqueaste y terminas siendo el heroe que siempre quisiste ser, ese día no te cobraron el pasaje");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Te acercas firmemente al ladron tranquilo y con una vos tranquila le dices: escuchame, por que haces esto, no debes atacar a la gente, a quien quieres hacerle daño, por que, escuchame bien ladron-kun, tu no tienes enemigos, nadie tiene enemigos, nadie en este mundo merece ser lastimado. Tus palabras resuenan en la cabeza de todos los presentes los cuales deciden olvidar ese momento y mejorar como personas, nadie tiene enemigos y tu perdiste tu día de clases ya que hasta el conductor quiso ir a reflexionar despues de eso");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        public void ProcesarOpcion3(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Tras caminar 1 poco decides aumentar la velocidad, al poco tiempo te das cuenta que estas corriendo pero algo era raro, la velocidad que tenias era cada vez mayor, era soprendente poco a poco veias como los demas a tu alrededor se relentizaban y al poco tiempo llegas a tu uni. La experiencia fue increible lo malo es que tu corazon se detuvo tras alcanzar tu destino, no combinen Monster con retbull y mas si tienes problemas al corazon ");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Decides ir por un camino alterno con la esperanza de acortar camino, poco a poco te vas alejando de los lugares que conoces y cuando te das cuenta te encuentras totalmente solo. No piensas que es malo hasta que vez en medio de la calle a 1 sola persona que te mira, intentas pensar que no pasa nada pero esta se te acerca y cuando esta cerca de ti........Te invita a ser tu propio jefe, era un recluta de una empresa que busca pagarte millones y en tu falta de criterio aceptas unite a esta estafa piramidal que no solo acaba contigo si no con toda la economia de tu familia, deberias haber buscado un trabajo de verdad ");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Rapidamente sacas tu telefono y llamas a la real gang, en otras palabras a la bola de imbeciles a los que llamas amigos, sin perder el tiempo le explicas la situacion a tus amigos con la esperanza de que te den una solucion. Lamentablemente el mundo tenia otros planes ya que lo unico que te dijeron fue que faltas y vayas con ellos a pasear, no era algo que esperabas pero tereminas aceptando y pasando un buen tiempo, no te preocupes yo tambien hubiera hecho lo mismo");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}

