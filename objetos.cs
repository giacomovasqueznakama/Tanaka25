using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class objetos
    {

            public List<string> ObjetosInventario;


        public objetos()
        {
            this.ObjetosInventario = new List<string>();
        }

        public void MostrarObjetos()
            {           

                Console.WriteLine("Tus Cachibaches");

                if (ObjetosInventario.Count == 0)
                {
                    Console.WriteLine("No tienes nada");
                }
                else
                {
                    foreach (string objetos in ObjetosInventario)
                    {
                        Console.WriteLine($" - {objetos}");
                    }
                }
                Console.WriteLine();
            }
        }
    }


