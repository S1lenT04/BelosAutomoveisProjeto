using System;

namespace BelosAutomoveisProjeto
{
    internal class TesteBackend
    {
        public static void Executar()
        {
            var empresa = new Empresa("Teste");

            empresa.InserirCarro(
                "11-AA-22", "Toyota", "Yaris", 2020, 35m,
                EstadoVeiculo.Disponivel, null,
                5, TipoCaixa.Manual);

            empresa.InserirMota(
                "33-BB-44", "Honda", "PCX", 2022, 25m,
                EstadoVeiculo.Alugado, DateTime.Today.AddDays(3),
                Cilindrada.Cc125);

            var todos = empresa.ObterTodosVeiculos();
            var disponiveis = empresa.ObterVeiculosDisponiveis(DateTime.Today);
            var manutencao = empresa.ObterVeiculosEmManutencao();

            Console.WriteLine("Total veículos: " + todos.Count);
            Console.WriteLine("Disponíveis hoje: " + disponiveis.Count);
            Console.WriteLine("Em manutenção: " + manutencao.Count);
        }
    }
}

