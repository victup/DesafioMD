﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    public class Ford : Carro
    {
        public Ford(Marcas marca) : base(marca)
        {
        }

        public override void Acelerar()
        {
            Console.WriteLine("Sou um carro Ford e estou acelerando.");
        }
    }
}
