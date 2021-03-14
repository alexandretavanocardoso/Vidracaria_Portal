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
    public class PendentesController : Controller
    {
        private readonly VidracariaContext _context;

        public PendentesController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Pendentes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pendentes.ToListAsync());
        }

        // GET: Pendentes/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pendentesModel = await _context.Pendentes
                .FirstOrDefaultAsync(m => m.CodigoPendentes == id);
            if (pendentesModel == null)
            {
                return NotFound();
            }

            return View(pendentesModel);
        }

        // GET: Pendentes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pendentes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoPendentes,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] PendentesModel pendentesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pendentesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pendentesModel);
        }

        // GET: Pendentes/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pendentesModel = await _context.Pendentes.FindAsync(id);
            if (pendentesModel == null)
            {
                return NotFound();
            }
            return View(pendentesModel);
        }

        // POST: Pendentes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoPendentes,Nome,DataCadastro,Cidade,Bairro,NumeroCasa,Estado,Celular,Imagem")] PendentesModel pendentesModel)
        {
            if (id != pendentesModel.CodigoPendentes)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pendentesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PendentesModelExists(pendentesModel.CodigoPendentes))
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
            return View(pendentesModel);
        }

        // GET: Pendentes/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pendentesModel = await _context.Pendentes
                .FirstOrDefaultAsync(m => m.CodigoPendentes == id);
            if (pendentesModel == null)
            {
                return NotFound();
            }

            return View(pendentesModel);
        }

        // POST: Pendentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var pendentesModel = await _context.Pendentes.FindAsync(id);
            _context.Pendentes.Remove(pendentesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PendentesModelExists(decimal id)
        {
            return _context.Pendentes.Any(e => e.CodigoPendentes == id);
        }
    }
}
