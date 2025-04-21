using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    public class Distritoss
    {
        public string Name;
        public string Diffilcuty;
        public Distritoss(string name, string diffilcuty)
        {
            this.Name = name;
            this.Diffilcuty = diffilcuty;
        }
        public virtual void MostrarOpciones()
        {
            Console.WriteLine($"Tu vida inicio en {Name}");
            Console.WriteLine(Diffilcuty);
        }
      
    }
}

