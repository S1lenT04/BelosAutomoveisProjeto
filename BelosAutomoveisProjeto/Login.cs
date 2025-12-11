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
                // Validations
                if (string.IsNullOrWhiteSpace(user) && string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Username and Password: both fields are required",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(user))
                {
                    MessageBox.Show("Username: this field is required",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Password: this field is required",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HomePage newForm = new HomePage();

                // Check if file exists and read user/pass
                if (File.Exists("Utilizadores.txt"))
                {
                    StreamReader rd = new StreamReader("Utilizadores.txt");
                    string line = "";

                    while (!rd.EndOfStream)
                    {
                        line = rd.ReadLine();
                        string[] parts = line.Split(';');

                        if (parts.Length == 2 && parts[0] == user && parts[1] == pass)
                        {
                            rd.Close();
                            newForm.Show();
                            this.Hide();
                            return;
                        }
                    }

                    rd.Close();
                }

                MessageBox.Show("Incorrect credentials!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error while logging in, please try again!\n\nDetails: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {

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
