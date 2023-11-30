using BookStore.Models;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        public BookController(ApplicationDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            List<Book> books = _dbContext.Books.ToList();
            return View(books);
        }
		public IActionResult CreateUpdate(int? id)
		{
			Book book = new Book();
			if (id == null||id==0) {
                //Create
                return View(book);
            }
			else
			{
				//Update
				book = _dbContext.Books.Find(id);
				return View(book);
			}

		}
		[HttpPost]
		public IActionResult CreateUpdate(Book book)
		{

			if (ModelState.IsValid)
			{
				if (book.Id == 0)
				{
                    _dbContext.Books.Add(book);
                    TempData["success"] = "Book Created successfully";
                }
				else
				{
                    _dbContext.Books.Update(book);
                    TempData["success"] = "Book Updated successfully";
                }

				_dbContext.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Book? book = _dbContext.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
            TempData["success"] = "Book Deleted successfully";
            return RedirectToAction("Index");
        }
    }
}