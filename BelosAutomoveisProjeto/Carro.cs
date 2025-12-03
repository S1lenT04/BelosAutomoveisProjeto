using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; } // 3 ou 5
        public TipoCaixa TipoCaixa { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Portas: {NumeroPortas}, Caixa: {TipoCaixa}";
        }
    }
}
