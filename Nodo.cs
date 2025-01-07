using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_01
{
    public class Nodo
    {
        private int numero;  //dato
        private Nodo siguiente;  //punto de referencia
        //con control + punto podemos encapsular 

        public int Numero { get => numero; set => numero = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
