using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Livro:EntityBase
    {
        public string Nome{ get; set; }
        public string Editora{ get; set; }
        
        public ICollection<Pedido> Pedidos { get; set; } 
    }
}
