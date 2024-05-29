using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace POC_PIM.DAL
{
    class EstoqueInsumoDAL
    {
        //classe de conexão com o Banco de Dados
        Conexao conexao = new Conexao();

        public void CadastrarEstoqueI (BLL.EstoqueInsumo estoqueInsumo)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO EstoqueInsumo VALUES (@QuantidadeEstoqueInsumo, @CodInsumoEI)";
            cmd.Parameters.AddWithValue("@QuantidadeEstoqueInsumo", estoqueInsumo.QuantidadeEstoqueInsumo);
            cmd.Parameters.AddWithValue("@CodInsumoEI", estoqueInsumo.CodInsumoEI);

            //chamando metodo de abrir conexao com o BD
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando metodo de fechar conexao 
            conexao.Desconectar();
        }
    }
}
