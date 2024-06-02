using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class ItensCompra
    {
        private int codItensCompra;
        private int quantidadeItensCompra;
        private double valorTotalItensCompra;
        private int codCompraIC;
        private int codInsumoIC;

        public int CodItensCompra { get => codItensCompra; set { codItensCompra = value; } }
        public int QuantidadeItensCompra { get => quantidadeItensCompra; set { quantidadeItensCompra = value; } }
        public double ValorTotalItensCompra { get => valorTotalItensCompra; set { valorTotalItensCompra = value; } } 
        public int CodCompraIC { get => codCompraIC; set { codCompraIC = value; } }
        public int CodInsumoIC { get => codInsumoIC; set { codInsumoIC = value; } }
    }
}
