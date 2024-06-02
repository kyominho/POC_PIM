using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class Compra
    {
        private int codCompra;
        private DateTime dataHorarioCompra;
        private string formaPagamentoCompra;
        private int codFornecedorC;
        private int codUsuarioC;


        public int CodCompra { get => codCompra; set { codCompra = value; } }
        public DateTime DataHorarioCompra { get => dataHorarioCompra; set { dataHorarioCompra = value; } }
        public string FormaPagamentoCompra { get => formaPagamentoCompra; set { formaPagamentoCompra = value; } }
        public int CodFornecedorC { get => codFornecedorC; set { codFornecedorC = value; } }
        public int CodUsuarioC { get => codUsuarioC; set { codUsuarioC = value; } }

    }
}
