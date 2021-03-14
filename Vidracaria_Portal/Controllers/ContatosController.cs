using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Cliente;

namespace Vidracaria_Portal.Controllers
{
    public class ContatosController : Controller
    {
        private readonly VidracariaContext _context;

        public ContatosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Contatos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contatos.ToListAsync());
        }

        // GET: Contatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.Contatos
                .FirstOrDefaultAsync(m => m.CodigoContato == id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            return View(contatoModel);
        }

        // GET: Contatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoContato,Nome,Email,Assunto,Mensagem,Retorno,DataContato,DataRetorno")] ContatoModel contatoModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contatoModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contatoModel);
        }

        // GET: Contatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.Contatos.FindAsync(id);
            if (contatoModel == null)
            {
                return NotFound();
            }
            return View(contatoModel);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoContato,Nome,Email,Assunto,Mensagem,Retorno,DataContato,DataRetorno")] ContatoModel contatoModel)
        {
            if (id != contatoModel.CodigoContato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contatoModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContatoModelExists(contatoModel.CodigoContato))
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
            return View(contatoModel);
        }

        // GET: Contatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contatoModel = await _context.Contatos
                .FirstOrDefaultAsync(m => m.CodigoContato == id);
            if (contatoModel == null)
            {
                return NotFound();
            }

            return View(contatoModel);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contatoModel = await _context.Contatos.FindAsync(id);
            _context.Contatos.Remove(contatoModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContatoModelExists(int id)
        {
            return _context.Contatos.Any(e => e.CodigoContato == id);
        }
    }
}
