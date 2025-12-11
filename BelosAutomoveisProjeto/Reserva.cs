using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public enum EstadoReserva
    {
        Ativa,
        Concluida,
        Cancelada
    }

    public class Reserva
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal PrecoTotal { get; set; }
        public EstadoReserva Estado { get; set; }

        public Reserva(int id, Veiculo veiculo, DateTime inicio, DateTime fim, decimal preco)
        {
            Id = id;
            Veiculo = veiculo;
            DataInicio = inicio;
            DataFim = fim;
            PrecoTotal = preco;
            Estado = EstadoReserva.Ativa;
        }

        public override string ToString()
        {
            return $"Reserva {Id} | {Veiculo.Matricula} | {DataInicio:dd/MM/yyyy} - {DataFim:dd/MM/yyyy} | {PrecoTotal}€";
        }
    }
}