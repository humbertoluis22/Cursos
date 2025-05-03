using Core.Entity;
using Core.Input;
using Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ClienteDto ObterPedidosSeisMeses(int id)
        {
            var cliente = _context.Cliente
                     .FirstOrDefault(c => c.Id == id)
                     ?? throw new Exception("Esse cliente não existe");

            //lazy loading
            return new ClienteDto()
            {
                Id = cliente.Id,
                DataCriacao = cliente.DataCriacao,
                Nome = cliente.Nome,
                CPF = cliente.CPF,
                DataNascimento = cliente.DataNascimento,
                Pedidos = cliente.Pedidos.Where(p => p.DataCriacao >= DateTime.Now.AddMonths(-6))
                .Select(p => new PedidoDto()
                {
                    Id = p.Id,
                    DataCriacao = p.DataCriacao,
                    LivroId = p.LivroId,
                    ClienteId = p.ClienteId,
                    Livro = new LivroDto() 
                    {
                        Id = p.Livro.Id,
                        Nome = p.Livro.Nome,
                        Editora = p.Livro.Editora,
                        DataCriacao = p.Livro.DataCriacao,
                    },
                }).ToList()
            };


            //cliente.Pedidos = cliente.Pedidos
            //    .Where(p => p.DataCriacao >= DateTime.Now.AddMonths(-6))
            //    .Select(p =>
            //    {
            //        p.Cliente = null; // Remove a referência ao cliente
            //        p.Livro.Pedidos = null; // Remove a referência aos pedidos do livro
            //        return p;
            //    })
            //    .ToList();

            //return cliente; 
        }

        
    }
   
}
