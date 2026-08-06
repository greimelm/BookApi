using WebApi.Dtos;
using WebApi.Models;

namespace WebApi.Services
{
    public interface IBookService
    {
        Task<List<BookResponse>> GetAllBooksAsync();
        Task<BookResponse?> GetBookByIdAsync(int id);
        Task<BookResponse> AddBookAsync(Book book);
        Task<bool> UpdateBookAsync(int id, Book book);
        Task<bool> DeleteBookAsync(int id);
    }
}
