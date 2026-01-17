using System;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public partial class AdicionarCamionetaForm : Form
    {
        private Empresa? _empresa;

        // Designer
        public AdicionarCamionetaForm()
        {
            InitializeComponent();
            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }

        // App
        public AdicionarCamionetaForm(Empresa empresa)
        {
            InitializeComponent();
            _empresa = empresa;

            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }

        private void AdicionarCamionetaForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object? sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(matriculatxt.Text) ||
                    string.IsNullOrWhiteSpace(marcatxt.Text) ||
                    string.IsNullOrWhiteSpace(modelotxt.Text) ||
                    string.IsNullOrWhiteSpace(anotxt.Text) ||
                    string.IsNullOrWhiteSpace(precotxt.Text) ||
                    string.IsNullOrWhiteSpace(pesoMaxtxt.Text))
                {
                    MessageBox.Show("Preenche todos os campos.");
                    return;
                }

                if (!int.TryParse(anotxt.Text, out int ano))
                {
                    MessageBox.Show("Ano inválido.");
                    return;
                }

                if (!decimal.TryParse(precotxt.Text, out decimal preco))
                {
                    MessageBox.Show("Preço diário inválido.");
                    return;
                }

                // peso máximo (kg)
                if (!double.TryParse(pesoMaxtxt.Text, out double pesoKg) || pesoKg <= 0)
                {
                    MessageBox.Show("Peso máximo inválido (tem de ser > 0).");
                    return;
                }

                // chamamos o BACKEND do CAMIÃO
                _empresa.InserirCamiao(
                    matriculatxt.Text,
                    marcatxt.Text,
                    modelotxt.Text,
                    ano,
                    preco,
                    EstadoVeiculo.Disponivel,
                    null,
                    pesoKg
                );

                MessageBox.Show("Camião inserido com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarBtn_Click(object? sender, EventArgs e)
        {
            Close();
        }

        // existe no Designer (button2.Click += button2_Click;)
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

