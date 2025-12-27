using Microsoft.AspNetCore.Mvc;
using MyProject.Models;
namespace MyProject.Controllers
{
    
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [Route("api/[controller]/[action]")]
        [Route("/")]
        public ContentResult Index()
        {
            return Content("<h1>Welcome </h1> <h4>Hello from index</h4>",
                "text/html");
        }
        [Route("api/[controller]/[action]")]
        public JsonResult Person()
        {
            Person person = new Person()
            {
                Id = 1,
                Name = "John",
                Age = 25
            };
            // return new JsonResult(person);
            return Json(person);
        }
        public string Contact()
        {
            return "Hello from Contact";
        }

        [Route("download")]
        public VirtualFileResult Download()
        {
            return File("/mong.pdf", "application/pdf");
        }
        [Route("download1")]
        public PhysicalFileResult Download1()
        {
            return PhysicalFile(@"C:\Users\subrata mondal\Downloads\asp.net.interview.pdf", "application/pdf");
        }
        [Route("download2")]
        public FileContentResult Download2()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\subrata mondal\Downloads\asp.net.interview.pdf");
            return File(fileBytes, "application/pdf");
        }

    }
}
