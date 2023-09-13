using Microsoft.AspNetCore.Mvc;
using Register.Models;

namespace Register.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }

            return View(user);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
