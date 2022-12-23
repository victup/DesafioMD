using Concessionaria;

class Program
{

    static void Main(string[] args)
    {
        //Para testar outro caso basta alterar o parâmetro. Para Marcas.Ford, por exemplo.

        Ligar(Marcas.Volkswagen);
    }

    private static void Ligar(Marcas marca)
    {
        Carro carro;

        if(marca == Marcas.Volkswagen)
        {
           carro = new Volkswagen(marca);
        }
        else
        {
           carro = new Ford(marca);
        }

        carro.Acelerar();

    }
}