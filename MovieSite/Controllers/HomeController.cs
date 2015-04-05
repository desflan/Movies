using System.Web.Mvc;
using MovieSite.Services.Interfaces;
using MovieSite.Web.Filters;

namespace MovieSite.Web.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IServices services) : base(services)
        {}

        [ProfileMe]
        public ActionResult Index()
        {
            var model = Services.MovieService.List();
            return View(model);
        }

    }
}
