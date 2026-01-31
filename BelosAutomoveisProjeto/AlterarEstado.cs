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

            // Pega apenas os veículos disponíveis
            var veiculosDisponiveis = empresa.ObterVeiculosDisponiveis(DateTime.Today);

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
                selectVeiculos.SelectedIndex = 0;
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

        private void AlterarEstado_Load(object sender, EventArgs e)
        {

        }

        private void criarReservaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
