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
                    string.IsNullOrWhiteSpace(numEixostxt.Text))
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
                if (!double.TryParse(numEixostxt.Text, out double pesoKg) || pesoKg <= 0)
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

        private void carroBtn_Click(object sender, EventArgs e)
        {
            AdicionarCarroForm CarroForm = new AdicionarCarroForm();
            this.Hide();
            CarroForm.ShowDialog();
            this.Close();
        }

        private void camionetaBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamionetaForm CamionetaForm = new AdicionarCamionetaForm();
            this.Hide();
            CamionetaForm.ShowDialog();
            this.Close();
        }

        private void motaBtn_Click(object sender, EventArgs e)
        {
            AdicionarMotaForm MotaForm = new AdicionarMotaForm();
            this.Hide();
            MotaForm.ShowDialog();
            this.Close();
        }
    }
}
