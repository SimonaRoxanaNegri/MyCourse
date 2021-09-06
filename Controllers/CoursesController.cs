using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Pagina Index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Pagina Detail, con il seguente id: {id}");
        }
    }
}