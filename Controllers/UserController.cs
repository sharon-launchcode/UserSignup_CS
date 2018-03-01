using Microsoft.AspNetCore.Mvc;

namespace user_signup.Controllers {
    public class UserController : Controller {
        // GET
        public IActionResult Index() {
            return
            View();
        }
    }
}