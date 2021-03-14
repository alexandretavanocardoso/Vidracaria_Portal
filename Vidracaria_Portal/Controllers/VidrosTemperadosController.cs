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
    public class VidrosTemperadosController : Controller
    {
        private readonly VidracariaContext _context;

        public VidrosTemperadosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: VidrosTemperados
        public async Task<IActionResult> Index()
        {
            return View(await _context.VidrosTemperados.ToListAsync());
        }

        // GET: VidrosTemperados/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidrosTemperadosModel = await _context.VidrosTemperados
                .FirstOrDefaultAsync(m => m.CodigoVidro == id);
            if (vidrosTemperadosModel == null)
            {
                return NotFound();
            }

            return View(vidrosTemperadosModel);
        }

        // GET: VidrosTemperados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VidrosTemperados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoVidro,NomeVidro,CorVidro,Marca,EstoqueMaximo,EstoqueMinimo,Expessura,PrecoVenda,PrecoFabrica,Imagem")] VidrosTemperadosModel vidrosTemperadosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vidrosTemperadosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vidrosTemperadosModel);
        }

        // GET: VidrosTemperados/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidrosTemperadosModel = await _context.VidrosTemperados.FindAsync(id);
            if (vidrosTemperadosModel == null)
            {
                return NotFound();
            }
            return View(vidrosTemperadosModel);
        }

        // POST: VidrosTemperados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoVidro,NomeVidro,CorVidro,Marca,EstoqueMaximo,EstoqueMinimo,Expessura,PrecoVenda,PrecoFabrica,Imagem")] VidrosTemperadosModel vidrosTemperadosModel)
        {
            if (id != vidrosTemperadosModel.CodigoVidro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vidrosTemperadosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VidrosTemperadosModelExists(vidrosTemperadosModel.CodigoVidro))
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
            return View(vidrosTemperadosModel);
        }

        // GET: VidrosTemperados/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidrosTemperadosModel = await _context.VidrosTemperados
                .FirstOrDefaultAsync(m => m.CodigoVidro == id);
            if (vidrosTemperadosModel == null)
            {
                return NotFound();
            }

            return View(vidrosTemperadosModel);
        }

        // POST: VidrosTemperados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var vidrosTemperadosModel = await _context.VidrosTemperados.FindAsync(id);
            _context.VidrosTemperados.Remove(vidrosTemperadosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VidrosTemperadosModelExists(decimal id)
        {
            return _context.VidrosTemperados.Any(e => e.CodigoVidro == id);
        }
    }
}