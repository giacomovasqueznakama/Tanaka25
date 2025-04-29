using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanaka25
{
    internal interface IOpciones
    {
        void MostrarOpciones1();
        void MostrarOpciones2();
        void MostrarOpciones3();
        void ProcesarOpcion1(string opcion);
        void ProcesarOpcion2(string opcion);
        void ProcesarOpcion3(string opcion);
    }
}
