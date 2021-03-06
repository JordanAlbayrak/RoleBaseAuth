using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoleBaseAuth.Controllers
{
    public class ManagerController : Controller
    {
        [Authorize(Roles="Manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
