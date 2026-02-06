using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public abstract class Veiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal PrecoDiario { get; set; }
        public EstadoVeiculo Estado { get; set; }
        public DateTime? DataDisponivel { get; set; }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}, {Marca} {Modelo} ({Ano}), Preço/Dia: {PrecoDiario}€, Estado: {Estado}";
        }
    }
}
