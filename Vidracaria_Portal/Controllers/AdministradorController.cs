using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
