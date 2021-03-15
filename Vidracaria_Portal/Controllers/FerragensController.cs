using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Cadastros;

namespace Vidracaria_Portal.Controllers
{
    public class FerragensController : Controller
    {
        private readonly VidracariaContext _context;

        public FerragensController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Ferragens
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ferragens.ToListAsync());
        }

        // GET: Ferragens/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferragensModel = await _context.Ferragens
                .FirstOrDefaultAsync(m => m.CodigoFerragem == id);
            if (ferragensModel == null)
            {
                return NotFound();
            }

            return View(ferragensModel);
        }

        // GET: Ferragens/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ferragens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoFerragem,NomeFerragem,CorId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] FerragensModel ferragensModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ferragensModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ferragensModel);
        }

        // GET: Ferragens/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferragensModel = await _context.Ferragens.FindAsync(id);
            if (ferragensModel == null)
            {
                return NotFound();
            }
            return View(ferragensModel);
        }

        // POST: Ferragens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoFerragem,NomeFerragem,CorId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] FerragensModel ferragensModel)
        {
            if (id != ferragensModel.CodigoFerragem)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ferragensModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FerragensModelExists(ferragensModel.CodigoFerragem))
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
            return View(ferragensModel);
        }

        // GET: Ferragens/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferragensModel = await _context.Ferragens
                .FirstOrDefaultAsync(m => m.CodigoFerragem == id);
            if (ferragensModel == null)
            {
                return NotFound();
            }

            return View(ferragensModel);
        }

        // POST: Ferragens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var ferragensModel = await _context.Ferragens.FindAsync(id);
            _context.Ferragens.Remove(ferragensModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FerragensModelExists(decimal id)
        {
            return _context.Ferragens.Any(e => e.CodigoFerragem == id);
        }
    }
}
