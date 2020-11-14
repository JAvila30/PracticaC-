using System;
using PracticasCchar.Models;
namespace PracticasCchar
{
    class Program
    {
        static void Main(string[] args)

        {
            bebida bebida = new bebida("Coca cola",1000);
            bebida.Beberse(500);
            Console.WriteLine(bebida.Cantidad);

        }
    }
}
