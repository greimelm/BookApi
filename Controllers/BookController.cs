using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        static List<Book> books = new List<Book> {
            new Book { Id = 1, Title = "Intermezzo", Author = "Sally Rooney", Genre = "Novel" },
            new Book { Id = 2, Title = "The Hundred Years' War On Palestine", Author = "Rashid Khalidi", Genre = "History" },
            new Book { Id = 3, Title = "The vegetarian", Author = "Han Kang", Genre = "Novel" }
        };

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
            => await Task.FromResult(Ok(books));
    }
}
