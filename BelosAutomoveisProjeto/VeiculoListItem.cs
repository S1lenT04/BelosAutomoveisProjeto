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

        // Método simples para preencher as labels com os dados dos veiculos
        public void SetData(Veiculo v)
        {
            if (v == null) return;

            matriculatxt.Text = v.Matricula;
            marcatxt.Text = v.Marca;
            modelotxt.Text = v.Modelo;
            anotxt.Text = v.Ano.ToString();
            precotxt.Text = $"{v.PrecoDiario:0.00}€";
            // Data: mostra DataDisponivel se existir; senão deixa vazio/N/A
            datatxt.Text = v.DataDisponivel.HasValue
                ? v.DataDisponivel.Value.ToString("dd/MM/yyyy")
                : string.Empty;

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
