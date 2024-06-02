
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class EstoqueProduto
    {
        private int codEstoqueProduto;
        private int quantidadeEstoqueProduto;
        private int codProdutoEP;

        public int CodEstoqueProduto { get => codEstoqueProduto; set { codEstoqueProduto = value; } }
        public int QuantidadeEstoqueProduto { get => quantidadeEstoqueProduto; set { quantidadeEstoqueProduto = value; } }
        public int CodProdutoEP { get => codProdutoEP; set { codProdutoEP = value; } }
    }
}
