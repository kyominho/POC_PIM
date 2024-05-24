using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class Fornecedor
    {
        private int codFornecedor;
        private string nomeFornecedor;
        private string emailFornecedor;
        private string ufFornecedor;
        private string cidadeFornecedor;
        private string logradouroFornecedor;
        private int numeroEnderecoFornecedor;
        private string cnpjFornecedor;
        private string razaoSocialFornecedor;

        public int CodFornecedor { get => codFornecedor; set { codFornecedor = value; } }
        public string NomeFornecedor { get => nomeFornecedor; set { nomeFornecedor = value; } }
        public string EmailFornecedor { get => emailFornecedor; set { emailFornecedor = value; }}
        public string UfFornecedor { get => ufFornecedor; set { ufFornecedor = value; } }
        public string CidadeFornecedor { get => cidadeFornecedor; set { cidadeFornecedor = value; } }
        public string LogradouroFornecedor { get => logradouroFornecedor; set { logradouroFornecedor = value; } }
        public int NumeroEnderecoFornecedor { get => numeroEnderecoFornecedor; set { numeroEnderecoFornecedor = value; } }
        public string CnpjFornecedor { get => cnpjFornecedor; set { cnpjFornecedor = value; } }
        public string RazaoSocialFornecedor { get => razaoSocialFornecedor; set { razaoSocialFornecedor = value;  } }

        


    }
}
