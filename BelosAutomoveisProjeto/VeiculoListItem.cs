using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BelosAutomoveisProjeto.Properties;

namespace BelosAutomoveisProjeto
{
    public partial class VeiculoListItem : UserControl
    {
        public VeiculoListItem()
        {
            InitializeComponent();
        }

        // Preenche as labels com os dados do veículo. dataFimReserva: data de fim da reserva (se existir); senão usa DataDisponivel.
        public void SetData(Veiculo v, DateTime? dataFimReserva = null)
        {
            if (v == null) return;

            matriculatxt.Text = v.Matricula;
            marcatxt.Text = v.Marca;
            modelotxt.Text = v.Modelo;
            anotxt.Text = v.Ano.ToString();
            precotxt.Text = $"{v.PrecoDiario:0.00}€";
            // Preferir a data de fim da reserva; senão a data disponível do veículo
            var dataFim = dataFimReserva ?? v.DataDisponivel;
            dataFimtxt.Text = dataFim.HasValue ? dataFim.Value.ToString("dd/MM/yyyy") : "-";

            // imagens vindas dos Resources (já adicionadas no projeto)
            categoriaImg.Image = v switch
            {
                Carro => Resources.carro,
                Mota => Resources.mota,
                Camiao => Resources.camiao,
                Camioneta => Resources.camioneta,
                _ => null
            };

            estadoImg.Image = v.Estado switch
            {
                EstadoVeiculo.Disponivel => Resources.estado_disponivel,
                EstadoVeiculo.Alugado => Resources.estado_alugado,
                EstadoVeiculo.Reservado => Resources.estado_reservado,
                EstadoVeiculo.EmManutencao => Resources.estado_manutencao,
                _ => null
            };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
