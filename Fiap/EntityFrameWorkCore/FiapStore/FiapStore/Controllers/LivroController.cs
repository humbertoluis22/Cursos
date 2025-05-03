using Core.Entity;
using Core.Input;
using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    [Controller]
    [Route("/[controller]")]
    public class LivroController : Controller
    {
        private readonly ILivroRepository _livroRepository;
        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var livrosDto = new List<LivroDto>();
                var livros = _livroRepository.ObterTodos();

                foreach (var livro in livros)
                {
                    livrosDto.Add(new LivroDto()
                    {
                        Id = livro.Id,
                        DataCriacao = livro.DataCriacao,
                        Nome = livro.Nome,
                        Editora = livro.Editora,
                        Pedido = livro.Pedidos.Select(pedido => new Pedido()
                        {
                            ClienteId = pedido.ClienteId,
                            LivroId = pedido.LivroId,
                        }).ToList()
                    });
                }

               return Ok(livrosDto);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get([FromRoute]int id)
        {
            try
            {
                var livro = _livroRepository.obterPorId(id);
                if (livro == null)
                    return NotFound();
                return Ok(livro);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] LivroInput input)
        {
            try 
            {
                var livro = new Livro() 
                {
                    Nome = input.Nome,
                    Editora = input.Editora
                };

                _livroRepository.Cadastrar(livro);

                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] LivroUpdateInput input)
        {
            try
            {
                var livro = _livroRepository.obterPorId(input.Id);
                livro.Nome = input.Nome;
                livro.Editora = input.Editora;

                _livroRepository.Alterar(livro);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            try
            {
                _livroRepository.deletar(id);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpPost("cadastro-em-massa")]
        public IActionResult CadastroEmMassa()
        {
            try
            {

                var livros = new List<Livro>() 
                {
                    new Livro () { Nome = "Livro 1", Editora = "Editora 1", },
                    new Livro () { Nome = "Livro 2", Editora = "Editora 2", },
                    new Livro () { Nome = "Livro 3", Editora = "Editora 3", },
                    new Livro () { Nome = "Livro 4", Editora = "Editora 4", },
                    new Livro () { Nome = "Livro 5", Editora = "Editora 5", },
                    new Livro () { Nome = "Livro 6", Editora = "Editora 6", },
                    new Livro () { Nome = "Livro 7", Editora = "Editora 7", },
                    new Livro () { Nome = "Livro 8", Editora = "Editora 8", },
                    new Livro () { Nome = "Livro 9", Editora = "Editora 9", },
                    new Livro () { Nome = "Livro 10", Editora = "Editora 10" }

                };

                _livroRepository.CadastrarEmMassa(livros);
                return Ok();
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
    }
}
