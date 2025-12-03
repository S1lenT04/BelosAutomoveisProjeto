using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public class Empresa
    {
        public string Nome { get; set; }
        public List<Veiculo> Veiculos { get; set; }

        public Empresa(string nome)
        {
            Nome = nome;
            Veiculos = new List<Veiculo>();
        }

        public override string ToString()
        {
            return $"Empresa: {Nome}, Total Veículos: {Veiculos.Count}";
        }
    }
}
