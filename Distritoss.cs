using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    public abstract class Distritoss
    {
        public string Name { get; protected set; }
        public string Diffilcuty { get; protected set; }

        public Distritoss(string name, string diffilcuty)
        {
            this.Name = name;
            this.Diffilcuty = diffilcuty;
        }

        public abstract void MostrarOpciones();

        public virtual void MostrarIntroduccion()
        {
            Console.WriteLine($"Tu vida inicio en {Name}");
            Console.WriteLine(Diffilcuty);
        }
    }
}

