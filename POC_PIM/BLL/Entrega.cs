using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class Entrega
    {
        private int codEntrega;
        private int quantidadeEntrega;
        private int codVendaE;
        private int codClienteE;

        public int CodEntrega { get => codEntrega; set { codEntrega = value;  } }
        public int QuantidadeEntrega { get => quantidadeEntrega; set { quantidadeEntrega = value; } }
        public int CodVendaE { get => codVendaE; set { codVendaE = value; } }
        public int CodClienteE { get => codClienteE; set { codClienteE = value; } }
    }
}
