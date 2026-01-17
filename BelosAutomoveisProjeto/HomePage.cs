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
        public HomePage()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            VeiculoListItem[] listItems = new VeiculoListItem[5];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new VeiculoListItem();
                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void hoverEffect(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void dashboardBtn_MouseEnter(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
