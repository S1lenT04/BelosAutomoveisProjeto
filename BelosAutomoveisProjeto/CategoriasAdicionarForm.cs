using System;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public partial class CategoriasAdicionarForm : Form
    {
        private readonly Empresa _empresa;

        // agora recebe Empresa
        public CategoriasAdicionarForm(Empresa empresa)
        {
            InitializeComponent();
            _empresa = empresa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seguinteBtn_Click(object sender, EventArgs e)
        {
        }

        // SÓ O CARRO FOI ALTERADO
        private void carroBtn_Click(object sender, EventArgs e)
        {
            var carroForm = new AdicionarCarroForm(_empresa);
            this.Hide();
            carroForm.ShowDialog(); // espera fechar
            this.Close();           // fecha este selector
        }

        private void camiaoBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamiaoForm CamiaoForm = new AdicionarCamiaoForm(_empresa);
            this.Hide();
            CamiaoForm.ShowDialog();
            this.Close();
        }

        private void camionetaBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamionetaForm CamionetaForm = new AdicionarCamionetaForm(_empresa);
            this.Hide();
            CamionetaForm.ShowDialog();
            this.Close();
        }

        private void motaBtn_Click(object sender, EventArgs e)
        {
            AdicionarMotaForm MotaForm = new AdicionarMotaForm(_empresa);
            this.Hide();
            MotaForm.ShowDialog();
            this.Close();
        }
    }
}

