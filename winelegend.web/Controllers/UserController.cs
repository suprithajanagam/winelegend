using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using winelegend.web.Services;

namespace winelegend.web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            this.userService = _userService;
        }
        // GET: User
        public async Task<ActionResult>  Index()
        {
            var userslist = await userService.Get();
            return View();
        }
    }
}