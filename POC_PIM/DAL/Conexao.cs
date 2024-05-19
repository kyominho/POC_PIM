using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; //biblioteca para banco de dados. DLL TÁ AQUI.

namespace POC_PIM.DAL
{
    class Conexao
    {

        //caminho da conexao com o banco de dados
        //passando o endereço do banco de dados para fazer a conexão
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-QR3NRU5;Initial Catalog=Fazenda;Integrated Security=True");

        //metodo que abre a conexão com o banco de dados
        public SqlConnection Conectar ()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open ();
                
            }

            return conexao;
        }

        //metodo que fecha conexao com o banco de dados

        public void Desconectar ()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
            
        

    
}
}
