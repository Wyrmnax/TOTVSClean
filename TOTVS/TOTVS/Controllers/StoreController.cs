using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TOTVS.Data;

namespace TOTVS.Controllers
{
    public class StoreController : Controller
    {
        private readonly TOTVSContext _context;

        public StoreController(TOTVSContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var genres = _context.Genres.ToList();
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = _context.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var album = _context.Albums
                .Include(x => x.Genre)
                .Include(x => x.Artist)
                .Where(x => x.AlbumId == id)
                .SingleOrDefault();

            return View(album);
        }
    }
}