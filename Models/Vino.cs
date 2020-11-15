using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasCchar.Models
{
    class Vino : bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son 3 copas ");
        }
        public Vino(int Cantidad, string Nombre = "Vino") : base(Nombre, Cantidad)
        {

        }

    }
}
