using Core.Entity;

namespace Core.Input
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }

        public required string CPF { get; set; }
        public virtual ICollection<PedidoDto> Pedidos { get; set; }
    }
}
