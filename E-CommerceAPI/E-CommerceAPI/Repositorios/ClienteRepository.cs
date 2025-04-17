using E_CommerceAPI.Context;
using E_CommerceAPI.Interfaces;
using E_CommerceAPI.Models;

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

    public void Atualizar(int id, Cliente cliente)
    {
        Cliente clienteEncontrado = _context.Clientes.Find(id);
        if (clienteEncontrado == null)
        {

            throw new Exception();
        }
        clienteEncontrado.NomeCompleto = cliente.NomeCompleto;
        clienteEncontrado.Email = cliente.Email;
        clienteEncontrado.Telefone = cliente.Telefone;
        clienteEncontrado.Endereco = cliente.Endereco;
        clienteEncontrado.DataCadastro = cliente.DataCadastro;

        _context.SaveChanges();
    }

    public Cliente BuscarPorEmailSenha(string email, string senha)
    {
        throw new NotImplementedException();
    }

    public Cliente BuscarPorId(int id)
            {
                throw new NotImplementedException();
            }

            public void Cadastrar(Cliente Cliente)
            {
                _context.Clientes.Add(Cliente);
        _context.SaveChanges(); // Sempre colocar o SaveChanges quando for mudar algo no Banco de Dados
    }

            public void Deletar(int id)
            {
                throw new NotImplementedException();
            }

            public List<Cliente> ListarTodos()
            {
                return _context.Clientes.ToList();
            }
        }
    


