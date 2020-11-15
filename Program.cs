using System;
using System.Collections.Generic;
using PracticasCchar.Models;
using System.Runtime.ConstrainedExecution;
namespace PracticasCchar
{
    class Program
    {
        static void Main(string[] args)

        {
            //Clases
            bebida bebida = new bebida("Coca cola",1000);
            bebida.Beberse(500);
            Console.WriteLine("Ustede bebió " + bebida.Cantidad + " de bebida");

            //Herencia
            Cerveza cerveza = new Cerveza(700);
            cerveza.Beberse(10);
            Console.WriteLine("Ustede bebió " + cerveza.Cantidad + " de cerveza");

            //Arreglos
            int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

            int numerop = numeros[0];

            //Recorrer un arreglo con for
            for (int i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("Recorrido FOR... Iteración: "+i+" número: "+numeros[i]);
            }

            //Recorrido con FOREACH
            foreach (var numero in numeros)
            {
                Console.WriteLine("Recorrido FOREACH... Iteración: " + numero);
            }

            Console.WriteLine("--------------------------------------------------------");
            
            //Listas
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};

            //Añadir en lista
            lista.Add(9);
            lista.Add(10);

            //Eliminar en lista
            lista.Remove(2);

            foreach (var numero in lista)
            {
                Console.WriteLine("Elemento reccorid de una lista: " + numero);
            }

            Console.WriteLine("*********************************************************");

            //Lista creada utlizando parametros de clase
            List<Cerveza> cervezas = new List<Cerveza>() {  new Cerveza(10,"Cerveza premiun") };
            
            //Agregado
            cervezas.Add(new Cerveza(500));

            //Crear objeto para entrar en lista
            Cerveza erdinger = new Cerveza(500, "Cerveza de trigo");
            //Se añade a la lista
            cervezas.Add(erdinger);

            //Recorrido de la lista de la clase
            foreach (var cerverza in cervezas)
             {
                Console.WriteLine("Cerveza: " + cerverza.Nombre);
            }

            Console.WriteLine("***************************************************");
            //Interfaces
            var bebidaAlcoholica = new Vino(100);
            MostrarRecomendaciones(bebidaAlcoholica);


        }

        static void MostrarRecomendaciones(IBebidaAlcoholica bebida)
        {
            bebida.MaxRecomendado();

        }
    }
}
