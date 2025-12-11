using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BelosAutomoveisProjeto
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            try
            {
                // Validar campos vazios
                if (string.IsNullOrWhiteSpace(user) && string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Username e Password: os campos são obrigatórios",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Username: o campo é obrigatório",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Password: o campo é obrigatório",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar se o ficheiro existe e se o username ja esta registado
                if (File.Exists("Utilizadores.txt"))
                {
                    StreamReader rd = new StreamReader("Utilizadores.txt");

                    while (!rd.EndOfStream)
                    {
                        string linha = rd.ReadLine();
                        string[] dados = linha.Split(';');

                        if (dados.Length >= 1 && dados[0] == user)
                        {
                            rd.Close();
                            MessageBox.Show("Este username já existe!",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    rd.Close();
                }

                // Gravar novo utilizador
                StreamWriter wr = new StreamWriter("Utilizadores.txt", true);
                wr.WriteLine(user + ";" + pass);
                wr.Close();

                // Sucesso
                MessageBox.Show("Registo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login novoForm = new Login();
                novoForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao registar!\n\nDetalhes: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {

            if (showPass.Checked)
            {
                password.PasswordChar = '\0'; 
            }
            else
            {
                password.PasswordChar = '*'; 
            }
        }
    }
}
