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
    public partial class HomePage : Form
    {
        private Empresa empresa;
        public HomePage()
        {
            InitializeComponent();
            empresa = new Empresa("Belos Automóveis");

            // Criar um veículo de cada tipo só para teste/apresentação
            // (na prática viriam da base de dados ou de ficheiros)
            empresa.InserirCarro(
                "AA-11-BB", "BMW", "Série 1", 2020, 80m,
                EstadoVeiculo.Disponivel, null, 5, TipoCaixa.Manual);

            empresa.InserirCarro(
                "AA-11-BC", "BMW", "Série 1", 2020, 80m,
                EstadoVeiculo.Disponivel, null, 5, TipoCaixa.Manual);

            empresa.InserirCarro(
                "AA-11-BD", "BMW", "Série 1", 2020, 80m,
                EstadoVeiculo.Disponivel, null, 5, TipoCaixa.Manual);

            empresa.InserirCarro(
                "AA-11-BF", "BMW", "Série 1", 2020, 80m,
                EstadoVeiculo.Disponivel, null, 5, TipoCaixa.Manual);

            empresa.InserirMota(
                "CC-22-DD", "Honda", "PCX", 2019, 35m,
                EstadoVeiculo.Disponivel, null, Cilindrada.Cc125);

            empresa.InserirCamiao(
                "EE-33-FF", "Volvo", "FH", 2018, 150m,
                EstadoVeiculo.Disponivel, null, 18000);

            empresa.InserirCamioneta(
                "GG-44-HH", "Mercedes", "Tourismo", 2017, 130m,
                EstadoVeiculo.Reservado, null, 3, 55);

            empresa.InserirCarro(
                "HH-55-II", "Ford", "Focus", 2021, 70m,
                EstadoVeiculo.Alugado, DateTime.Today.AddDays(3), 5, TipoCaixa.Automatica);
        }

        // Atualiza a lista com TODOS os veículos da empresa
        private void AtualizarListaVeiculos()
        {
            flowLayoutPanel1.Controls.Clear();

            var veiculos = empresa.ObterTodosVeiculos();
            foreach (var v in veiculos)
            {
                var item = new VeiculoListItem();
                item.SetData(v); // passa o veículo para o user control
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            AtualizarListaVeiculos();
        }

        private void hoverEffect(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void addVeiculoBtn_Click(object sender, EventArgs e)
        {
            CategoriasAdicionarForm CatForm = new CategoriasAdicionarForm(empresa);

            // Abrir como janela modal, e depois atualizar a lista
            CatForm.ShowDialog();
            AtualizarListaVeiculos();
        }

        private void reservaBtn_Click(object sender, EventArgs e)
        {
            CriarReserva criarReserva = new CriarReserva(empresa);

            criarReserva.ShowDialog();
            AtualizarListaVeiculos();
        }

        private void downloadCsvBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
