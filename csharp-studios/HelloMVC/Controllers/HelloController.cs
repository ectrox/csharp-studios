using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string html = 
                        "<form method='post'>" +
                            "<input type='text' name='name'/>" +
                            "<select name='lang'>" +
                                "<option value='en'>English</option>" +
                                "<option value='fr'>French</option>" +
                                "<option value='heb'>Hebrew</option>" +
                                "<option value='sp'>Spanish</option>" +
                                "<option value='arb'>Arabic</option>" +
                            "</select>" +
                            "<input type='submit' value='Greet me!'/>" +
                        "</form>";

            return Content(html, "text/html");
        }
       
       
        public IActionResult CreateMessage(string name, string lang)
        {
            string greeting;

            if (lang == "en")
            {
                greeting = "Hello, " + name + "!";
            }
            else if (lang == "fr")
            {
                greeting = "Bonjour, " + name + "!";
            }
            else if (lang == "heb")
            {
                greeting = "Shalom," + name + "!";
            }
            else if (lang == "sp")
            {
                greeting = "Hola, " + name + "!";
            }
            else if (lang == "arb")
            {
                greeting = "Marhabaan, " + name + "!";
            }
            else
            {
                greeting = null;
            }

            return Content(greeting, "text/html");
        }

        [Route("/Hello/")]
        [HttpPost]
        public IActionResult Display(string name, string lang)
        {
            return CreateMessage(name, lang);
        }
        public IActionResult Goodbye()
        {
            return Content("Goodbye");
        }
    }
}
