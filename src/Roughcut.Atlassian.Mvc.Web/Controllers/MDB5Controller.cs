using Microsoft.AspNetCore.Mvc;

namespace Roughcut.Atlassian.Mvc.Web.Controllers
{
    public class MDB5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
