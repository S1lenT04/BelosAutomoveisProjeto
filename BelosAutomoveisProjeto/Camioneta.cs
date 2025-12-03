using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public class Camioneta : Veiculo
    {
        public int NumeroEixos { get; set; } // 2 ou 3
        public int MaximoPassageiros { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Eixos: {NumeroEixos}, Máx. Passageiros: {MaximoPassageiros}";
        }
    }
}
