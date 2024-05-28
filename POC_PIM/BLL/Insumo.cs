using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
     class Insumo
    {
        private int codInsumo;
        private string nomeInsumo;
        private DateTime dataValidadeInsumo;
        private double precoInsumo;

        public int CodInsumo { get => codInsumo; set { codInsumo = value; } }
        public string NomeInsumo { get => nomeInsumo; set {nomeInsumo = value; } }
        public DateTime DataValidadeInsumo { get => dataValidadeInsumo; set { dataValidadeInsumo = value; } }
        public double PrecoInsumo { get => precoInsumo; set { precoInsumo = value; } }

    }
}
