using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploVeiculos
{
    public class Veiculo
    {
        private bool _vendido { get; set; }
        private DateTime _dataVendido { get; set; }
        public string Marca { get; }
        public string Nome { get; }
        public TipoVeiculo Tipo { get; }

        public Veiculo()
        { }

        public Veiculo( string  marca, string nome, TipoVeiculo tipo)
        {
            if (string.IsNullOrWhiteSpace(marca))
            {
                throw new ArgumentException("A marca é obrigatória");
            }
            Marca = marca;
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome é obrigatório");
            }
            Nome = nome;

            Tipo = tipo;
        }

        public string ObterVenda()
        {
            if (_vendido == false)
                return "Não foi vendido ainda!";
            else
                return "Vendido em: " + _dataVendido.ToString("yyyy");
        }

        public void Vendido(DateTime dataVendido)
        {
            _vendido = true;
            _dataVendido = dataVendido;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Marca: {Marca}";
        }
    }


}
