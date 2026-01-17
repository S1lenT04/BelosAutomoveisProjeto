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
    public partial class CategoriasAdicionarForm : Form
    {
        public CategoriasAdicionarForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seguinteBtn_Click(object sender, EventArgs e)
        {

        }

        private void carroBtn_Click(object sender, EventArgs e)
        {
            AdicionarCarroForm CarroForm = new AdicionarCarroForm();
            this.Close();
            CarroForm.Show();
        }

        private void camiaoBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamiaoForm CamiaoForm = new AdicionarCamiaoForm();
            this.Close();
            CamiaoForm.Show();
        }

        private void camionetaBtn_Click(object sender, EventArgs e)
        {
            AdicionarCamionetaForm CamionetaForm = new AdicionarCamionetaForm();
            this.Close();
            CamionetaForm.Show();
        }

        private void motaBtn_Click(object sender, EventArgs e)
        {
            AdicionarMotaForm MotaForm = new AdicionarMotaForm();
            this.Close();
            MotaForm.Show();
        }
    }
}
