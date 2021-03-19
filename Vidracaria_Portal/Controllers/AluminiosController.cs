﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class AluminiosController : Controller
    {
        private readonly VidracariaContext _context;

        public AluminiosController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Aluminios
        public async Task<IActionResult> Index(string filtro, string pesquisa, int? pagina)
        {
            if(pesquisa != null)
            {
                pagina = 1;
            } else
            {
                pesquisa = filtro;
            }
            ViewData["Filtro"] = pesquisa;

            var Aluminio = from p in _context.Aluminios select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                Aluminio = Aluminio.Where(p => p.NomeAluminio.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 15;
            return View(await Aluminio.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Aluminios/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluminiosModel = await _context.Aluminios
                .FirstOrDefaultAsync(m => m.CodigoAluminio == id);
            if (aluminiosModel == null)
            {
                return NotFound();
            }

            return View(aluminiosModel);
        }

        // GET: Aluminios/Create
        public IActionResult Create()
        {
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor");
            return View();
        }

        // POST: Aluminios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoAluminio,NomeAluminio,CorId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] AluminiosModel aluminiosModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluminiosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor", aluminiosModel.CorId);
            return View(aluminiosModel);
        }

        // GET: Aluminios/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluminiosModel = await _context.Aluminios.FindAsync(id);
            if (aluminiosModel == null)
            {
                return NotFound();
            }
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor");
            return View(aluminiosModel);
        }

        // POST: Aluminios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoAluminio,NomeAluminio,CorId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] AluminiosModel aluminiosModel)
        {
            if (id != aluminiosModel.CodigoAluminio)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluminiosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AluminiosModelExists(aluminiosModel.CodigoAluminio))
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
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor", aluminiosModel.CorId);
            return View(aluminiosModel);
        }

        // GET: Aluminios/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluminiosModel = await _context.Aluminios
                .FirstOrDefaultAsync(m => m.CodigoAluminio == id);
            if (aluminiosModel == null)
            {
                return NotFound();
            }

            return View(aluminiosModel);
        }

        // POST: Aluminios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var aluminiosModel = await _context.Aluminios.FindAsync(id);
            _context.Aluminios.Remove(aluminiosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AluminiosModelExists(decimal id)
        {
            return _context.Aluminios.Any(e => e.CodigoAluminio == id);
        }
    }
}
