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
    public class AprovadosController : Controller
    {
        private readonly VidracariaContext _context;

        public AprovadosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Aprovados
        public async Task<IActionResult> Index()
        {
            return View(await _context.Aprovados.ToListAsync());
        }

        // GET: Aprovados/Details/5
        public async Task<IActionResult> Details(decimal? id)
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

        // GET: Aprovados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Aprovados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoAprovado,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] AprovadosModel aprovadosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aprovadosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aprovadosModel);
        }

        // GET: Aprovados/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
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
            return View(aprovadosModel);
        }

        // POST: Aprovados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoAprovado,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] AprovadosModel aprovadosModel)
        {
            if (id != aprovadosModel.CodigoAprovado)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
            return View(aprovadosModel);
        }

        // GET: Aprovados/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
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
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var aprovadosModel = await _context.Aprovados.FindAsync(id);
            _context.Aprovados.Remove(aprovadosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AprovadosModelExists(decimal id)
        {
            return _context.Aprovados.Any(e => e.CodigoAprovado == id);
        }
    }
}
