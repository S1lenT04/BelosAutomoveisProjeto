using System;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public partial class AdicionarCamiaoForm : Form
    {
        private Empresa? _empresa;

        // Para o Designer
        public AdicionarCamiaoForm()
        {
            InitializeComponent();
            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }

        // Para a aplicação 
        public AdicionarCamiaoForm(Empresa empresa)
        {
            InitializeComponent();
            _empresa = empresa;

            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }

        private void AdicionarCamiaoForm_Load(object sender, EventArgs e)
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
                    string.IsNullOrWhiteSpace(numEixostxt.Text) ||
                    string.IsNullOrWhiteSpace(maxPasstxt.Text))
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

                if (!int.TryParse(numEixostxt.Text, out int eixos) || (eixos != 2 && eixos != 3))
                {
                    MessageBox.Show("Número de eixos inválido (tem de ser 2 ou 3).");
                    return;
                }

                if (!int.TryParse(maxPasstxt.Text, out int maxPass) || maxPass <= 0)
                {
                    MessageBox.Show("Máx. passageiros inválido (tem de ser > 0).");
                    return;
                }

                // Inserir CAMIONETA 
                _empresa.InserirCamioneta(
                    matriculatxt.Text,
                    marcatxt.Text,
                    modelotxt.Text,
                    ano,
                    preco,
                    EstadoVeiculo.Disponivel,
                    null,
                    eixos,
                    maxPass
                );

                MessageBox.Show("Camioneta inserida com sucesso!");
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
    }
}
