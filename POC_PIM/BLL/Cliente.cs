using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
     public class Cliente
    {
        //valores que correspondem ao que estao no banco
        private int codCliente;
        private string nomeCliente;
        private string emailCliente;
        private string ufCliente;
        private string cidadeCliente;
        private string telefoneCliente;
        private string cepCliente;
        private string logradouroCliente;
        private int numCliente;
        
        //Encapsulamento
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
