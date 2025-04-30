using System.Runtime.InteropServices;
using E_CommerceAPI.Context;
using E_CommerceAPI.DTO;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;
using E_CommerceAPI.ServiceS;
using E_CommerceAPI.ViewModels;

namespace E_CommerceAPI.Repositorios;


    
        public class ClienteRepository : IClienteRepository
        {
            //Metodos que acessam o banco de dados 

            //Injetar o Context 
            //Injecao de Dependencia 

            //VARIAVEL PARA GUARDAR O CONTEXTO 
            private readonly EcommerceContext _context;

            //Ctor = Metodo Construtor 
            //Quando criar um objeto o que eu preciso ter?

            public ClienteRepository(EcommerceContext context)
            {
                _context = context;
            }

            public void Atualizar(int id, CadastrarClientesDto clienteNovo)
            {
                Cliente clienteEncontrado = _context.Clientes.Find(id);
                if (clienteEncontrado == null)
                {
            
                    throw new Exception();
                }
                clienteEncontrado.NomeCompleto = clienteNovo.NomeCompleto;
                clienteEncontrado.Email = clienteNovo.Email;
                clienteEncontrado.Telefone = clienteNovo.Telefone;
                clienteEncontrado.Endereco = clienteNovo.Endereco;
                clienteEncontrado.DataCadastro = clienteNovo.DataCadastro;

                _context.SaveChanges();
            }


            public List<Cliente> BuscarClientePorNome(string nome)
            {
                //Where traz todos que atendem uma condicao 
                var listaClientes = _context.Clientes.Where(c => c.NomeCompleto == nome).ToList();
                return listaClientes;  
            }

            /// <summary>
            /// Acesse o banco de dados e encontre o cliente com email e 
            /// senha fornecidos 
            /// </summary>
            /// <returns>cliente ou nulo</returns>returns>
            public Cliente? BuscarPorEmailSenha(string email, string senha)
            {
                    //Encontrar o cliente que possui o email e senha fornecidos
                    //Procuro pelo (Email se esta certo)
                    var clienteEncontrado = _context.Clientes.FirstOrDefault(c => c.Email == email);
                    if (clienteEncontrado == null)
                        return null;    
                       

                    //Verificar se a senha do usuario gera o mesmo Hash. Procuro a (senha se esta certa)
                    var passwordService = new PasswordService();   
                    var resultado = passwordService.VerificarSenha(clienteEncontrado, senha);   
                    
                    if (resultado == true) return clienteEncontrado;
                    return null;

            }

                public Cliente BuscarPorId(int id)
                {
                    //Qualquer metodo que vai me trazer apenas 1 cliente 
                    //First or Default
                    return _context.Clientes.FirstOrDefault(c => c.IdCliente == id);
                }
                 //DTO
                public void Cadastrar(CadastrarClientesDto clienteDto)
                {
                    var passwordService = new PasswordService();

                    Cliente cadastrarCliente = new Cliente
                    {
                        NomeCompleto = clienteDto.NomeCompleto,
                        Email = clienteDto.Email,
                        Telefone = clienteDto.Telefone,
                        Endereco = clienteDto.Endereco,
                        Senha = clienteDto.Senha,
                        DataCadastro = clienteDto.DataCadastro,
                    };
                        cadastrarCliente.Senha = passwordService.HashPassword(cadastrarCliente);
          
                            _context.Clientes.Add(cadastrarCliente);
                            _context.SaveChanges(); // Sempre colocar o SaveChanges quando for mudar algo no Banco de Dados
                }
     

            public void Deletar(int id)
            {
                var clienteEncontrado = _context.Clientes.FirstOrDefault(c => c.IdCliente == id); // Encontrar quem eu quero deletar

                //First Or Defauld - Pesquisar porqualquer campo 
                //Find - Pesquisa SOMENTE pela chave primaria (ID)

                //Caso eu nao encontre o cliente lanco um erro 
                if(clienteEncontrado == null)
                    {
                        throw new Exception("Cliente nao encontrado");
                    }
                //Removo o cliente
                _context.Clientes.Remove(clienteEncontrado);

                //Salvar alteracoes 
                _context.SaveChanges();
            }

            public List<ListarClienteViewModel> ListarTodos()
            {
                return _context.Clientes.Select(c => new ListarClienteViewModel
                {
                   IdCliente = c.IdCliente,
                   NomeCompleto= c.NomeCompleto,    
                   Email = c.Email,
                   Telefone = c.Telefone,
                   Endereco = c.Endereco
                })
                .ToList(); 
            }
        }
    