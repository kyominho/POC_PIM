using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM.BLL
{
    public class Plantacao
    {
        private int codPlantacao;
        private DateTime dataHorarioPlantacao;
        private int quantidadePlantacao;
        private int codInsumoP;


        public int CodPlantacao { get => codPlantacao; set { codPlantacao = value; } } 
        public DateTime DataHorarioPlantacao { get => dataHorarioPlantacao; set { dataHorarioPlantacao = value; } }
        public int QuantidadePlantacao { get => quantidadePlantacao; set { quantidadePlantacao = value; } } 
        public int CodInsumoP { get => codInsumoP; set { codInsumoP = value; } }    



    }
}
