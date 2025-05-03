using Core.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FiapStore.Controllers
{
    [Controller]
    [Route("/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet("RecolherPedidosDoCLienteDeSeisMeses/{id:int}")]   
        public IActionResult RecolherPedidosDoCLienteDeSeisMeses([FromRoute ]int id)
        {
            try
            {
                return Ok(_clienteRepository.ObterPedidosSeisMeses(id));

            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
