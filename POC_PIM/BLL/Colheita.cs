using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POC_PIM.BLL
{
    public class Colheita
    {
        private int codColheita;
        private DateTime dataHorarioColheita;
        private int quantidadeColheita;
        private int codProdutoC;

        public int CodColheita { get => codColheita; set { codColheita = value; } }
        public DateTime DataHorarioColheita { get => dataHorarioColheita; set { dataHorarioColheita = value; } }
        public int QuantidadeColheita { get => quantidadeColheita; set { quantidadeColheita = value; } }
        public int CodProdutoC { get => codProdutoC; set { codProdutoC = value; } }


    }
}
