using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ListasEnlazadas
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             
            Lista list = new();
            Console.WriteLine("Escoge  una opcion");
            Console.WriteLine("1) ");

            list.AgregarOrdenado("Estas");
            list.AgregarOrdenado("Hola");
            list.AgregarOrdenado("Como");
            list.AgregarOrdenado("Perro");
            list.AgregarOrdenado("Adiu");
            
            list.MostrarAscendente();
            list.Buscar("Perro");
            list.Eliminar("Perro");
            list.MostrarAscendente();
            list.Buscar("Perro");
            
        }
        
    }
}