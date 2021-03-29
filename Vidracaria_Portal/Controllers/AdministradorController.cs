using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Data.Context;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class AdministradorController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly VidracariaContext _context;

        public AdministradorController(ILogger<HomeController> logger,
                              VidracariaContext context,
                              IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Home()
        {
            var estoqueAluminio = from p in _context.Aluminios.Where(e => e.EstoqueMaximo <= e.EstoqueMinimo).ToList() select p;
            var estoqueAVidroTemperado = from p in _context.VidrosTemperados.Where(e => e.EstoqueMaximo <= e.EstoqueMinimo).ToList() select p;
            var estoqueVidroComum = from p in _context.VidrosComuns.Where(e => e.EstoqueMaximo <= e.EstoqueMinimo).ToList() select p;
            var estoqueFerragens = from p in _context.Ferragens.Where(e => e.EstoqueMaximo <= e.EstoqueMinimo).ToList() select p;
            return View();
        }
    }
}
