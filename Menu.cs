using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class Menu
    {
        private List<objetos> persons;



        public void Execute()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("1.iniciar juego");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
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
        private void startGame()
        {
            Console.WriteLine("Bienvenido al mejor juego de todos, inicias en tu cuarto y tienes que salir, que objeto escoges?");
            Console.WriteLine("1.celular");
            Console.WriteLine("2.cigarros");
            Console.WriteLine("3.gato");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Ruta1();
                    break;
                case "2":
                    Ruta2();
                    break;
                case "3":
                    Ruta3();
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }
        private void Ruta1()
        {
            Console.WriteLine("Intentas socializar con alguien de tus contactos para darte cuenta que realmente no tienes amigos y estaras solo para toda tu vida");
        }
        private void Ruta2()
        {
            Console.WriteLine("Saliendo valientemente de tu casa decides que es una buena idea fumar 1 poco, despues de 10 años de constante inalacion de toxicos terminas muriendo abruptamente de los pulmones");
        }
        private void Ruta3()
        {
            Console.WriteLine("Lo usas para ganar miles de dolares en las redes explotandolo y haciendolo famoso");
        }
    }
}

        

        

    

    

