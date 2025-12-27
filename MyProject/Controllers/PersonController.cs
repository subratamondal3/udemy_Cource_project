using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class PersonController : Controller
    {
        [Route("person1")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                string error = string.Join("\n", ModelState.Values.SelectMany
                    (value => value.Errors).Select(error => error.ErrorMessage));
                return BadRequest(error);
            }
            return Content($"{person}");
        }       
    }
}
