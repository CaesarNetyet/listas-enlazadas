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


            list.AgregarInicio("Hola");
            list.AgregarFinal("Perro");
            list.AgregarFinal("Como");
            list.AgregarFinal("Estas");
            list.AgregarFinal("Adiu");
            
            list.MostrarAscendente();
            list.Eliminar("Perro");
            list.MostrarAscendente();
            list.Buscar("Perro");


        }
        
    }
}