using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Triangulo.Domain
{
    public class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo()
        {

        }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public string TriangleType()
        {

            if (!(lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1))
            {
                return "Não é um triângulo";
            }
            else
            {
                if(lado1==0 || lado2 == 0 || lado3 == 0)
                {
                    return "Necessário preencher todos os campos";
                }

                if (lado1 == lado2 && lado2 == lado3)
                {
                    return "É um triângulo equilátero";
                }
                if ((lado1 == lado2 || lado1 == lado3 || lado2 == lado3))
                {
                    return "É um triângulo Isósceles";
                }
                else return "É um triângulo Escaleno";
            }

        }

    }
}
