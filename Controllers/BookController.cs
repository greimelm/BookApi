using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController(IBookService service) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
            => Ok(await service.GetAllBooksAsync());

        [HttpGet("{id}")] //Route name
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await service.GetBookByIdAsync(id);
            return book is null ? NotFound("Book with given ID was not found") : Ok(book);
        }
    }
}
