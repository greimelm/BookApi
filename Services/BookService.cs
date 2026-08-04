using WebApi.Models;

namespace WebApi.Services
{
    public class BookService : IBookService
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

        public async Task<List<Book>> GetAllBooksAsync()
            => await Task.FromResult(books);

        public async Task<Book?> GetBookByIdAsync(int id)
        {
            var result = books.FirstOrDefault(x => x.Id == id);
            return await Task.FromResult(result);
        }

        public Task<bool> UpdateBookAsync(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
