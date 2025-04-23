using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal class SJL : Distritoss
    {
        public SJL() : base("Habla bien, ahora vives en el Gran San Juan de Lurigancho, suerte sobreviviendo bateriaaa", "Dificultad: Alarako")
        {
        }

        public override void MostrarOpciones()
        {
            Console.WriteLine("Como cualquier buen lunes amaneces todo rezaqueado, la cantidad de alcohol en tu sangre es preocupante pero ya estas acostumbrado a esta vida de Bellakeo.Te pones tus  mejores trapos para salir de tu choza pero necesitas llevartelo contigo,¿Que eliges?");
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
            Console.WriteLine("1.Asaltar 1 local");
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

    }
}
