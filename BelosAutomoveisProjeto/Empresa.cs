using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BelosAutomoveisProjeto
{
    public class Empresa
    {
        public string Nome { get; set; }
        public List<Veiculo> Veiculos { get; set; }
        public List<Reserva> Reservas { get; set; }

        private int proximoIdReserva = 1;

        public Empresa(string nome)
        {
            Nome = nome;
            Veiculos = new List<Veiculo>();
            Reservas = new List<Reserva>();
        }

        // verifica se um veículo está disponível entre duas datas
        public bool VeiculoDisponivel(Veiculo veiculo, DateTime inicio, DateTime fim)
        {
            if (veiculo.Estado != EstadoVeiculo.Disponivel)
                return false;

            foreach (Reserva r in Reservas)
            {
                if (r.Veiculo == veiculo && r.Estado == EstadoReserva.Ativa)
                {
                    bool datasSobrepostas =
                        inicio < r.DataFim && fim > r.DataInicio;

                    if (datasSobrepostas)
                        return false;
                }
            }
            return true;
        }

        //cria uma nova reserva se o veículo estiver disponível
        public Reserva CriarReserva(Veiculo veiculo, DateTime inicio, DateTime fim, decimal precoDiario)
        {
            if (!VeiculoDisponivel(veiculo, inicio, fim))
                throw new Exception("Veículo indisponível para o período selecionado.");

            int dias = (int)Math.Ceiling((fim - inicio).TotalDays);
            decimal precoTotal = dias * precoDiario;

            Reserva novaReserva = new Reserva(
                proximoIdReserva++,
                veiculo,
                inicio,
                fim,
                precoTotal
            );

            Reservas.Add(novaReserva);
            veiculo.Estado = EstadoVeiculo.Reservado;
            veiculo.DataDisponivel = inicio;
            return novaReserva;
        }

        //Inicia o aluguer de uma reserva ativa
        public void IniciarAluguer(Reserva reserva)
        {
            if (reserva.Estado != EstadoReserva.Ativa)
                throw new Exception("A reserva não está ativa.");

            reserva.Veiculo.Estado = EstadoVeiculo.Alugado;
            reserva.Veiculo.DataDisponivel = reserva.DataFim;
        }

        //Termina o aluguer de uma reserva ativa
        public void TerminarAluguer(Reserva reserva)
        {
            if (reserva.Estado != EstadoReserva.Ativa)
                throw new Exception("A reserva não está ativa.");

            reserva.Estado = EstadoReserva.Concluida;
            reserva.Veiculo.Estado = EstadoVeiculo.Disponivel;
            reserva.Veiculo.DataDisponivel = null;
        }

        // calcula a faturação total entre duas datas
        public decimal FaturacaoTotal(DateTime inicio, DateTime fim)
        {
            return Reservas
                .Where(r =>
                    r.Estado == EstadoReserva.Concluida &&
                    r.DataInicio >= inicio &&
                    r.DataFim <= fim)
                .Sum(r => r.PrecoTotal);
        }

        public override string ToString()
        {
            return $"Empresa: {Nome}, Total Veículos: {Veiculos.Count}";
        }

        public Carro InserirCarro(string matricula, string marca, string modelo, int ano, decimal precoDiario, EstadoVeiculo estado, DateTime? dataDisponivel, int numeroPortas, TipoCaixa tipoCaixa) 
        {
            if(numeroPortas != 3 && numeroPortas != 5)
                throw new ArgumentException("Carro: número de portas deve ser 3 ou 5.");

            var v = new Carro
            {
                NumeroPortas = numeroPortas,
                TipoCaixa = tipoCaixa,
            };

            PreencherEAdicionar(v, matricula, marca, modelo, ano, precoDiario, estado, dataDisponivel);
            return v;
        }

        public Mota InserirMota(string matricula, string marca, string modelo, int ano, decimal precoDiario, EstadoVeiculo estado, DateTime? dataDisponivel, Cilindrada cilindrada)
        {
            var v = new Mota
            {
                Cilindrada = cilindrada
            };

            PreencherEAdicionar(v, matricula, marca, modelo, ano, precoDiario, estado, dataDisponivel);
            return v;
        }

        public Camioneta InserirCamioneta(string matricula, string marca, string modelo, int ano, decimal precoDiario, EstadoVeiculo estado, DateTime? dataDisponivel, int numeroEixos, int maximoPassageiros)
        {
            if(numeroEixos !=2 && numeroEixos !=3)
                throw new ArgumentException("Camioneta: número de eixos deve ser 2 ou 3.");

            if(maximoPassageiros <=0)
                throw new ArgumentException("Camioneta: máximo de passageiros deve ser maior que zero.");

            var v = new Camioneta
            {
                NumeroEixos = numeroEixos,
                MaximoPassageiros = maximoPassageiros
            };

            PreencherEAdicionar(v, matricula, marca, modelo, ano, precoDiario, estado, dataDisponivel);
            return v;
        }

        public Camiao InserirCamiao(string matricula, string marca, string modelo, int ano, decimal precoDiario, EstadoVeiculo estado, DateTime? dataDisponivel, double pesoMaximoKg)
        {
            if(pesoMaximoKg <=0)
                throw new ArgumentException("Camião: peso máximo(Kg) deve ser maior que zero.");

            var v = new Camiao
            {
                PesoMaximoKg = pesoMaximoKg
            };

            PreencherEAdicionar(v, matricula, marca, modelo, ano, precoDiario, estado, dataDisponivel);
            return v;
        }

        public IReadOnlyList<Veiculo> ObterTodosVeiculos()
        {
            return Veiculos.AsReadOnly();
        }

        public List<Veiculo> ObterVeiculosEmManutencao()
        {
            return Veiculos.Where(v => v.Estado == EstadoVeiculo.EmManutencao).ToList();
        }

        public List<Veiculo> ObterVeiculosDisponiveis(DateTime dataAtual)
        {
            return Veiculos.Where(v => v.Estado == EstadoVeiculo.Disponivel || (v.DataDisponivel != null && v.DataDisponivel.Value.Date <= dataAtual.Date && (v.Estado == EstadoVeiculo.Alugado || v.Estado == EstadoVeiculo.EmManutencao))).ToList();
        }

        private void PreencherEAdicionar(Veiculo v, string matricula, string marca, string modelo, int ano, decimal precoDiario, EstadoVeiculo estado, DateTime? dataDisponivel)
        {
            if(string.IsNullOrWhiteSpace(matricula))
                throw new ArgumentException("Matrícula é obrigatoria.");
            if (string.IsNullOrWhiteSpace(marca))
                throw new ArgumentException("Marca é obrigatoria.");
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("Modelo é obrigatorio.");

            if (ano < 1900 || ano > DateTime.Now.Year + 1)
                throw new ArgumentException("Ano inválido.");

            if(precoDiario <= 0)
                throw new ArgumentException("Preço diário deve ser maior que zero.");

            string mat = matricula.Trim().ToUpper();

            if (Veiculos.Any(x => x.Matricula.Equals(mat, StringComparison.OrdinalIgnoreCase)))
                throw new InvalidOperationException("Já existe um veículo com a mesma matrícula.");

            bool precisaData = (estado == EstadoVeiculo.Alugado || estado == EstadoVeiculo.EmManutencao);
            if (precisaData && dataDisponivel == null)
                throw new ArgumentException("Data disponível é obrigatória para veículos alugados ou em manutenção.");

            if (!precisaData)
                dataDisponivel = null;

            v.Matricula = mat;
            v.Marca = marca.Trim();
            v.Modelo = modelo.Trim();
            v.Ano = ano;
            v.PrecoDiario = precoDiario;
            v.Estado = estado;
            v.DataDisponivel = dataDisponivel;

            Veiculos.Add(v);
        }

    }
}
