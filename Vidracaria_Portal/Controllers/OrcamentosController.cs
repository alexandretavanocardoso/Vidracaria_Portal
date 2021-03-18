using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Servicos;

namespace Vidracaria_Portal.Controllers
{
    public class OrcamentosController : Controller
    {
        private readonly VidracariaContext _context;

        public OrcamentosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Orcamentos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orcamentos.ToListAsync());
        }

        // GET: Orcamentos/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamentosModel = await _context.Orcamentos
                .FirstOrDefaultAsync(m => m.CodigoOrcamento == id);
            if (orcamentosModel == null)
            {
                return NotFound();
            }

            return View(orcamentosModel);
        }

        // GET: Orcamentos/Create
        public IActionResult Create()
        {
            ViewData["TipoId"] = new SelectList(_context.Orcamentos, "CodigoTipo", "Tipo");
            return View();
        }

        // POST: Orcamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoOrcamento,Nome,Rua,NumeroCasa,Cidade,Bairro,Celular,Telefone,Estado,TipoId,DataCadastro,Imagem")] OrcamentosModel orcamentosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orcamentosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoId"] = new SelectList(_context.Orcamentos, "CodigoTipo", "Tipo", orcamentosModel.TipoId);
            return View(orcamentosModel);
        }

        // GET: Orcamentos/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamentosModel = await _context.Orcamentos.FindAsync(id);
            if (orcamentosModel == null)
            {
                return NotFound();
            }
            ViewData["TipoId"] = new SelectList(_context.Orcamentos, "CodigoTipo", "Tipo");
            return View(orcamentosModel);
        }

        // POST: Orcamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoOrcamento,Nome,Rua,NumeroCasa,Cidade,Bairro,Celular,Telefone,Estado,TipoId,DataCadastro,Imagem")] OrcamentosModel orcamentosModel)
        {
            if (id != orcamentosModel.CodigoOrcamento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orcamentosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrcamentosModelExists(orcamentosModel.CodigoOrcamento))
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
            ViewData["TipoId"] = new SelectList(_context.Orcamentos, "CodigoTipo", "Tipo", orcamentosModel.TipoId);
            return View(orcamentosModel);
        }

        // GET: Orcamentos/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamentosModel = await _context.Orcamentos
                .FirstOrDefaultAsync(m => m.CodigoOrcamento == id);
            if (orcamentosModel == null)
            {
                return NotFound();
            }

            return View(orcamentosModel);
        }

        // POST: Orcamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var orcamentosModel = await _context.Orcamentos.FindAsync(id);
            _context.Orcamentos.Remove(orcamentosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrcamentosModelExists(decimal id)
        {
            return _context.Orcamentos.Any(e => e.CodigoOrcamento == id);
        }
    }
}
