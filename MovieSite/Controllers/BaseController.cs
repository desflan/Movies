using System.Web.Mvc;
using MovieSite.Services.Interfaces;

namespace MovieSite.Web.Controllers
{
    public class BaseController : Controller
    {
        protected IServices Services;

        public BaseController(IServices services)
        {
            Services = services;
        }
    }
}
