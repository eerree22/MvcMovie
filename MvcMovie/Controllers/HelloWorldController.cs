using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int times =1)
        {
            ViewData["Message"] = "你好! "+name+"先生/女士";
            ViewData["times"]= times;

            return View();

            //return HtmlEncoder.Default.Encode("name = " + name + " ,ID = "+ ID);
            ////用 HtmlEncoder.Default.Encode 來防止惡意的input
        }
    }
}
