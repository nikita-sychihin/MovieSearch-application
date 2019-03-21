using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MovieSearchАpplication.Models;
using AppContext = MovieSearchАpplication.Models.AppContext;

namespace MovieSearchАpplication.Controllers
{
    public class HomeController : Controller
    {
        AppContext db = new AppContext();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string filterFilm)
        {
            ViewBag.filterFilm = filterFilm;
            return View();
        }

        public ActionResult SearchFilms(string filterFilm = null)
        {
            IEnumerable<Films> films = db.Film.ToList(); // ебать ты дэбил

            IEnumerable<Films> filteredFilms = films;

            if (filterFilm != null)
            {
                string searchString = filterFilm.ToLower();

            
                filteredFilms = films.Where(film => film.Name.ToLower().Contains(searchString) ||
                                                    film.Actors.Any(actor => actor.Name.ToLower().Contains(searchString)) ||
                                                    film.Genre.ToLower().Contains(searchString));
            }

            return View("SearchFilms", filteredFilms);
        }
    }
}   

