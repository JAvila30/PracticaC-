﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticasCchar.Models
{
    class Cerveza : bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son 10");
        }
        public Cerveza(int Cantidad, string Nombre = "Cerveza") : base(Nombre, Cantidad)
        {

        }

    }
}
