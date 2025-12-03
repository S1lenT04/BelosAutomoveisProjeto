using Microsoft.VisualBasic.Devices;
using System.Timers;

namespace BelosAutomoveisProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Login Login = new Login();
            Login.Show();
            this.Hide();
        }
    }
}