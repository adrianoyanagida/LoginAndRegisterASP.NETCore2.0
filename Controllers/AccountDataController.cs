using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginAndRegister.Controllers
{
    public class AccountDataController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AccountDataController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index(string name)
        {
            ViewBag.userName = _userManager.GetUserName(HttpContext.User);
            return View();
        }
    }
}
