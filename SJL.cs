using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class SJL : Distritoss, IOpciones
    {
        public SJL() : base("Habla bien, ahora vives en el Gran San Juan de Lurigancho, suerte sobreviviendo bateriaaa", "Dificultad: Alarako")
        {
        }

        public override void MostrarOpciones()
        {
            Console.WriteLine("Como cualquier buen lunes amaneces todo rezaqueado, la cantidad de alcohol en tu sangre es preocupante pero ya estas acostumbrado a esta vida de Bellakeo.Te pones tus mejores trapos para salir de tu choza pero necesitas llevartelo contigo,¿Que eliges?");
            Console.WriteLine("1.Celular");
            Console.WriteLine("2.Pistola");
            Console.WriteLine("3.Billetera");
        }

        public void MostrarOpciones1()
        {
            Console.WriteLine("Vuelves al lugar donde la delincuencia se reunia con frecuencia, donde el pecado estaba presente, regresaste al tono que fuiste la anterior noche, no obstante debes intentar averiguar a donde se llevaron a tu bandida, ¿Que decides hacer?");
            Console.WriteLine("1.Hablar con el dueño");
            Console.WriteLine("2.Buscar en los alrededores");
            Console.WriteLine("3.Volver a llamarla");
        }

        public void MostrarOpciones2()
        {
            Console.WriteLine("En su camino a la riquesas del bajo mundo, Bryan te pregunta que trabajo deberian hacer, a lo que debes decir tu siguiente victima");
            Console.WriteLine("1.Asaltar de 1 local");
            Console.WriteLine("2.Asaltar 1 transeunte");
            Console.WriteLine("3.Tomar el congreso uwu");
        }

        public void MostrarOpciones3()
        {
            Console.WriteLine("Dudas por 1 momento pero piensas que deberias hacer ante la magnitud de dicha explocion");
            Console.WriteLine("1.Acercarte al lugar de la explosion");
            Console.WriteLine("2.Cometer bandalismo");
            Console.WriteLine("3.Irte");
        }

        public void ProcesarOpcion1(string opcion)
        {
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Le exiges al dueño que te de respuestas, impones tu presencia diciendo que eres el terror de las mototaxis, algo que no termina por gustar al hombre que arrebata contrati pues no sabias que el era dueño de una mafia GG moriste bandido");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Entras por los callejones de los alrededores, alli encuentras a la tifani, la mejor amiga de tu novia. Al encararla con angustia sobre que paso ella se enoja pues nunca le caiste bien y empieza a gritar que le intestaste hacer algo, en fin hay gente loca en estu mundo, te vas corriendo y nunca encuentras pista alguna de tu novia GGs");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Tras llamarla denuevo te contesta 1 hombre diciendote donde la tenian, sin pensarlo 2 veces tomas rumbo hacia el lugar pero cuando llegas te das cuenta de que es tu propia casa?. Al parecer se samparon tremenda bomba los 2 par de vagos de ti y tu novia que terminaron siendo llevados por su grupo de amigos, prometes que no volveras a tomar tu trago de 8 soles nunca mas pero todos sabemos que es mentira, disfruta tu vida alaraka causha");
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
                    Console.WriteLine("Deciden ir por una peluqueria que se encuentran, esperan el momento adecuado y entran exiguiendo las pertenencias de las personas. No obstante te das cuenta que la clienta que habia alli no era nadie mas que tu viejita, te asustas con solo verla pero ya es demasiado tarde, ella te termina dando la golpisa de tu vida por tu mal vivir y te acordaras para toda la vida de sus palabras yo no te crie para que seas 1 choro pa eso vuelvete congresista");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Bryan y tu agaran a 1 persona que caminaba en un lugar peligroso al cual empiezan a amenazar, todo hiba bien hasta que Bryan lo reconoce como el lider del grupo criminal mas grande de San Juan de Lurigancho y antes que puedas reaccionar Bryan ya se habia ido corriendo mientras que tu te viste rodeado por los miembros de este grupo. Tu cuerpo nunca se encontró pero Bryan sobrevivio para consolar a tu flaca, que bandido a la firme");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Tras años de delincuencia y una vida terrible decides detener este sistema desfuncional, reunes a todos los pandilleros, bellacos, choros, de tu distiro y en 1 noche tomar el congreso. Tras años de peleas e intentar manejar a 1 país tomado a la fuerza por fin logras crear una utopia donde nadie tiene que subrir, donde los niños pueden salir a las calles a jugar, ahora ser choro se volvio deporte nacional y se implemento en las olimpiadas todo gracias a tu esfuerzo, Good ending");
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
                    Console.WriteLine("Con mucha curiosidad por esto corred en direccon a la ecplocion para darte con la sorpresa de que al llegar encuentras que 1 grupo de extorcionadores intentaron imponerse en tu zona, algo que claramente los de la zona no quisieron armandose una balacera.Si tan solo hubieras tenido tu pistola hubieras logrado defenderte pero todo lo que quedo fue tu billetera");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Ante esta situacion de peligro, no piensas otra cosa que destrozar cosas e intentar robar algo. Lo consigues pero lamentablemente tu falta de criterio evito que te dieras cuenta que se te habia caido la billetera en pleno urto de objetos, algo que usaron para localizarte y detenerte.No deberias aprovecharte de los demas");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Independientemente de la ocasion decides dar la vista gorda, te alejas poco a poco hasta que ya no estas entre gente sumida en pánico, de pronto ves 1 puesto de carretillas y asi cumples tu cometido de comer, pagar e irte feliz a tu casa, otro día mas en tu Distrito tan querido San Juan de Lurigancho");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
