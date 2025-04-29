using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Cliente:EntityBase
    {
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
