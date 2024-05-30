using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class Venda
    {
        private int codVenda;
        private DateTime dataHorarioVenda;
        private string formaPagamentoVenda;
        private int codUsuarioV;
        private int codClienteV;

        public int CodVenda { get => codVenda; set { codVenda = value; } }
        public DateTime DataHorarioVenda { get => dataHorarioVenda; set { dataHorarioVenda = value; } }
        public string FormaPagamentoVenda { get => formaPagamentoVenda; set { formaPagamentoVenda = value; } }
        public int CodUsuarioV { get => codUsuarioV; set { codUsuarioV = value; } } 
        public int CodClienteV { get => codClienteV; set { codClienteV = value; } } 

    }
}
