using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class Menu
    {
        private objetos objetosInventario;
        private Dictionary<string, Distritoss> distritos;
        private Distritoss distritoActual;
        private bool menuInicio;
        public Menu()
        {
            objetosInventario = new objetos();
            distritos = new Dictionary<string, Distritoss>
            {
                {"San Juan de Lurigancho", new SJL()},
                {"Surquillo", new SQ()},
                {"Miraflores", new MF()},
            };

            menuInicio = true;
        }
        public void Execute()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                if (menuInicio)
                {
                    Console.WriteLine("Hola causa, se bienvenido a la top global aventura Peruana alaraka causa.");
                    Console.WriteLine(" En esta aventura tu podrá experimentar la top experiencia peruana con distintos finales dependiendo el distrito que eligas.");
                    Console.WriteLine(" Osea puedes ser un pitucazo o un bandido la decisión es tuya Gaaaaa.");
                    Console.WriteLine("1.Inicia ps delincuente");
                    Console.WriteLine("0. No das la talla para este juego");

                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            menuInicio = false;
                            startGame();
                            break;
                        case "0":
                            continueFlag = false;
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;

                    }
                }
              
            }
        }
        private void startGame()
        {
            Console.WriteLine("Donde quieres iniciar causha");
            Console.WriteLine("1.San Juan de Lurigancho");
            Console.WriteLine("2.Surquillo");
            Console.WriteLine("3.Miraflores");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    distritoActual = distritos["San Juan de Lurigancho"];
                    Ruta1();
                    break;
                case "2":
                    distritoActual = distritos["Surquillo"];
                    Ruta2();
                    break;
                case "3":
                    distritoActual = distritos["Miraflores"];
                    Ruta3();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
            public void Inicio(int opcion)
        {
            if (distritoActual is SJL)
            {
                SJL sJL = new SJL();
                switch(opcion)
                {
                    case 1:
                        Console.Clear();                      
                        Console.WriteLine("Caminas por las calles debastadas por la delincuencia y el bandalismo, cuando te encuentras con tu amigo Brayan, el cual te propone ir a conseguir de forma gratis algo de desayunar");
                        Console.WriteLine("Lo piensas por unos momentos pero te ves interrumpido por una llamada, es tu flaquita la kimverly, a pesar de que la bandida esa estuvo contigo en la borrachera de anoche se fue con unos patas que conocio ese mismo día");
                        Console.WriteLine("Al contestar escuchas de que tu flaca te pide ayuda pues no sabe donde se encuentra y te dispones a encontrarla, corres a tu casa  agarras tu mototaxi y te dispones a ir a buscarla ");
                        Console.WriteLine("Tu puedes cholo, anda recupera a tu bandida antes que sea demaciado tarde");
                        sJL.MostrarOpciones1();
                        ProcesadorSJL1(); 
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Uno nunca sabe que puede pasar en las calles donde 9 de cada 10 son asesinados principalmente por ti que estas desquisiado. Agarras tu arma y te la guardas en el pantalon como choro y sales de tu casa");
                        Console.WriteLine("Mientras avanzas entre la delincuencia encuentras a tu bateria el Bryan que te propone el buscar cosas de forma gratis");
                        Console.WriteLine("Como ya tienes tu aparato de trabajo no te la piensas mucho mas en acompañarlo a su trabajo honrado y lleno de sangre");
                        sJL.MostrarOpciones2();
                        ProcesadorSJL2();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tomas tu billetera y emprendes 1 viaje a comprar algo para comer");
                        Console.WriteLine("Siendo las 4 de la tarde decides intentar buscar 1 chifa para tu desayuño tardio");
                        Console.WriteLine("No opstante sin motivo alguno a unos cuadras de donde estabas ocurre una EXPLOCION GIGANTEEEEE!!!!!!!");
                        sJL.MostrarOpciones3();
                        ProcesadorSJL3();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;                     
                }
            }
        }
        private void Ruta1()
        {
            Console.WriteLine(distritoActual.Name);
            Console.WriteLine(distritoActual.Diffilcuty);
            distritoActual.MostrarOpciones();

            Console.WriteLine("Elige una opcion (1-3): ");
            string option = Console.ReadLine();

            int opcion;
            if (int.TryParse(option, out opcion) && opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        objetosInventario.Add("Celular");
                        break;
                    case 2:
                        objetosInventario.Add("Pistola");
                        break;
                    case 3:
                        objetosInventario.Add("Billetera");
                        break;
                }

                objetosInventario.MostrarObjetos();

                Inicio(opcion);
            }
            else
            {
                Console.WriteLine("Opcion no valida");

                Ruta1();
            }
        }
        private void Ruta2()
        {
            Console.WriteLine(distritoActual.Name);
            Console.WriteLine(distritoActual.Diffilcuty);
            distritoActual.MostrarOpciones();

            Console.WriteLine("Elige una opcion (1-3): ");
            string option = Console.ReadLine();

        }
        private void Ruta3()
        {
            Console.WriteLine(distritoActual.Name);
            Console.WriteLine(distritoActual.Diffilcuty);
            distritoActual.MostrarOpciones();

            Console.WriteLine("Elige una opcion (1-3): ");
            string option = Console.ReadLine();
        }

        public void ProcesadorSJL1 ()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

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
                    ProcesadorSJL1();
                    break;
            }
        }
        public void ProcesadorSJL2()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

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
                    ProcesadorSJL2();
                    break;
            }
        }
        public void ProcesadorSJL3()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

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
                    ProcesadorSJL3();
                    break;
            }
        }
    }
}

        

        

    

    

