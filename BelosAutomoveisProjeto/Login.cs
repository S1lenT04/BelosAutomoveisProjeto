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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            try
            {
                // Validações
                if (string.IsNullOrWhiteSpace(user) && string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Username e Password: ambos os campos são obrigatórios",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Username: este campo é obrigatório",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Password: este campo é obrigatório",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HomePage novoForm = new HomePage();

                // Verificar se o ficheiro existe e procurar user/pass
                if (File.Exists("Utilizadores.txt"))
                {
                    StreamReader rd = new StreamReader("Utilizadores.txt");
                    string linha = "";

                    while (!rd.EndOfStream)
                    {
                        linha = rd.ReadLine();
                        string[] partes = linha.Split(';');

                        if (partes.Length == 2 && partes[0] == user && partes[1] == pass)
                        {
                            rd.Close();
                            novoForm.Show();
                            this.Hide();
                            return;
                        }
                    }

                    rd.Close();
                }

                MessageBox.Show("Dados incorretos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao fazer login, tente novamente!\n\nDetalhes: " + ex.Message,
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();

            signup.Show();
            this.Close();
        }
    }
}
