using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class BookController : Controller
    {
        [Route("book/{bookid}/{a}")]
        public IActionResult Index(int bookid,int a,Book book)
        {
            return Content($"book id: {bookid},a: {a}");
        }
    } 
}
