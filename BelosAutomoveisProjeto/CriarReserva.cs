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
    public partial class CriarReserva : Form
    {
        private Empresa empresa;
        private buscarData dataSimulada = new buscarData();

        public CriarReserva(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;
            precoFinalLabel.Text = "0,00€";
            PreencherVeiculosDisponiveis();
        }

        // Preenche o ComboBox com os veículos disponíveis
        private void PreencherVeiculosDisponiveis()
        {
            selectVeiculos.Items.Clear();

            // Pega apenas os veículos disponíveis tendo em conta a data simulada
            DateTime dataAtual = dataSimulada.GetData();
            var veiculosDisponiveis = empresa.ObterVeiculosDisponiveis(dataAtual);

            foreach (var v in veiculosDisponiveis)
            {
                // Mostra: Matrícula - Marca Modelo (Tipo de veículo)
                string texto = $"{v.Matricula} - {v.Marca} {v.Modelo} ({v.GetType().Name})";

                // Guarda o veículo no Tag do item
                selectVeiculos.Items.Add(new ComboBoxItem(texto, v));
            }

            // Configura para mostrar o texto
            selectVeiculos.DisplayMember = "Text";

            // Se houver veículos, seleciona o primeiro
            if (selectVeiculos.Items.Count > 0)
            {
                selectVeiculos.SelectedIndex = 0;
                AtualizarPreco();
            }
            else
            {
                precoFinalLabel.Text = "0,00€";
            }
        }

        // Método auxiliar para obter o veículo selecionado
        public Veiculo? ObterVeiculoSelecionado()
        {
            if (selectVeiculos.SelectedItem is ComboBoxItem item)
                return item.Veiculo;
            return null;
        }

        // Classe auxiliar para guardar texto e veículo no ComboBox
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

        /// <summary>Atualiza a label do preço consoante o veículo e as datas. O preço é sempre dias × preço diário (da reserva a criar).</summary>
        private void AtualizarPreco()
        {
            if (ObterVeiculoSelecionado() is not Veiculo veiculo)
            {
                precoFinalLabel.Text = "0,00€";
                return;
            }

            DateTime inicio = dateTimePicker1.Value.Date;
            DateTime fim = dateTimePicker2.Value.Date;

            if (fim <= inicio)
            {
                precoFinalLabel.Text = "0,00€";
                return;
            }

            int dias = Math.Max(1, (int)Math.Ceiling((fim - inicio).TotalDays));
            decimal precoTotal = dias * veiculo.PrecoDiario;
            precoFinalLabel.Text = $"{precoTotal:0.00}€";
        }

        private void calcPrecoBtn_Click(object sender, EventArgs e)
        {
            if (ObterVeiculoSelecionado() is null)
            {
                MessageBox.Show("Selecione um veículo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateTimePicker2.Value.Date <= dateTimePicker1.Value.Date)
            {
                MessageBox.Show("A data de fim tem de ser posterior à data de início.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AtualizarPreco();
        }

        private void criarReservaBtn_Click(object sender, EventArgs e)
        {
            if (ObterVeiculoSelecionado() is not Veiculo veiculo)
            {
                MessageBox.Show("Selecione um veículo.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime inicio = dateTimePicker1.Value.Date;
            DateTime fim = dateTimePicker2.Value.Date;

            if (fim <= inicio)
            {
                MessageBox.Show("A data de fim tem de ser posterior à data de início.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Cria a reserva usando o método da Empresa
                Reserva reserva = empresa.CriarReserva(veiculo, inicio, fim, veiculo.PrecoDiario);

                MessageBox.Show(
                    $"Reserva criada com sucesso!\n\n" +
                    $"Veículo: {veiculo.Matricula}\n" +
                    $"Início: {inicio:dd/MM/yyyy}\n" +
                    $"Fim: {fim:dd/MM/yyyy}\n" +
                    $"Preço total: {reserva.PrecoTotal:0.00}€",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar reserva: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
