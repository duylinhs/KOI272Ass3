using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.IO;
using System.Web;
namespace Ass3A.Controllers
{
    public class Seminar : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
