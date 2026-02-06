using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelosAutomoveisProjeto
{
    public class buscarData
    {
        //O modificador 'static' garante que a data seja partilhada por todos os Forms da app
        private static DateTime data = DateTime.Now.Date; 

        //cria uma variavel data para que fique com a data atual
        public void dataAgora()
        {
            data = DateTime.Now.Date;
        }

        //recua um dia, mas apenas se a data resultante não for anterior a hoje
        public void RecuarDia()
        {
            if (data > DateTime.Now.Date)
            {
                data = data.AddDays(-1);
            }
            else
            {
                MessageBox.Show($"Não pode recuar a uma data inferior a {DateTime.Now.Date.ToString("dd/MM/yyyy")}" ,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //avanca um dia
        public void AvancarDia()
        {
            data = data.AddDays(1);
        }
        //vai buscar a data atual
        public DateTime GetData()
        {
            return data;
        }

    }
}
