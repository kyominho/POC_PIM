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
            int escolha;
            #region Opções 
            Console.WriteLine("Escolha uma das opções abaixo: ");

            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Usuário");
            Console.WriteLine("3 - Cadastrar Produto");
            Console.WriteLine("4 - Cadastrar Cliente Fisíco");
            Console.WriteLine("5 - Cadastrar Cliente Juridico");
            Console.WriteLine("6 - Cadastrar Fornecedor");
            Console.WriteLine("7 - Cadastrar Insumo");
            Console.WriteLine("8 - Cadastrar Estoque de Insumo");
            Console.WriteLine("9 - Cadastrar Estoque de Produto");
            Console.WriteLine("10 - Cadastrar Compra");
            Console.WriteLine("11 - Cadastrar Venda");
            Console.WriteLine("12 - Cadastrar Itens de Venda");
            Console.WriteLine("13 - Cadastrar Itens de Compra");
            Console.WriteLine("14 - Cadastrar Plantação");
            Console.WriteLine("15 - Cadastrar Colheita");
            Console.WriteLine("16 - Cadastrar Entrega");


            escolha = Convert.ToInt32(Console.ReadLine());

            #endregion

            switch (escolha)
            {
                #region Cadastro de Cliente
                case 1:

                    //Instanciando classes
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

                        ConsultaCliente();

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de cliente {0}. Erro: {1}", cliente.NomeCliente, ex.Message));
                        Console.ReadKey();

                    }

                    break;

                #endregion

                #region Cadastro de Usuário
                case 2:

                    //Instanciando classes
                    BLL.Usuario usuario = new BLL.Usuario();
                    DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();

                    try
                    {
                        Console.WriteLine("Informe o nome do usuário: \n");
                        usuario.NomeUsuario = Console.ReadLine();

                        Console.WriteLine("Informe o nivel de acesso do usuário: \n");
                        usuario.NivelAcesso = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Informe o login do usuário: \n ");
                        usuario.Login = Console.ReadLine();

                        Console.WriteLine("Informe a senha do usuário: \n ");
                        usuario.Senha = Console.ReadLine();

                        usuarioDAL.CadastrarUsuario(usuario);

                        Console.WriteLine("Dados cadastrados!\n\n\n");

                        ConsultaUsuario();
                        Console.ReadKey();
                        Console.Clear();


                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de usuário {0}. Erro: {1}", usuario.NomeUsuario, ex.Message));
                        Console.ReadKey();
                    }


                    break;

                #endregion

                #region Cadastro de Produto
                case 3:
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
                        Console.Clear();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de produto {0}.  Erro:  " +
                            "{1}", produto.NomeProduto, ex.Message));
                        Console.ReadKey();
                    }

                    break;
                #endregion

                #region Cadastro de Cliente Fisico 
                case 4:

                    BLL.ClienteFisico clienteFisico = new BLL.ClienteFisico();
                    DAL.ClienteFisicoDAL clienteFisicoDAL = new DAL.ClienteFisicoDAL();

                    try
                    {
                        Console.WriteLine("Digite o CPF do Cliente: ");
                        clienteFisico.CpfCliente = Console.ReadLine();

                        Console.WriteLine("Digite o código do cliente");
                        clienteFisico.CodClienteF = Convert.ToInt16(Console.ReadLine());

                        clienteFisicoDAL.CadastrarClienteF(clienteFisico);

                        Console.WriteLine("Dados cadastrados!");


                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de cliente fisíco {0}.  Erro:  " +
                            "{1}", clienteFisico.CpfCliente, ex.Message));
                        Console.ReadKey();
                    }

                    break;
                #endregion

                #region Cadastro de Cliente Juridico
                case 5:

                    BLL.ClienteJuridico clienteJuridico = new BLL.ClienteJuridico();
                    DAL.ClienteJuridicoDAL clienteJuridicoDAL = new DAL.ClienteJuridicoDAL();

                    try
                    {


                        Console.WriteLine("Digite o CNPJ da empresa: ");
                        clienteJuridico.CnpjCliente = Console.ReadLine();

                        Console.WriteLine("Digite a Razão Social: ");
                        clienteJuridico.RazaoSocialCliente = Console.ReadLine();

                        Console.WriteLine("Digite o código do Cliente: ");
                        clienteJuridico.CodClienteJ = Convert.ToInt16(Console.ReadLine());

                        clienteJuridicoDAL.CadastrarClienteJ(clienteJuridico);



                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de cliente juridico {0}.  Erro:  " +
        "{1}", clienteJuridico.RazaoSocialCliente, ex.Message));
                        Console.ReadKey();
                    }





                    break;

                #endregion

                #region Cadastro de Fornecedor
                case 6:

                    BLL.Fornecedor fornecedor = new BLL.Fornecedor();
                    DAL.FornecedorDAL fornecedorDAL = new DAL.FornecedorDAL();

                    try
                    {
                        Console.WriteLine("Digite o nome do Fornecedor: ");
                        fornecedor.NomeFornecedor = Console.ReadLine();

                        Console.WriteLine("Digite o email do Fornecedor: ");
                        fornecedor.EmailFornecedor = Console.ReadLine();

                        Console.WriteLine("Digite o UF do Fornecedor: ");
                        fornecedor.UfFornecedor = Console.ReadLine();

                        Console.WriteLine("Digite a cidade do Fornecedor: ");
                        fornecedor.CidadeFornecedor = Console.ReadLine();

                        Console.WriteLine("Digite o logradouro do Fornecedor: ");
                        fornecedor.LogradouroFornecedor = Console.ReadLine();

                        Console.WriteLine("Digite o número de endereço do Fornecedor: ");
                        fornecedor.NumeroEnderecoFornecedor = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o CNPJ do Fornecedor: ");
                        fornecedor.CnpjFornecedor = Console.ReadLine();

                        Console.WriteLine("Digite a Razão social do Fornecedor: ");
                        fornecedor.RazaoSocialFornecedor = Console.ReadLine();

                        fornecedorDAL.CadastrarFornecedor(fornecedor);

                        Console.WriteLine("Dados cadastrados!");


                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de Fornecedor {0}.  Erro:  " +
        "{1}", fornecedor.NomeFornecedor, ex.Message));
                        Console.ReadKey();
                    }


                    break;
                #endregion

                #region Cadastro de Insumo
                case 7:

                    BLL.Insumo insumo = new BLL.Insumo();
                    DAL.InsumoDAL insumoDAL = new DAL.InsumoDAL();

                    try
                    {
                        Console.WriteLine("Digite o nome do Insumo: ");
                        insumo.NomeInsumo = Console.ReadLine();

                        Console.WriteLine("Digite a data de validade do Insumo: ");
                        insumo.DataValidadeInsumo = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite o preço do Insumo: ");
                        insumo.PrecoInsumo = Convert.ToDouble(Console.ReadLine());

                        insumoDAL.CadastrarInsumo(insumo);

                        Console.WriteLine("Dados cadastrados!");

                        Console.ReadKey();
                        Console.Clear();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de Insumo {0}.  Erro:  " +
      "{1}", insumo.NomeInsumo, ex.Message));
                        Console.ReadKey();
                    }


                    break;
                #endregion

                #region Cadastro de Estoque de Insumo
                case 8:

                    BLL.EstoqueInsumo estoqueInsumo = new BLL.EstoqueInsumo();
                    DAL.EstoqueInsumoDAL estoqueInsumoDAL = new DAL.EstoqueInsumoDAL();

                    try
                    {

                        Console.WriteLine("Digite a quantidade de estoque do Insumo: ");
                        estoqueInsumo.QuantidadeEstoqueInsumo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o código do Insumo: ");
                        estoqueInsumo.CodInsumoEI = Convert.ToInt32(Console.ReadLine());

                        estoqueInsumoDAL.CadastrarEstoqueI(estoqueInsumo);

                        Console.WriteLine("Dados Cadastrados");

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro do Estoque de Insumo {0}.  Erro:  " +
      "{1}", estoqueInsumo.CodInsumoEI, ex.Message));

                        Console.ReadKey();
                    }


                    break;

                #endregion

                #region Cadastro de Estoque de Produto
                case 9:

                    BLL.EstoqueProduto estoqueProduto = new BLL.EstoqueProduto();
                    DAL.EstoqueProdutoDAL estoqueProdutoDAL = new DAL.EstoqueProdutoDAL();

                    try
                    {

                        Console.WriteLine("Digite a quantidade de estoque do Produto: ");
                        estoqueProduto.QuantidadeEstoqueProduto = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o código do Produto: ");
                        estoqueProduto.CodProdutoEP = Convert.ToInt32(Console.ReadLine());

                        estoqueProdutoDAL.CadastrarEstoqueP(estoqueProduto);

                        Console.WriteLine("Dados Cadastrados");

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro do Estoque de Produto {0}.  Erro:  " +
      "{1}", estoqueProduto.CodProdutoEP, ex.Message));

                        Console.ReadKey();
                    }


                    break;
                #endregion

                #region Cadastro de Compra

                case 10:

                    BLL.Compra compra = new BLL.Compra();
                    DAL.CompraDAL compraDAL = new DAL.CompraDAL();

                    try
                    {

                        Console.WriteLine("Digite a data e horario da Compra: ");
                        compra.DataHorarioCompra = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite a forma de pagamento: ");
                        compra.FormaPagamentoCompra = Console.ReadLine();

                        Console.WriteLine("Digite o código do Fornecedor: ");
                        compra.CodFornecedorC = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do Usuário: ");
                        compra.CodUsuarioC = Convert.ToInt16(Console.ReadLine());

                        compraDAL.CadastrarCompra(compra);

                        Console.WriteLine("Dados Cadastrados");

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de Compra {0}.  Erro:  " +
      "{1}", compra.CodCompra, ex.Message));

                        Console.ReadKey();
                    }

                    break;

                #endregion

                #region Cadastro de Venda
                case 11:


                    BLL.Venda venda = new BLL.Venda();
                    DAL.VendaDAL vendaDAL = new DAL.VendaDAL();


                    try
                    {

                        Console.WriteLine("Digite a data e horario da Venda: ");
                        venda.DataHorarioVenda = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite a forma de pagamento: ");
                        venda.FormaPagamentoVenda = Console.ReadLine();

                        Console.WriteLine("Digite o código do Usuário: ");
                        venda.CodUsuarioV = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do Cliente: ");
                        venda.CodClienteV = Convert.ToInt16(Console.ReadLine());

                        vendaDAL.CadastrarVenda(venda);

                        Console.WriteLine("Dados Cadastrados");

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de Venda {0}.  Erro:  " +
      "{1}", venda.CodVenda, ex.Message));

                        Console.ReadKey();
                    }


                    break;
                #endregion

                #region Cadastro de Itens Venda
                case 12:

                    BLL.ItensVenda itensVenda = new BLL.ItensVenda();
                    DAL.ItensVendaDAL itensVendaDAL = new DAL.ItensVendaDAL();

                    try
                    {

                        Console.WriteLine("Digite a quantidade de Itens na Venda: ");
                        itensVenda.QuantidadeItensVenda = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o valor Total: ");
                        itensVenda.ValorTotalItensVenda = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o código da Venda: ");
                        itensVenda.CodVendaIV = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do Produto: ");
                        itensVenda.CodProdutoIV = Convert.ToInt16(Console.ReadLine());

                        itensVendaDAL.CadastrarItensVenda(itensVenda);

                        Console.WriteLine("Dados Cadastrados");

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de Itens da Venda {0}.  Erro:  " +
      "{1}", itensVenda.CodItensVenda, ex.Message));

                        Console.ReadKey();
                    }

                    break;

                #endregion

                #region Cadastro de Itens Compra

                case 13:

                    BLL.ItensCompra itensCompra = new BLL.ItensCompra();
                    DAL.ItensCompraDAL itensCompraDAL = new DAL.ItensCompraDAL();

                    try
                    {

                        Console.WriteLine("Digite a quantidade de Itens na Compra: ");
                        itensCompra.QuantidadeItensCompra = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o valor Total: ");
                        itensCompra.ValorTotalItensCompra = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o código da Compra: ");
                        itensCompra.CodCompraIC = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do Insumo: ");
                        itensCompra.CodInsumoIC = Convert.ToInt16(Console.ReadLine());

                        itensCompraDAL.CadastrarItensCompra(itensCompra);

                        Console.WriteLine("Dados Cadastrados");

                        Console.ReadKey();
                        Console.Clear();

                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro de Itens da Compra {0}.  Erro:  " +
      "{1}", itensCompra.CodItensCompra, ex.Message));

                        Console.ReadKey();
                    }

                    break;

                #endregion

                #region Cadastro de Plantação

                case 14:

                    BLL.Plantacao plantacao = new BLL.Plantacao();
                    DAL.PlantacaoDAL plantacaoDAL = new DAL.PlantacaoDAL();

                    try
                    {

                        Console.WriteLine("Digite a data e o horário: ");
                        plantacao.DataHorarioPlantacao = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade: ");
                        plantacao.QuantidadePlantacao = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do insumo a ser plantado: ");
                        plantacao.CodInsumoP = Convert.ToInt16(Console.ReadLine());

                        plantacaoDAL.CadastrarPlantacao(plantacao);

                        Console.WriteLine("Dados cadastrados!");

                        Console.ReadKey();
                        Console.Clear();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro da Plantação {0}.  Erro:  " +
      "{1}", plantacao.CodPlantacao, ex.Message));
                        Console.ReadKey();
                    }



                    break;
                #endregion

                #region Cadastro de Colheita

                case 15:

                    BLL.Colheita colheita = new BLL.Colheita();
                    DAL.ColheitaDAL colheitaDAL = new DAL.ColheitaDAL();

                    try
                    {

                        Console.WriteLine("Digite a data e o horário: ");
                        colheita.DataHorarioColheita = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite a quantidade: ");
                        colheita.QuantidadeColheita = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do produto a ser colhido: ");
                        colheita.CodProdutoC = Convert.ToInt16(Console.ReadLine());

                        colheitaDAL.CadastrarColheita(colheita);

                        Console.WriteLine("Dados cadastrados!");

                        Console.ReadKey();
                        Console.Clear();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro da Colheita {0}.  Erro:  " +
      "{1}", colheita.CodColheita, ex.Message));
                        Console.ReadKey();
                    }



                    break;
                #endregion

                #region Cadastro de Entrega

                case 16:

                    BLL.Entrega entrega = new BLL.Entrega();
                    DAL.EntregaDAL entregaDAL = new DAL.EntregaDAL();

                    try
                    {
                        Console.WriteLine("Digite a quantidade: ");
                        entrega.QuantidadeEntrega = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o codigo da Venda: ");
                        entrega.CodVendaE = Convert.ToInt16(Console.ReadLine());

                        Console.WriteLine("Digite o código do Cliente: ");
                        entrega.CodClienteE = Convert.ToInt16(Console.ReadLine());

                        entregaDAL.CadastrarEntrega(entrega);

                        Console.WriteLine("Dados cadastrados!");

                        Console.ReadKey();
                        Console.Clear();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Erro ao executar cadastro da Plantação {0}.  Erro:  " +
      "{1}", entrega.CodEntrega, ex.Message));
                        Console.ReadKey();
                    }



                    break;
                    #endregion
            }

        }

        static void ConsultaUsuario ()
        {
            DAL.UsuarioDAL usuarioDAL = new DAL.UsuarioDAL();
            List<BLL.Usuario> usuarios = usuarioDAL.GetUsuarios(); 
            
            //Exibindo dados dos usuarios

            foreach (BLL.Usuario usuario in usuarios)
            {
                Console.WriteLine($"nomeUsuario: {usuario.NomeUsuario}, nivelAcesso: {usuario.NivelAcesso}, login: {usuario.Login}, senha: {usuario.Senha} ");
            }

        }

        static void ConsultaCliente()
        {
            DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
            List<BLL.Cliente> clientes = clienteDAL.GetClientes();

            //Exibindo dados dos usuarios

            foreach (BLL.Cliente cliente in clientes)
            {
                Console.WriteLine($"nomeCliente: {cliente.NomeCliente}, emailCliente: {cliente.EmailCliente}, ufCliente: {cliente.UFCliente}, cidadeCliente: {cliente.CidadeCliente}, telefoneCliente: {cliente.TelefoneCliente}, cepCliente: {cliente.CepCliente}, logradouroCliente: {cliente.LogradouroCliente}, numCliente: {cliente.NumCliente} ");
            }

        }








    }
}
