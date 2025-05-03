using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Livro:EntityBase
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public required string Nome{ get; set; }
        public required string Editora{ get; set; }
        
        public  virtual ICollection<Pedido> Pedidos { get; set; }

        public Livro()
        {
            DataCriacao = DateTime.Now; 
        }
    }
}
