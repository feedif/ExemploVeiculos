using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVeiculos
{
    public class Carro : Veiculo
    {
        public int Lugares { get; }
        public string Placa { get; }
        public double Preco { get; private set; }

       public Carro(string nome, int lugares, string marca) : this(nome, string.Empty, lugares, marca)
        { }
        public Carro(string nome, string placa, int lugares, string marca) : base(nome, marca, TipoVeiculo.Carro)
        {
            if (placa.Length != 7)
                throw new ArgumentException("A placa deve conter 7 caracteres.");
            Placa = placa;
            Lugares = lugares;
        }

        public double DefinirPreco(double preco)
        {
            if (preco < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(preco), "O preço não pode ser negativo");
            }
            return Preco = preco;
        }
    }
}
