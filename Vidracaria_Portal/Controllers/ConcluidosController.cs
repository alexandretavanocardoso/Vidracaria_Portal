using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Servicos;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class ConcluidosController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ConcluidosController(VidracariaContext context,
                                   IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Concluidos
        public async Task<IActionResult> Index(ConcluidosModel concluidosModel, string filtro, string pesquisa, int? pagina)
        {
            if (ModelState.IsValid)
            {
                if (concluidosModel.CodigoAprovados != 0)
                {
                    var codigoConcluido = (from p in _context.Concluidos select p).ToList();
                    concluidosModel.CodigoConcluido = codigoConcluido.Count() + 1;

                    _context.Add(concluidosModel);
                    await _context.SaveChangesAsync();
                }
            }

            if (pesquisa != null)
            {
                pagina = 1;
            }
            else
            {
                pesquisa = filtro;
            }

            ViewData["Filtro"] = pesquisa;
            var concluido = from p in _context.Concluidos select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                concluido = concluido.Where(p => p.Nome.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 25;

            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo");

            return View(await concluido.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Concluidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concluidosModel = await _context.Concluidos
                .FirstOrDefaultAsync(m => m.CodigoConcluido == id);
            if (concluidosModel == null)
            {
                return NotFound();
            }

            return View(concluidosModel);
        }

        // POST: Concluidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var concluidosModel = await _context.Concluidos.FindAsync(id);
            _context.Concluidos.Remove(concluidosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcluidosModelExists(int id)
        {
            return _context.Concluidos.Any(e => e.CodigoConcluido == id);
        }
    }
}
