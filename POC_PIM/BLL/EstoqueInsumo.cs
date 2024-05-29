using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    class EstoqueInsumo
    {
        private int codEstoqueInsumo;
        private int quantidadeEstoqueInsumo;
        private int codInsumoEI;

        public int CodEstoqueInsumo { get => codEstoqueInsumo; set { codEstoqueInsumo = value; } }
        public int QuantidadeEstoqueInsumo { get => quantidadeEstoqueInsumo; set { quantidadeEstoqueInsumo = value; } }
        public int CodInsumoEI { get => codInsumoEI; set { codInsumoEI = value; } }


    }
}
