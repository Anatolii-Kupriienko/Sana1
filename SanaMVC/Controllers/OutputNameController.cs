using Microsoft.AspNetCore.Mvc;
using SanaMVC.Models;

namespace SanaMVC.Controllers
{
    public class OutputNameController : Controller
    {
        public IActionResult Index(UserViewModel user)
        {
            return View(user);
        }
    }
}
