using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    internal class Nodo
    {
        public string valor;
        public Nodo siguiente;
        public Nodo anterior;

        public Nodo(string valor)
        {
            this.valor = valor;
            siguiente = null;
            anterior = null;
        }
    }
}
