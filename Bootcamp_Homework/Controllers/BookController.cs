using Bootcamp_Homework.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_Homework.Controllers
{
    public class BookController : Controller
    {
        private BookRepository _repository = new BookRepository();

        public IActionResult Index()
        {
            var books = _repository.GetBooks();
            return View(books);
        }

        public IActionResult BookDetail(int id)
        {
            var book = _repository.GetBookById(id);
            if (book is null)
                return NotFound();
            return View(book);
        }
    }
}
