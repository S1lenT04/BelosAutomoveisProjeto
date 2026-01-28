using System;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public partial class AdicionarCarroForm : Form
    {
        private readonly Empresa _empresa;

        // Construtor vazio 
        public AdicionarCarroForm()
        {
            InitializeComponent();
        }

        // Construtor correto 
        public AdicionarCarroForm(Empresa empresa)
        {
            InitializeComponent();
            _empresa = empresa;

            // ligar eventos dos botões
            addBtn.Click += addBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }

        private void AdicionarCarroForm_Load(object sender, EventArgs e)
        {
        }

        // BOTÃO ADICIONAR
        private void addBtn_Click(object? sender, EventArgs e)
        {
            try
            {
                // Validações básicas (textbox)
                if (string.IsNullOrWhiteSpace(matriculatxt.Text) ||
                    string.IsNullOrWhiteSpace(marcatxt.Text) ||
                    string.IsNullOrWhiteSpace(modelotxt.Text) ||
                    string.IsNullOrWhiteSpace(anotxt.Text) ||
                    string.IsNullOrWhiteSpace(precotxt.Text))
                {
                    MessageBox.Show("Preenche todos os campos.");
                    return;
                }

                // Validações básicas (combobox)
                if (numportasDrop.SelectedIndex == -1 || tipoCaixaDrop.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleciona o número de portas e o tipo de caixa.");
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

                // Portas a partir do ComboBox
                if (!int.TryParse(numportasDrop.SelectedItem!.ToString(), out int portas) || (portas != 3 && portas != 5))
                {
                    MessageBox.Show("Número de portas inválido (tem de ser 3 ou 5).");
                    return;
                }

                // Tipo de caixa a partir do combobox

                string caixaTxt = tipoCaixaDrop.SelectedItem!.ToString()!.Trim().ToLower();
                TipoCaixa caixa;

                if (caixaTxt == "manual")
                    caixa = TipoCaixa.Manual;
                else if (caixaTxt == "automatica" || caixaTxt == "automática")
                    caixa = TipoCaixa.Automatica;
                else
                {
                    MessageBox.Show("Tipo de caixa inválido.");
                    return;
                }

                // Chamada ao BACKEND
                _empresa.InserirCarro(
                    matriculatxt.Text,
                    marcatxt.Text,
                    modelotxt.Text,
                    ano,
                    preco,
                    EstadoVeiculo.Disponivel,
                    null,
                    portas,
                    caixa
                );

                MessageBox.Show("Carro inserido com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÃO CANCELAR
        private void cancelarBtn_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void camiaoBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamiaoForm CamiaoForm = new AdicionarCamiaoForm();
            this.Hide();
            CamiaoForm.ShowDialog();
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

