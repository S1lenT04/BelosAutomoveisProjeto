using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BelosAutomoveisProjeto
{
    public partial class HomePage : Form
    {
        private Empresa empresa;
        private string nomeUtilizador;
        private buscarData d = new buscarData();

        public HomePage(string nomeUtilizador = "")
        {
            InitializeComponent();
            this.nomeUtilizador = nomeUtilizador;
            empresa = new Empresa("Belos Automóveis");

            // vai buscar a data atual e coloca na label

            precoFinalLabel.Text = d.GetData().ToString("dd/MM/yyyy");



            // Criar um veículo de cada tipo
            empresa.InserirCarro(
                "AA-11-BB", "BMW", "Série 1", 2020, 80m,
                EstadoVeiculo.Disponivel, null, 5, TipoCaixa.Manual);

            empresa.InserirMota(
                "CC-22-DD", "Honda", "PCX", 2019, 35m,
                EstadoVeiculo.EmManutencao, DateTime.Today.AddDays(14), Cilindrada.Cc125);

            empresa.InserirCamiao(
                "EE-33-FF", "Volvo", "FH", 2018, 150m,
                EstadoVeiculo.EmManutencao, DateTime.Today.AddDays(9), 18000);

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

            // Mostra o nome do utilizador na label
            if (!string.IsNullOrWhiteSpace(nomeUtilizador))
            {
                username.Text = nomeUtilizador;
            }
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
            try
            {
                //Abre o explorador de ficheiros para escolher onde guardar o ficheiro
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveDialog.FileName = "veiculos.csv";

                // Abre a janela "Guardar como" e continua apenas se o utilizador confirmar
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cria um escritor de ficheiro CSV no caminho escolhido usando codificação UTF-8
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                    {
                        // Cabeçalho
                        writer.WriteLine("Tipo;Matrícula;Marca;Modelo;Ano;Preço Diário;Estado;Data Disponível;Detalhes");

                        foreach (var veiculo in empresa.Veiculos)
                        {
                            string linha = $"{veiculo.GetType().Name};{veiculo.Matricula};{veiculo.Marca};{veiculo.Modelo};{veiculo.Ano};{veiculo.PrecoDiario};{veiculo.Estado};";

                            if (veiculo.DataDisponivel.HasValue)
                            {
                                linha += veiculo.DataDisponivel.Value.ToString("dd/MM/yyyy");
                            }
                            linha += ";";

                            // Detalhes específicos
                            string detalhes = "";
                            if (veiculo is Carro carro)
                            {
                                detalhes = $"Portas: {carro.NumeroPortas}, Caixa: {carro.TipoCaixa}";
                            }
                            else if (veiculo is Mota mota)
                            {
                                detalhes = $"Cilindrada: {(int)mota.Cilindrada}cc";
                            }
                            else if (veiculo is Camioneta camioneta)
                            {
                                detalhes = $"Eixos: {camioneta.NumeroEixos}, Máx. Passageiros: {camioneta.MaximoPassageiros}";
                            }
                            else if (veiculo is Camiao camiao)
                            {
                                detalhes = $"Peso Máx: {camiao.PesoMaximoKg} kg";
                            }

                            linha += detalhes;
                            writer.WriteLine(linha);
                        }
                    }

                    MessageBox.Show($"Ficheiro exportado com sucesso!\n\n{saveDialog.FileName}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exportar CSV: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // MOSTRA TODOS OS VEÍCULOS
        private void todosBtn_Click(object sender, EventArgs e)
        {
            AtualizarListaVeiculos();
        }

        // MOSTRA APENAS OS CARROS
        private void carroBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var veiculos = empresa.ObterTodosVeiculos();
            foreach (var v in veiculos)
            {
                if (v is Carro)
                {
                    var item = new VeiculoListItem();
                    item.SetData(v);
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        // MOSTRA APENAS OS CAMIÕES
        private void camiaoBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var veiculos = empresa.ObterTodosVeiculos();
            foreach (var v in veiculos)
            {
                if (v is Camiao)
                {
                    var item = new VeiculoListItem();
                    item.SetData(v);
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        // MOSTRA APENAS AS CAMIONETAS
        private void camionetaBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var veiculos = empresa.ObterTodosVeiculos();
            foreach (var v in veiculos)
            {
                if (v is Camioneta)
                {
                    var item = new VeiculoListItem();
                    item.SetData(v);
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        // MOSTRA APENAS AS MOTAS
        private void motaBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var veiculos = empresa.ObterTodosVeiculos();
            foreach (var v in veiculos)
            {
                if (v is Mota)
                {
                    var item = new VeiculoListItem();
                    item.SetData(v);
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }
        private void estadoBtn_Click(object sender, EventArgs e)
        {
        }

        // MOSTRA APENAS OS VEÍCULOS EM MANUTENÇÃO
        private void emManutencaoBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var veiculosEmManutencao = empresa.ObterVeiculosEmManutencao();
            foreach (var v in veiculosEmManutencao)
            {
                var item = new VeiculoListItem();
                item.SetData(v);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();

            Login.Show();
            this.Close();
        }

        private void estadoBtn_Click_1(object sender, EventArgs e)
        {
            AlterarEstado AlterarEstado = new AlterarEstado(empresa);

            AlterarEstado.ShowDialog();
            AtualizarListaVeiculos();
        }

        private void faturacaoBtn_Click(object sender, EventArgs e)
        {
            Faturação faturacao = new Faturação();

            faturacao.ShowDialog();
            AtualizarListaVeiculos();
        }

        private void precoFinalLabel_Click(object sender, EventArgs e)
        {


        }

        //botao para recuar um dia
        private void button1_Click(object sender, EventArgs e)
        {
            d.RecuarDia();
            precoFinalLabel.Text = d.GetData().ToString("dd/MM/yyyy");
        }

        //botao para avancar um dia
        private void button2_Click(object sender, EventArgs e)
        {
            d.AvancarDia();
            precoFinalLabel.Text = d.GetData().ToString("dd/MM/yyyy");
        }

      
    }
}
