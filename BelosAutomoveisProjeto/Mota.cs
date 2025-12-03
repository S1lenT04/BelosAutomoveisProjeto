using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelosAutomoveisProjeto
{
    public class Mota : Veiculo
    {
        public Cilindrada Cilindrada { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Cilindrada: {(int)Cilindrada}cc";
        }
    }
}
