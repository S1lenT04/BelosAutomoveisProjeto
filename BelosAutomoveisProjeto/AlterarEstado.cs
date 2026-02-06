using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public partial class AlterarEstado : Form
    {
        private Empresa empresa;
        public AlterarEstado(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            PreencherVeiculosDisponiveis();
        }

        // Preenche o ComboBox com os veículos disponíveis
        private void PreencherVeiculosDisponiveis()
        {
            selectVeiculos.Items.Clear();

            var todosVeiculos = empresa.ObterTodosVeiculos();

            foreach (var v in todosVeiculos)
            {
                string texto = $"{v.Matricula} - {v.Marca} {v.Modelo} ({v.GetType().Name})";

                // Guarda o veículo no Tag do item
                selectVeiculos.Items.Add(new ComboBoxItem(texto, v));
            }

            // Configura para mostrar o texto
            selectVeiculos.DisplayMember = "Text";

            // Se houver veículos, seleciona o primeiro
            if (selectVeiculos.Items.Count > 0)
                selectVeiculos.SelectedIndex = 0;
        }

        // Classe auxiliar para guardar texto e veículos na ComboBox
        private class ComboBoxItem
        {
            public string Text { get; set; }
            public Veiculo Veiculo { get; set; }

            public ComboBoxItem(string text, Veiculo veiculo)
            {
                Text = text;
                Veiculo = veiculo;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarEstado_Load(object sender, EventArgs e)
        {

        }

        private void criarReservaBtn_Click(object sender, EventArgs e)
        {
            if (selectVeiculos.SelectedItem is not ComboBoxItem item)
            {
                MessageBox.Show("Selecione um veículo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (estadoCombo.SelectedItem == null)
            {
                MessageBox.Show("Selecione o novo estado.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var veiculo = item.Veiculo;
            string estadoTexto = estadoCombo.SelectedItem.ToString() ?? "";

            // Mapeia o texto do ComboBox para o enum EstadoVeiculo
            EstadoVeiculo novoEstado;
            switch (estadoTexto)
            {
                case "Disponível":
                    novoEstado = EstadoVeiculo.Disponivel;
                    break;
                case "Reservado":
                    novoEstado = EstadoVeiculo.Reservado;
                    break;
                case "Manutenção":
                    novoEstado = EstadoVeiculo.EmManutencao;
                    break;
                case "Alugado":
                    novoEstado = EstadoVeiculo.Alugado;
                    break;
                default:
                    MessageBox.Show("Estado selecionado inválido.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            try
            {
                if (novoEstado == EstadoVeiculo.Disponivel)
                {
                    // Se existir um aluguer ativo para este veículo, termina-o usando o sistema de reservas
                    var reservaAtiva = empresa.Reservas
                        .FirstOrDefault(r => r.Veiculo == veiculo && r.Estado == EstadoReserva.Ativa);

                    if (reservaAtiva != null && veiculo.Estado == EstadoVeiculo.Alugado)
                    {
                        empresa.TerminarAluguer(reservaAtiva);
                    }
                    else
                    {
                        veiculo.Estado = EstadoVeiculo.Disponivel;
                        veiculo.DataDisponivel = null;
                    }
                }
                else if (novoEstado == EstadoVeiculo.Alugado)
                {
                    // Procura uma reserva ativa para este veículo e inicia o aluguer
                    var reservaAtiva = empresa.Reservas
                        .FirstOrDefault(r => r.Veiculo == veiculo && r.Estado == EstadoReserva.Ativa);

                    if (reservaAtiva == null)
                    {
                        MessageBox.Show("Não existe nenhuma reserva ativa para este veículo.",
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    empresa.IniciarAluguer(reservaAtiva);
                }
                else if (novoEstado == EstadoVeiculo.EmManutencao)
                {
                    // Envia o veículo para manutenção com uma data prevista simples:
                    // aqui assumimos, para simplificar, que a manutenção dura 7 dias.
                    DateTime dataDisponivel = DateTime.Today.AddDays(7);
                    empresa.EnviarParaManutencao(veiculo, dataDisponivel);
                }
                else if (novoEstado == EstadoVeiculo.Reservado)
                {
                    // Para reservar deve ser usado o ecrã de reservas.
                    MessageBox.Show("Para reservar um veículo utilize o ecrã de reservas.",
                        "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Estado alterado com sucesso.", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar estado: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
