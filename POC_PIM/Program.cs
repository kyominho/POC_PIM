using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_PIM
{
     class Program


    {
        static void Main(string[] args)
        {
            /*Instanciando classes

           
            BLL.Cliente cliente = new BLL.Cliente();
            DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
           

           //CADASTRO DE CLIENTE

            
            try
            {
                Console.WriteLine("Informe o nome do cliente: ");
                cliente.NomeCliente = Console.ReadLine();

                Console.WriteLine("Informe o email do Cliente: ");
                cliente.EmailCliente = Console.ReadLine();

                Console.WriteLine("Informe o UF do Cliente: ");
                cliente.UFCliente = Console.ReadLine();

                Console.WriteLine("Informe a cidade do Cliente: ");
                cliente.CidadeCliente = Console.ReadLine();

                Console.WriteLine("Informe o telefone do Cliente: ");
                cliente.TelefoneCliente = Console.ReadLine();

                Console.WriteLine("Informe o Cep do Cliente: ");
                cliente.CepCliente = Console.ReadLine();

                Console.WriteLine("Informe o Logradouro do Cliente: ");
                cliente.LogradouroCliente = Console.ReadLine();

                Console.WriteLine("Informe o número residencial do Cliente: ");
                cliente.NumCliente = Convert.ToInt16(Console.ReadLine());

                clienteDAL.CadastrarCliente(cliente);

                Console.WriteLine("Dados cadastrados!");
                Console.ReadKey();

            }

            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro ao executar cadastro de cliente {0}. Erro: {1}",cliente.NomeCliente, ex.Message));
                Console.ReadKey();

            }

            */
            
            /*CADASTRO DE USUARIO

            BLL.Usuario usuario = new BLL.Usuario();
            DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();

            try
            {
                Console.WriteLine("Informe o nome do usuário: ");
                usuario.NomeUsuario = Console.ReadLine();

                Console.WriteLine("Informe o nivel de acesso do usuário: ");
                usuario.NivelAcesso = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Informe o login do usuário: ");
                usuario.Login = Console.ReadLine();

                Console.WriteLine("Informe a senha do usuário: ");
                usuario.Senha = Console.ReadLine();

                usuarioDAL.CadastrarUsuario(usuario);

                Console.WriteLine("Dados cadastrados!");

                Console.ReadKey();

            }

            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro ao executar cadastro de usuário {0}. Erro: {1}", usuario.NomeUsuario, ex.Message));
                Console.ReadKey();
            }

           
            */

            //CADASTRO DE PRODUTO
            BLL.Produto produto = new BLL.Produto();
            DAL.ProdutoDAL produtoDAL = new DAL.ProdutoDAL();

            try
            {
                Console.WriteLine("Informe o nome do produto: ");
                produto.NomeProduto = Console.ReadLine();

                Console.WriteLine("Informe o preço do produto: ");
                produto.PrecoProduto = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a data de validade do produto: ");
                produto.DataValidadeProduto = Convert.ToDateTime(Console.ReadLine());

                produtoDAL.CadastrarProduto(produto);


                Console.WriteLine("Dados cadastrados!");

                Console.ReadKey();
            }

            catch (Exception ex)
            {
                Console.WriteLine(String.Format("Erro ao executar cadastro de produto {0}.  Erro:  " +
                    "{1}", produto.NomeProduto, ex.Message));
                Console.ReadKey();
            }


        }


    }
}
