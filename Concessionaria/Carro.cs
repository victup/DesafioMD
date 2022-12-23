using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concessionaria
{
    public abstract class Carro
    {
        private Marcas Marca { get; set;}

        public Carro()
        {

        }
        public Carro(Marcas marca)
        {
            Marca = marca;
        }

        public abstract void Acelerar();
      

    }
    
}
