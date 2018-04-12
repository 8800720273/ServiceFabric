using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldStateless.Controllers
{
    class HelloWorldExample
    {
        public  string Name { get; set; }
        public string LastName { get; set; }
    }
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        List<HelloWorldExample> list = new List<HelloWorldExample>();
        public IActionResult Index()
        {
           list.Add(new HelloWorldExample() { Name = "Bala", LastName = "Krishna" });
            list.Add(new HelloWorldExample() { Name = "yash", LastName = "want" });
            list.Add(new HelloWorldExample() { Name = "prince", LastName = "kumar" });
            return new JsonResult(list);
        }
    }
}
