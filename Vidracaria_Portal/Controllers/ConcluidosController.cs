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
    public class ConcluidosController : Controller
    {
        private readonly VidracariaContext _context;

        public ConcluidosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Concluidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Concluidos.ToListAsync());
        }

        // GET: Concluidos/Details/5
        public async Task<IActionResult> Details(decimal? id)
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

        // GET: Concluidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Concluidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoConcluido,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] ConcluidosModel concluidosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(concluidosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(concluidosModel);
        }

        // GET: Concluidos/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var concluidosModel = await _context.Concluidos.FindAsync(id);
            if (concluidosModel == null)
            {
                return NotFound();
            }
            return View(concluidosModel);
        }

        // POST: Concluidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoConcluido,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] ConcluidosModel concluidosModel)
        {
            if (id != concluidosModel.CodigoConcluido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(concluidosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConcluidosModelExists(concluidosModel.CodigoConcluido))
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
            return View(concluidosModel);
        }

        // GET: Concluidos/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
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
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var concluidosModel = await _context.Concluidos.FindAsync(id);
            _context.Concluidos.Remove(concluidosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConcluidosModelExists(decimal id)
        {
            return _context.Concluidos.Any(e => e.CodigoConcluido == id);
        }
    }
}
