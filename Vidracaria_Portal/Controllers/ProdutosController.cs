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
    public class ProdutosController : Controller
    {
        private readonly VidracariaContext _context;

        public ProdutosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtosModel = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (produtosModel == null)
            {
                return NotFound();
            }

            return View(produtosModel);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nome,Cor,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem")] ProdutosModel produtosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(produtosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(produtosModel);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtosModel = await _context.Produtos.FindAsync(id);
            if (produtosModel == null)
            {
                return NotFound();
            }
            return View(produtosModel);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Codigo,Nome,Cor,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem")] ProdutosModel produtosModel)
        {
            if (id != produtosModel.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produtosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutosModelExists(produtosModel.Codigo))
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
            return View(produtosModel);
        }

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produtosModel = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (produtosModel == null)
            {
                return NotFound();
            }

            return View(produtosModel);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var produtosModel = await _context.Produtos.FindAsync(id);
            _context.Produtos.Remove(produtosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutosModelExists(decimal id)
        {
            return _context.Produtos.Any(e => e.Codigo == id);
        }
    }
}
