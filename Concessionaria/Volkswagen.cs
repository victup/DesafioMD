﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    public class Volkswagen : Carro
    {
        public Volkswagen(Marcas marca) : base(marca)
        {
        }

        public override void Acelerar()
        {
            Console.WriteLine("Sou um carro Volkswagen e estou acelerando.");
        }
    }
}
