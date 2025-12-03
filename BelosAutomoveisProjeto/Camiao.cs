using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public class Camiao : Veiculo
    {
        public double PesoMaximoKg { get; set; }
        //teste
        public override string ToString()
        {
            return base.ToString() + $", Peso Máx: {PesoMaximoKg} kg";
        }
    }
}
