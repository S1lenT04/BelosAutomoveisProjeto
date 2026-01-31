using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //recua um dia
        public void RecuarDia()
        {
            data = data.AddDays(-1);
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
