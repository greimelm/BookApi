using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Services
{
    public class BookService(AppDbContext _context) : IBookService
    {
        static List<Book> books = new List<Book> {
            new Book { Id = 1, Title = "Intermezzo", Author = "Sally Rooney", Genre = "Novel" },
            new Book { Id = 2, Title = "The Hundred Years' War On Palestine", Author = "Rashid Khalidi", Genre = "History" },
            new Book { Id = 3, Title = "The vegetarian", Author = "Han Kang", Genre = "Novel" },
            new Book { Id = 4, Title = "The vegetarian", Author = "Han Kang", Genre = "Novel" }
        };
        public Task<Book> AddBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookResponse>> GetAllBooksAsync()
            => await _context.Books.Select(b => new BookResponse
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author
            }).ToListAsync();

        public async Task<BookResponse?> GetBookByIdAsync(int id)
        {
            var result = await _context.Books
                .Where(b => b.Id == id)
                .Select(b => new BookResponse
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author
                })
                .FirstOrDefaultAsync();

            return result;
        }

        public Task<bool> UpdateBookAsync(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
