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
                switch (opcion)
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
        public void Inicio2(int opcion)
        {
            if (distritoActual is SQ)
            {
                SQ SQ = new SQ();
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Pides tu INDRIVER, ya que pa eso nomas te alcansa");
                        Console.WriteLine("Mientras estas de camino a tu uni notas la vida peruana, poco a poco ves a las personas pasar");
                        Console.WriteLine("De pronto vez a la chica mas hermosa que has visto rn tu vida, tu no lo puedes creer de lo linda que esta y no sabes que hacer");
                        Console.WriteLine("Se te para el corazon pero sientes que el destino a preparado este momento para ti toda tu vida te arrepentiras si no haces algo");
                        SQ.MostrarOpciones1();
                        ProcesadorSQ1();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sales de tu casa corriendo para tomar tu micro");
                        Console.WriteLine("mientras esperas notas que hay alguien raro entre las personas");
                        Console.WriteLine("No inetantas prestarle atencion y te subes al micro");
                        SQ.MostrarOpciones2();
                        ProcesadorSQ2();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Inicias tu aventura, estas a 10 cuadras de tu uni, con un tiempo limitado extremo pero tu tienes la fe del caso.");
                        Console.WriteLine("Caminas atravez de tu Perú querido, la calle lena de trabajadores que no son coimeados, carros que hacen el aire lo mas toxico de todos y 1 sol abrazador que ilumina la triste vida que tienes");
                        Console.WriteLine("A pesar de ello aun estas en una carrera contra el tiempo, debes tomar 1 atajo para intentar llegar antes");
                        SQ.MostrarOpciones3();
                        ProcesadorSQ3();
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }
        }
        public void Inicio3(int opcion)
        {
            if (distritoActual is MF)
            {
                MF MF = new MF();
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Te vas a tu jato en la play a disfrutar las olas, donde tu familia suele ir a vacasionar tu vas cada fin de semana");
                        Console.WriteLine("Caminas chill entre la playa, y no sabes que hacer, tus brothers dicen que quieren ir pero tu quieres sacar un plan de imprevisto");
                        Console.WriteLine("sigues hasta que te das cuenta de que hay 1 concierto, 1 yate y 1 Arabe en distintos lugares pero cerca de donde estas");
                        MF.MostrarOpciones1();
                        ProcesadorMF1();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Decides agarrar uno de los coches deportidos de coleccion de tu viejo ");
                        Console.WriteLine("Conduces pisando el acelerador a fondo sin pensar en las consecuencias");
                        Console.WriteLine("Lo unico que quieres es demostrar tu poder adquisitivo presumiendoselo al mundo");
                        MF.MostrarOpciones2();
                        ProcesadorMF2();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Durante el día decides perder el tiempo en actividades recreativas sencillas");
                        Console.WriteLine("Jugar tennis, alimentar a tu tigre de vengala, saltar en paracaidas, lo tipico de 1 lunes");
                        Console.WriteLine("Todo el día va bien hasta que por fin cayo la noche, y tu estas listo para la fiesta");
                        MF.MostrarOpciones3();
                        ProcesadorMF3();
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
            int opcion;
            if (int.TryParse(option, out opcion) && opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        objetosInventario.Add("a");
                        break;
                    case 2:
                        objetosInventario.Add("a");
                        break;
                    case 3:
                        objetosInventario.Add("a");
                        break;
                }

                objetosInventario.MostrarObjetos();

                Inicio2(opcion);
            }
            else
            {
                Console.WriteLine("Opcion no valida");

                Ruta2();
            }
        }

        private void Ruta3()
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
                        objetosInventario.Add("a");
                        break;
                    case 2:
                        objetosInventario.Add("b");
                        break;
                    case 3:
                        objetosInventario.Add("c");
                        break;
                }

                objetosInventario.MostrarObjetos();

                Inicio3(opcion);
            }
            else
            {
                Console.WriteLine("Opcion no valida");

                Ruta3();
            }
        }


        public void ProcesadorSJL1()
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
        public void ProcesadorSQ1()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

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
                    ProcesadorSQ1();
                    break;
            }
        }
        public void ProcesadorSQ2()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

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
                    ProcesadorSQ2();
                    break;
            }
        }
        public void ProcesadorSQ3()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Tras caminar 1 poco decides aumentar la velocidad, al poco tiempo te das cuenta que estas corriendo pero algo era raro, la velocidad que tenias era cada vez mayor, era soprendente poco a poco  veias como los demas a tu alrededor se relentizaban y al poco tiempo llegas a tu uni. La experiencia fue increible lo malo es que tu corazon se detuvo tras alcanzar tu destino, no combinen Monster con retbull y mas si tienes problemas al corazon ");
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
                    ProcesadorSQ3();
                    break;
            }
        }
        public void ProcesadorMF1()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Optas por ir a disffrutar del concierto, pero al intentar ingresar la seguridad te detiene, intentas de diversos medio entrar hasta que recurres a la violencia lo cual ocasiona que seas llevado a una comisaria y que tu familia se decepcione de ti y te deseherede");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Hablas con los dueños para que te permitan unirte, haran una fiesta en medio del mar donde disfrutas todo el día, lamentablemente el yate se pierde en medio de una tormenta y quedas varado en una isla desierta. tras 3 años de supervivencia eres rescatado e inicias una nueva vida ahora mas honrrada");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Tu y el Arabe se hacen amigos y te habla de que vayan a Dubai a su casa para que disfruten del los gozos de por alla, tu aceptas y disfrutas de la experiencia ganando un gran amigo que tendras para desperdiciar mas dinero.");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    ProcesadorMF1();
                    break;
            }
        }
        public void ProcesadorMF2()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Decides manejar hasta que observas a 1 grupo de chicas las cuales quedan fasinadas por tu carrazo, decides pasar un buen tiempo con ellas hasta que unos meses mas tarde terminas siendo padre de 5 niños, los bebes son una vendicion, y al menos tu puedes mantener a 5 de ellos");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Pisas el acelerador hasta que te das cuenta que la adrenalida que sientes es lo que realmente te gusta, te sientes imparable, un velocista total, todo estaba bien hasta que chocas. Una vez mas destruyes un auto de tu padre, con este ya son 6 que van al mes, a este paso bajaran tu mesaja de 100k a 50k");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Teniendo el conocimiento de que tu padre no iba a darte la herencia familiar a ti por el mal hijo que eres, lanzas tu carro por 1 barranco y finges tu muerte, esperas 10 años hasta que tu padre fallece y te presentas para reclamar la herencia. No obstante al parecer tu padre es igual que tu y tambien fingio su muerte esperando que asi te reveles, en fin cosas de gente con plata");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    ProcesadorMF2();
                    break;
            }
        }
        public void ProcesadorMF3()
        {
            Console.WriteLine("Elige una opcion (1-3): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Claramente el auto control no es un concepto que entiendes, ni bien legaste empezaste a pagar cantidades increibles de alcohol a todo aquel que se te acercaba y claro que como peruanos no iban a desaprobechar. Lo bueno es que hiciste muchos amigos y la pasaste mal, lo malo es que tiene una deuda que ocaciono que embargaran 1 de las 5 casa que tienes, tu descontrol no tiene reparo");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Tus amigos te saludan con cariño, hablan de como les a ido y que cosas haranen la noche, todo hasta que llega una chica al grupo. A partir de alle se vuelve una batalla campal de quien puede tener una oportunidad con ella, algo que tu ganaste tras impresionarla con tus dotes monetarios. Fue una victoria aplastante hasta que descubriste que en verdad era un hombre que queria engañarte y robarte la plata, fuiste la burla del grupo y de muchos durante años ");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("No se por que, cosas de ricos supongo pero la discoteca que ibas tenia 1 casino, el juego no era lo tuyo pero quisiste experimentar algo nuevo. Te acercas a un juego y apuestas la humilde cantidad de Medio Millon de soles al rojo, la gente enloquese al ver tal auesta y mas tu que realemnte era casi gran parte de la plata que tenian para otros gastos. Empieza a girar la ruleta y la tension inicia, la gente mira con asombro y desdicha si lo lograras, es solo un 50/50 peor aun asi ariesgaste todo, era muy tarde para retroceder y al final la ruleta se detiene y terminas ganando todo, las mejores apuestas siempre se hacen a lo grande");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    ProcesadorMF3();
                    break;
            }
        }
    }
}




        

        

    

    

