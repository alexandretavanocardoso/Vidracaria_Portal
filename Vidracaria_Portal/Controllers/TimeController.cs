using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class TimeController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TimeController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Time
        public async Task<IActionResult> Index(int? pagina)
        {
            var servicos = from p in _context.TimesModels select p;
            int itensPorPagina = 9;
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(await servicos.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Time/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Time/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoTIme,NomeTime,Cargo,Imagem,LinkFacebook,LinkImagem")] TimeModel timeModel, IFormFile imagem)
        {
            if (ModelState.IsValid)
            {
                if(imagem != null)
                {
                    var pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Time");

                    var nome = Guid.NewGuid() + "_" + imagem.FileName;

                    var caminho = Path.Combine(pasta, nome);

                    using (var stream = new FileStream(caminho, FileMode.Create))
                    {
                        await imagem.CopyToAsync(stream);
                    }

                    timeModel.Imagem = "imagensSaves/Time/" + nome;
                }

                _context.Add(timeModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(timeModel);
        }

        // GET: Time/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeModel = await _context.TimesModels.FindAsync(id);
            if (timeModel == null)
            {
                return NotFound();
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(timeModel);
        }

        // POST: Time/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoTIme,NomeTime,Cargo,Imagem,LinkFacebook,LinkImagem")] TimeModel timeModel, IFormFile novaImagem)
        {
            if (id != timeModel.CodigoTIme)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (novaImagem != null)
                {
                    var pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Time");

                    var nome = Guid.NewGuid() + "_" + novaImagem.FileName;

                    var caminho = Path.Combine(pasta, nome);

                    using (var stream = new FileStream(caminho, FileMode.Create))
                    {
                        await novaImagem.CopyToAsync(stream);
                    }

                    timeModel.Imagem = "imagensSaves/Time/" + nome;
                }

                try
                {
                    _context.Update(timeModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TimeModelExists(timeModel.CodigoTIme))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(timeModel);
        }

        // GET: Time/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var timeModel = await _context.TimesModels
                .FirstOrDefaultAsync(m => m.CodigoTIme == id);
            if (timeModel == null)
            {
                return NotFound();
            }

            return View(timeModel);
        }

        // POST: Time/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var timeModel = await _context.TimesModels.FindAsync(id);
            _context.TimesModels.Remove(timeModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TimeModelExists(int id)
        {
            return _context.TimesModels.Any(e => e.CodigoTIme == id);
        }
    }
}
