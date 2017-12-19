using System.Linq;
using System.Net;
using System.Web.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    [ValidateInput(false)]
    public class FilmController : Controller
    {
        private IMDBDbContext database = new IMDBDbContext();

        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {

            var films = database.Films.ToList();
            return View(films);

        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new Film());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Film film)
        {
            if (ModelState.IsValid)
            {
                database.Films.Add(film);
                database.SaveChanges();
                return Redirect("/");
            }
            return View(film);
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            var film = database.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }

            return View(film);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Film filmModel)
        {
            var filmFromDataBase = database.Films.Find(id);
            if (filmFromDataBase == null)
            {
                return HttpNotFound();
            }
            if (ModelState.IsValid)
            {
                filmFromDataBase.Name = filmModel.Name;
                filmFromDataBase.Genre = filmModel.Genre;
                filmFromDataBase.Director = filmModel.Director;
                filmFromDataBase.Year = filmModel.Year;

                database.SaveChanges();

                return Redirect("/");
            }
            return View("Edit", filmModel);
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            var film = database.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }

            return View(film);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id)
        {
            var filmFromDataBase = database.Films.Find(id);
            if (filmFromDataBase == null)
            {
                return HttpNotFound();
            }

            database.Films.Remove(filmFromDataBase);
            database.SaveChanges();

            return Redirect("/");
        }
    }
}