using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using winelegend.web.Services;

namespace winelegend.web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService roleService;
        public RoleController(IRoleService _roleService)
        {
            this.roleService = _roleService;
        }
        // GET: Role
        public async Task<ActionResult> Index()
        {
            var roleLists = await roleService.Get();
            return View(roleLists);
        }
    }
}