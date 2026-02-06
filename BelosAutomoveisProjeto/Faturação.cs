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
    public partial class Faturação : Form
    {
        private Empresa empresa;

        public Faturação(Empresa empresa)
        {
            InitializeComponent();
            this.empresa = empresa;

            faturacaoPrecoLabel.Text = "0,00€";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcularFaturacaoBtn_Click(object sender, EventArgs e)
        {
            DateTime inicio = dateTimePicker1.Value.Date;
            DateTime fim = dateTimePicker2.Value.Date;

            if (fim < inicio)
            {
                MessageBox.Show("A data de fim não pode ser anterior à data de início.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                decimal total = 0;
                foreach (var r in empresa.Reservas)
                {
                    if (r.Estado != EstadoReserva.Ativa || r.Veiculo.Estado != EstadoVeiculo.Alugado)
                        continue;
                    DateTime rInicio = r.DataInicio.Date;
                    DateTime rFim = r.DataFim.Date;
                    if (rFim < inicio || rInicio > fim)
                        continue;
                    DateTime sobreposicaoInicio = rInicio > inicio ? rInicio : inicio;
                    DateTime sobreposicaoFim = rFim < fim ? rFim : fim;
                    int dias = Math.Max(1, (int)Math.Ceiling((sobreposicaoFim - sobreposicaoInicio).TotalDays));
                    total += dias * r.Veiculo.PrecoDiario;
                }
                faturacaoPrecoLabel.Text = $"{total:0.00}€";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular faturação: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
