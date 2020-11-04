using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CadastroDeLivros.Data;
using CadastroDeLivros.Models;
using System.Linq;

namespace CadastroDeLivros.Controllers
{
    [ApiController]
    [Route("v1/livros")]
    public class LivroController : ControllerBase
    {
        // Get ALL

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Livros>>> Get([FromServices] DataContext context)
        {
            var categories = await context.Livros.ToListAsync();
            return categories;
        }

        // Get by ID
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Livros>> GetById([FromServices] DataContext context, int id)
        {
            var book = await context.Livros
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ID == id);
            return book;
        }

        // Get by title
        [HttpGet]
        [Route("{title}")]
        public async Task<ActionResult<Livros>> GetByTitle([FromServices] DataContext context, string title)
        {
            var book = await context.Livros
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Titulo == title);
            return book;
        }

        // Get by author
        [HttpGet]
        [Route("{author}")]
        public async Task<ActionResult<Livros>> GetByAuthor([FromServices] DataContext context, string Author)
        {
            var book = await context.Livros
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Autor == Author);
            return book;
        }

        // Delete by ID
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<string>> DeleteById([FromServices] DataContext context, int id)
        {
            var book = context.Livros.Where(b => b.ID == id).FirstOrDefault();
            context.Remove(book);
            await context.SaveChangesAsync();
            return Ok("Deletado com sucesso");
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Livros>> Post(
            [FromServices] DataContext context,
            [FromBody] Livros model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            context.Livros.Add(model);
            await context.SaveChangesAsync();
            return model;
        }
    }
}