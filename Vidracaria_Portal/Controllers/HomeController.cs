using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using Vidracaria_Portal.Models.Cliente;
using Vidracaria_Portal.Services;
using Vidracaria_Portal.ViewModel;

namespace Vidracaria_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        private readonly VidracariaContext _context;

        public HomeController(ILogger<HomeController> logger,
                              VidracariaContext context,
                              IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Home()
        {
            var model = new HomeViewModel();
            model.Contato = new ContatoModel();
            return View(model);
        }

        public IActionResult Duvidas()
        {
            return View();
        }
        public IActionResult Contato()
        {
            var model = new HomeViewModel();
            model.Contato = new ContatoModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contatos(ContatoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var contatoBanco = new ContatoModel()
                {
                    Nome = model.Contato.Nome,
                    Email = model.Contato.Email,
                    Assunto = model.Contato.Assunto,
                    Mensagem = model.Contato.Mensagem,
                    DataContato = DateTime.Now,
                };

                _context.Add(contatoBanco);
                await _context.SaveChangesAsync();

                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Galeria()
        {
            List<GaleriaModel> list = new List<GaleriaModel>();
            var g = _context.GaleriaModels.ToList();

            foreach (var item in g)
            {
                GaleriaModel gal = new GaleriaModel();
                gal.CodigoGaleria = item.CodigoGaleria;
                gal.Imagem = item.Imagem;
                list.Add(gal);
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(list);
        }

        public IActionResult Servicos()
        {
            List<ServicosModel> listaServicos = new List<ServicosModel>();
            var s = _context.ServicosModels.ToList();

            foreach(var item in s)
            {
                ServicosModel ser = new ServicosModel();
                ser.CodigoServico = item.CodigoServico;
                ser.NomeServico = item.NomeServico;
                ser.Imagem = item.Imagem;
                listaServicos.Add(ser);
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(listaServicos);
        }

        public IActionResult Sobre()
        {
            List<TimeModel> list = new List<TimeModel>();
            var t = _context.TimesModels.ToList();

            foreach (var item in t)
            {
                TimeModel time = new TimeModel();
                time.CodigoTIme = item.CodigoTIme;
                time.Imagem = item.Imagem;
                time.NomeTime = item.NomeTime;
                time.Cargo = item.Cargo;
                time.LinkFacebook = item.LinkFacebook;
                time.LinkImagem = item.LinkImagem;
                list.Add(time);
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
