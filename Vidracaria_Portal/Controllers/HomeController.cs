using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models;
using Vidracaria_Portal.Models.Cliente;
using Vidracaria_Portal.Services;
using Vidracaria_Portal.ViewModel;

namespace Vidracaria_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly VidracariaContext _context;

        public HomeController(ILogger<HomeController> logger, 
                              VidracariaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Duvidas()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Contatos(ContatoViewModel model)
        {
            if (ModelState.IsValid)
            {

                var envioDeEmail = new EmailSender();
                string mensagem = String.Format("Nome: {0}, Email: {1}, Assunto: {2}, Mesagem: {3}", model.Contato.Nome, model.Contato.Email, model.Contato.Assunto, model.Contato.Mensagem);

                await envioDeEmail.Mail("AlexandreTavanoDeveloper@outlook.com", model.Contato.Email, "Contato Vidraça", mensagem);

                // Obejto que grava o contato no banco
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
                return Json(new { success = true, message = "Enviado com Sucesso !" });
            } else
            {
                return Json(new { success = false, message = "Falha ao enviar!" });
            }
        }

        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
