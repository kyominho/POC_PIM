using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace POC_PIM.DAL
{
    class UsuarioDAL
    {
        //instanciando a classe de conexao
        Conexao conexao = new Conexao();

        //cadastrando usuario. Trazendo os dados encapsulados da BLL

        public void CadastrarUsuario(BLL.Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"INSERT INTO Usuario VALUES (@NomeUsuario, @NivelAcesso, @Login, @Senha)";

            //inserindo
            cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
            cmd.Parameters.AddWithValue("@NivelAcesso", usuario.NivelAcesso);
            cmd.Parameters.AddWithValue("@Login", usuario.Login);
            cmd.Parameters.AddWithValue("@Senha", usuario.Senha);

            //chamando o metodo de abrir conexao com o banco
            cmd.Connection = conexao.Conectar();

            //executando os comandos
            cmd.ExecuteNonQuery();

            //chamando o metodo de fechar conexão
            conexao.Desconectar();

        }

        //CONSULTA DE USUÁRIOS
        public List<BLL.Usuario> GetUsuarios()
        {
            List<BLL.Usuario> usuarios = new List<BLL.Usuario>();

            Conexao conexao = new Conexao();

            SqlCommand cmd = new SqlCommand();

            //selecionando os dados
            cmd.CommandText = @"SELECT * FROM Usuario";

            cmd.Connection = conexao.Conectar();

            //executando o comando e armazenando os resultados
            SqlDataReader reader = cmd.ExecuteReader();

            //lendo os resultados
            while (reader.Read())
            {
                BLL.Usuario usuario = new BLL.Usuario();
                usuario.NomeUsuario = reader ["nomeUsuario"].ToString();
                usuario.NivelAcesso = Convert.ToInt16 (reader ["nivelAcesso"].ToString());
                usuario.Login = reader ["login"].ToString();
                usuario.Senha = reader ["senha"].ToString();

                usuarios.Add(usuario);

                

               

            }
            //fechando conexao
            conexao.Desconectar();
            return usuarios;
        }
    }
}
