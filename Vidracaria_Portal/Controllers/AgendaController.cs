using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Cadastros;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AgendaController : Controller
    {
        private readonly VidracariaContext _context;

        public AgendaController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Agenda
        public async Task<IActionResult> Index()
        {
            return View(await _context.AgendaModels.ToListAsync());
        }

        // GET: Agenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendaModel = await _context.AgendaModels
                .FirstOrDefaultAsync(m => m.CodigoAgenda == id);
            if (agendaModel == null)
            {
                return NotFound();
            }

            return View(agendaModel);
        }

        // GET: Agenda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoAgenda,Texto,Assunto,DataCadastro,DataLimite")] AgendaModel agendaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(agendaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(agendaModel);
        }

        // GET: Agenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendaModel = await _context.AgendaModels.FindAsync(id);
            if (agendaModel == null)
            {
                return NotFound();
            }
            return View(agendaModel);
        }

        // POST: Agenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoAgenda,Texto,Assunto,DataCadastro,DataLimite")] AgendaModel agendaModel)
        {
            if (id != agendaModel.CodigoAgenda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agendaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgendaModelExists(agendaModel.CodigoAgenda))
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
            return View(agendaModel);
        }

        // GET: Agenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agendaModel = await _context.AgendaModels
                .FirstOrDefaultAsync(m => m.CodigoAgenda == id);
            if (agendaModel == null)
            {
                return NotFound();
            }

            return View(agendaModel);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agendaModel = await _context.AgendaModels.FindAsync(id);
            _context.AgendaModels.Remove(agendaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AgendaModelExists(int id)
        {
            return _context.AgendaModels.Any(e => e.CodigoAgenda == id);
        }
    }
}
