using System;

namespace ExemploVeiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("UNO", "ABC1234", 4, "FIAT");
            Console.WriteLine(carro);
            carro.DefinirPreco(50000.00);

            string disponibilidade = carro.ObterVenda();
            Console.WriteLine(disponibilidade);

            DateTime dataVenda = DateTime.Now;
            carro.Vendido(dataVenda);
            disponibilidade = carro.ObterVenda();

            Console.WriteLine(carro);
            Console.WriteLine(disponibilidade);
            Console.WriteLine("R$ " + carro.Preco);
            
        }
    }
}
