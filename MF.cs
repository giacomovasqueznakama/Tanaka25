using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class MF: Distritoss, IOpciones
    {
        public MF() : base("Por fin hasta que decidiste vivir la vida que nunca tendras y sentir el no tener sueldo mínimo, disfruta tu vida en Miraflores Brother", "Dificultad: Facilongo pero igual te puedes morir causha")
    {
    }

    public override void MostrarOpciones()
    {
        Console.WriteLine("Brother hoy amaneces en tu cama Europea siendo despertado por una de las empleadas que tienes, tu vida es buena pero con responsabilidades que prefieres ignorar ya que hoy debes malgastar la plata de tus viejos, que tendrias que realizar Alucina?");
        Console.WriteLine("1.Ir a la playa");
        Console.WriteLine("2.Salir en tu coche");
        Console.WriteLine("3.Esperar a la noche");
    }

    public void MostrarOpciones1()
    {
        Console.WriteLine("Que deberias hacer");
        Console.WriteLine("1.Ir al concierto");
        Console.WriteLine("2.Ir al yate");
        Console.WriteLine("3.Ir con el Arabe");
    }

    public void MostrarOpciones2()
    {
        Console.WriteLine("Mientras sigues manejando piensas en algo que podrias hacer para matar el tiempo, que quisieras hacer?");
        Console.WriteLine("1.Ir a buscar chicas");
        Console.WriteLine("2.Manejar mas rapido");
        Console.WriteLine("3.Fingir tu muerte");
    }

    public void MostrarOpciones3()
    {
        Console.WriteLine("Emprendes camino a la discoteca que te gusta, agarras tu targeta de cretido para lo que se viene y entras al local, que debes hacer ahora?");
        Console.WriteLine("1.Descontrol");
        Console.WriteLine("2.Amigos");
        Console.WriteLine("3.TODO AL ROJO");
    }

    public void ProcesarOpcion1(string opcion)
    {
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
                Console.WriteLine("Tu y el Arabe se hacen amigos y te habla de que vayan a Dubai a su casa para que disfruten del los gozos de por alla, tu aceptas y disfrutas de la experiencia ganando un gran amigo que tendras para desperdiciar mas dinero");
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
                break;
        }
    }

    public void ProcesarOpcion3(string opcion)
    {
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
                break;
        }
    }
}
}
