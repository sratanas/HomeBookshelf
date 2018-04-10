using HomeBookshelf.Data;
using HomeBookshelf.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace HomeBookshelf.Web.Controllers
{
    public class BooksController : Controller
    {



        private IBooksRepository repository;

        public BooksController()
        {
            this.repository = new BooksRepository(new DBConnection());
        }
        // GET: Books
        [HttpGet]
        public ActionResult Index()
        {
            //IBooksRepository repository;
            BooksModel booksModel = new BooksModel();
            booksModel.Books = repository.GetBooks();

            return View(booksModel);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
