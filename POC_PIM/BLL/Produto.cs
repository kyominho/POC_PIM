using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    internal class Produto
    {
        int codProduto;
        string nomeProduto;
        double precoProduto;
        DateTime dataValidadeProduto;

        public int CodProduto { get => codProduto; set { codProduto = value; } }

        public string NomeProduto { get => nomeProduto; set { nomeProduto = value; } }

        public double PrecoProduto { get => precoProduto; set { precoProduto = value; } }   

        public DateTime DataValidadeProduto { get => dataValidadeProduto; set { dataValidadeProduto = value; } }
    }
}
