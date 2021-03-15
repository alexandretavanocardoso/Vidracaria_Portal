﻿using System;
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
    public class VidrosComunsController : Controller
    {
        private readonly VidracariaContext _context;

        public VidrosComunsController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: VidrosComuns
        public async Task<IActionResult> Index()
        {
            return View(await _context.VidrosComuns.ToListAsync());
        }

        // GET: VidrosComuns/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidrosComunsModel = await _context.VidrosComuns
                .FirstOrDefaultAsync(m => m.CodigoVidro == id);
            if (vidrosComunsModel == null)
            {
                return NotFound();
            }

            return View(vidrosComunsModel);
        }

        // GET: VidrosComuns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VidrosComuns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoVidro,NomeVidro,AdesivoId,PeliculaId,CorId,ExpessuraId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] VidrosComunsModel vidrosComunsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vidrosComunsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vidrosComunsModel);
        }

        // GET: VidrosComuns/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidrosComunsModel = await _context.VidrosComuns.FindAsync(id);
            if (vidrosComunsModel == null)
            {
                return NotFound();
            }
            return View(vidrosComunsModel);
        }

        // POST: VidrosComuns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoVidro,NomeVidro,AdesivoId,PeliculaId,CorId,ExpessuraId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] VidrosComunsModel vidrosComunsModel)
        {
            if (id != vidrosComunsModel.CodigoVidro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vidrosComunsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VidrosComunsModelExists(vidrosComunsModel.CodigoVidro))
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
            return View(vidrosComunsModel);
        }

        // GET: VidrosComuns/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidrosComunsModel = await _context.VidrosComuns
                .FirstOrDefaultAsync(m => m.CodigoVidro == id);
            if (vidrosComunsModel == null)
            {
                return NotFound();
            }

            return View(vidrosComunsModel);
        }

        // POST: VidrosComuns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var vidrosComunsModel = await _context.VidrosComuns.FindAsync(id);
            _context.VidrosComuns.Remove(vidrosComunsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VidrosComunsModelExists(decimal id)
        {
            return _context.VidrosComuns.Any(e => e.CodigoVidro == id);
        }
    }
}
