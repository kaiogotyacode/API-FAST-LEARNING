using APIFastLearning.Database;
using APIFastLearning.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIFastLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly DatabaseContext _context;
        public PessoaController(DatabaseContext banco)
        {
            _context = banco;
        }

        [Route("")]
        [HttpPost]
        public ActionResult Create(Pessoa pessoa)
        {

            if (pessoa != null && _context.Pessoas != null)
            {
                _context.Pessoas.Add(pessoa);
                _context.SaveChanges();
                return Ok(_context.Pessoas.Where(p => p == pessoa));
            }

            return BadRequest();    
        }

    }
}
