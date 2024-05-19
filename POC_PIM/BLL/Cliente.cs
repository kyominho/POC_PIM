using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
     class Cliente
    {
        int codCliente;
        string nomeCliente;
        string emailCliente;
        string ufCliente;
        string cidadeCliente;
        string telefoneCliente;
        string cepCliente;
        string logradouroCliente;
        int numCliente;
        
        public int CodCliente { get => codCliente; set => codCliente = value; }
       
        public string NomeCliente { get => nomeCliente; set { nomeCliente = value; } }

        public string EmailCliente { get => emailCliente; set { emailCliente = value; } }

        public string UFCliente { get => ufCliente; set { ufCliente = value; } }

        public string CidadeCliente { get => cidadeCliente; set { cidadeCliente = value; } }

        public string TelefoneCliente { get => telefoneCliente; set { telefoneCliente = value; } }

        public string CepCliente { get => cepCliente; set { cepCliente = value; } }

        public string LogradouroCliente { get => logradouroCliente; set {logradouroCliente = value; } }

        public int NumCliente { get => numCliente; set { numCliente = value; } }




    }
}
