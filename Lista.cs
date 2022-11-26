using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    internal class Lista
    {
        private Nodo first, end;


        public Lista()
        {
            first = null;
            end = null;
        }

        public void AgregarOrdenado()
        {
            //agregar alfabeticamente correcto 
            
        }

        public void AgregarFinal(string valor)

        {
            Nodo nuevo = new(valor);
            if (first == null) first = end = nuevo;

            else
                end.siguiente = nuevo;
            nuevo.anterior = end;
            nuevo.siguiente = null;
            end = nuevo;


        }

        public void AgregarInicio(string valor)
        {
            Nodo nuevo = new(valor);
            if (first == null) first = end = nuevo;
            else
                nuevo.siguiente = first;
            first.anterior = nuevo;
            nuevo.anterior = null;
            first = nuevo;
        }
        public void MostrarAscendente()
        {
            
            Nodo actual = first;
            while (actual != null)
            {
                Console.WriteLine(actual.valor);
                actual = actual.siguiente;
            }
            
        }
        public void MostrarDescendente()
        {
            
            {
                Nodo actual = end;
                while (actual != null)
                {
                    Console.WriteLine(actual.valor);
                    actual = actual.anterior;
                }
            }
            
        }

        public void Buscar(string valor)
        {
            
            Nodo actual = first;
            while (actual != null)
            {
                if (actual.valor == valor)
                {
                    Console.WriteLine("El valor " + valor + " se encuentra en la lista");
                    return;
                }
                actual = actual.siguiente;
            }
            Console.WriteLine("El valor " +  valor + " no se encuentra en la lista");
            

        }

        public void VaciarLista()
        {

            Nodo Actual = first;
            while (Actual != null)
            {
                
                Actual = Actual.siguiente;
                Actual.anterior = null;
                first = Actual;
            
            }
        }

        public void Eliminar(String valor)
        {
            Nodo actual = first;
            while(actual.siguiente != null && actual.valor != valor)
            {
                actual = actual.siguiente;
            }
            if(actual.valor == valor)
            {
                if (actual == first && actual == end) 
                {
                    first = end = null;
                    return;
                } 

                if (actual == first)
                {
                    first = actual.siguiente;
                    first.anterior = null;
                    return;
                }

                if (actual == end)
                {
                    end = actual.anterior;
                    end.siguiente = null;
                    return;
                }
                Nodo anterior = actual.anterior, siguiente = actual.siguiente;

                anterior.siguiente = siguiente;

                siguiente.anterior = anterior;

                valor = null;
            }
        }
    }
}
