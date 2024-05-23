using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    class ClienteFisico
    {
        int codClienteFisico;
        string cpfCliente;
        int codClienteF;


        public int CodClienteFisico { get => codClienteFisico; set {codClienteFisico = value; } }
        public string CpfCliente { get => cpfCliente; set { cpfCliente = value; } }
        public int CodClienteF { get => codClienteF; set { codClienteF = value; } }
    }
}
