using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI_Task_Tracker
{
    internal class Objeto
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }

        public Objeto(string Nombre, int Numero)
        {
            this.Nombre = Nombre;
            this.Numero = Numero;
        }
    }
}
