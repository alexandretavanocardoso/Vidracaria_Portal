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
using Vidracaria_Portal.Models.Administrador.Servicos;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    public class AprovadosController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AprovadosController(VidracariaContext context,
                                   IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ActionResult> ConcluirOrcamento(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aprovadosModel = await _context.Aprovados.FindAsync(id);
            if (aprovadosModel == null)
            {
                return NotFound();
            }

            _context.Aprovados.Remove(aprovadosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Concluidos", aprovadosModel);
        }

        // GET: Aprovados
        public async Task<ActionResult> Index(AprovadosModel aprovadosModel, string filtro, string pesquisa, int? pagina)
        {
            if (ModelState.IsValid)
            {
                var codigoAprovado = (from p in _context.Aprovados select p).ToList();
                aprovadosModel.CodigoAprovado = codigoAprovado.Count() + 1;

                _context.Add(aprovadosModel);
                await _context.SaveChangesAsync();
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
            var aprovados = from p in _context.Aprovados select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                aprovados = aprovados.Where(p => p.Nome.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 25;

            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo");

            return View(await aprovados.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Aprovados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aprovadosModel = await _context.Aprovados.FindAsync(id);
            if (aprovadosModel == null)
            {
                return NotFound();
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(aprovadosModel);
        }

        // POST: Aprovados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoAprovado,CodigoOrcamento,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] AprovadosModel aprovadosModel, IFormFile NovaImagem)
        {
            if (id != aprovadosModel.CodigoAprovado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (NovaImagem != null)
                {
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Aprovados");

                    var nomeArquivo = Guid.NewGuid() + "_" + NovaImagem.FileName;

                    var CaminhoArquivo = Path.Combine(pasta, nomeArquivo);

                    using (var stream = new FileStream(CaminhoArquivo, FileMode.Create))
                    {
                        await NovaImagem.CopyToAsync(stream);
                    }

                    aprovadosModel.Imagem = "imagensSaves/Aprovados" + nomeArquivo;
                }

                try
                {
                    _context.Update(aprovadosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AprovadosModelExists(aprovadosModel.CodigoAprovado))
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
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo", aprovadosModel.TipoId);
            return View(aprovadosModel);
        }

        // GET: Aprovados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aprovadosModel = await _context.Aprovados
                .FirstOrDefaultAsync(m => m.CodigoAprovado == id);
            if (aprovadosModel == null)
            {
                return NotFound();
            }

            return View(aprovadosModel);
        }

        // POST: Aprovados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aprovadosModel = await _context.Aprovados.FindAsync(id);
            _context.Aprovados.Remove(aprovadosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AprovadosModelExists(int id)
        {
            return _context.Aprovados.Any(e => e.CodigoAprovado == id);
        }
    }
}
