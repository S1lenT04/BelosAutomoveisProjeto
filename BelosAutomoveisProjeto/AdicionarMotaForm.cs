using System;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public partial class AdicionarMotaForm : Form
    {
        private Empresa? _empresa;

        // Necessário para o Designer
        public AdicionarMotaForm()
        {
            InitializeComponent();
            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }

        // Construtor usado pela aplicação (passa a Empresa)
        public AdicionarMotaForm(Empresa empresa)
        {
            InitializeComponent();
            _empresa = empresa;

            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
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
                    cilindradaDrop.SelectedIndex == -1)
                {
                    MessageBox.Show("Preenche todos os campos.");
                    return;
                }

                if (_empresa == null)
                {
                    MessageBox.Show("Erro interno: empresa não inicializada.");
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

                // Aceita "50cc", "125cc", "300cc"
                string cilTxt = cilindradaDrop.SelectedItem!.ToString()!.Trim().ToLower().Replace("cc", "");
                if (!int.TryParse(cilTxt, out int cilValor) ||
                    (cilValor != 50 && cilValor != 125 && cilValor != 300))
                {
                    MessageBox.Show("Cilindrada inválida (usa 50, 125 ou 300).");
                    return;
                }

                var cilindrada = (Cilindrada)cilValor;

                _empresa.InserirMota(
                    matriculatxt.Text,
                    marcatxt.Text,
                    modelotxt.Text,
                    ano,
                    preco,
                    EstadoVeiculo.Disponivel,
                    null,
                    cilindrada
                );

                MessageBox.Show("Mota inserida com sucesso!");
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

        private void AdicionarMotaForm_Load(object sender, EventArgs e)
        {
            // pode ficar vazio
        }

        private void camiaoBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamiaoForm CamiaoForm = new AdicionarCamiaoForm();
            this.Hide();
            CamiaoForm.ShowDialog();
            this.Close();
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
    }
}

