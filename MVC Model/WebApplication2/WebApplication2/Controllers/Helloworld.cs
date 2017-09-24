using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Text.Encodings.Web;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    public class Helloworld : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
            //return "This is my default action...";
        }
        public IActionResult Welcome(string name, int numTimes=1)
        {
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
            // return "This is the Welcome action method...";
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
