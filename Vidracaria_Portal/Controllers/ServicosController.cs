using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
    public class ServicosController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ServicosController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Servicos
        public async Task<IActionResult> Index(int?pagina)
        {
            var servicos = from p in _context.ServicosModels select p;
            int itensPorPagina = 9;
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(await servicos.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Galeria/Create
        public IActionResult Create()
        {
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View();
        }

        // POST: Servicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoServico,NomeServico,Imagem")] ServicosModel servicosModel, IFormFile imagem)
        {
            if (ModelState.IsValid)
            {
                if (imagem != null)
                {
                    var pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Servicos");

                    var nomeArquivo = Guid.NewGuid() + "_" + imagem.FileName;

                    var caminho = Path.Combine(pasta, nomeArquivo);

                    using (var stream = new FileStream(caminho, FileMode.Create))
                    {
                        await imagem.CopyToAsync(stream);
                    }

                    servicosModel.Imagem = "imagensSaves/Servicos/" + nomeArquivo;
                }

                _context.Add(servicosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(servicosModel);
        }

        // GET: Servicos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicosModel = await _context.ServicosModels.FindAsync(id);
            if (servicosModel == null)
            {
                return NotFound();
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(servicosModel);
        }

        // POST: Servicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoServico,NomeServico,Imagem")] ServicosModel servicosModel, IFormFile novaImagem)
        {
            if (id != servicosModel.CodigoServico)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (novaImagem != null)
                {
                    var pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Servicos");

                    var nomeArquivo = Guid.NewGuid() + "_" + novaImagem.FileName;

                    var caminho = Path.Combine(pasta, nomeArquivo);

                    using (var stream = new FileStream(caminho, FileMode.Create))
                    {
                        await novaImagem.CopyToAsync(stream);
                    }

                    servicosModel.Imagem = "imagensSaves/Servicos/" + nomeArquivo;
                }

                try
                {
                    _context.Update(servicosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicosModelExists(servicosModel.CodigoServico))
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
            return View(servicosModel);
        }

        // GET: Servicos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicosModel = await _context.ServicosModels
                .FirstOrDefaultAsync(m => m.CodigoServico == id);
            if (servicosModel == null)
            {
                return NotFound();
            }

            return View(servicosModel);
        }

        // POST: Servicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var servicosModel = await _context.ServicosModels.FindAsync(id);
            _context.ServicosModels.Remove(servicosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServicosModelExists(int id)
        {
            return _context.ServicosModels.Any(e => e.CodigoServico == id);
        }
    }
}
