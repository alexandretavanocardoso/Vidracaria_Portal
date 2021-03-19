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
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class ClientesController : Controller
    {
        private readonly VidracariaContext _context;

        public ClientesController(VidracariaContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index(string filtro, string pesquisa, int? pagina)
        {
            if (pesquisa != null)
            {
                pagina = 1;
            }
            else
            {
                pesquisa = filtro;
            }
            ViewData["Filtro"] = pesquisa;

            var Cliente = from p in _context.Clientes select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                Cliente = Cliente.Where(p => p.NomeCliente.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 15;
            return View(await Cliente.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientesModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.CodigoCliente == id);
            if (clientesModel == null)
            {
                return NotFound();
            }

            return View(clientesModel);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoCliente,NomeCliente,Email,CidadeCliente,Bairro,NumeroCasa,EstadoCliente,Celular,Documento,DataCadastro,Imagem")] ClientesModel clientesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientesModel);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientesModel = await _context.Clientes.FindAsync(id);
            if (clientesModel == null)
            {
                return NotFound();
            }
            return View(clientesModel);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("CodigoCliente,NomeCliente,Email,CidadeCliente,Bairro,NumeroCasa,EstadoCliente,Celular,Documento,DataCadastro,Imagem")] ClientesModel clientesModel)
        {
            if (id != clientesModel.CodigoCliente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesModelExists(clientesModel.CodigoCliente))
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
            return View(clientesModel);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientesModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.CodigoCliente == id);
            if (clientesModel == null)
            {
                return NotFound();
            }

            return View(clientesModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var clientesModel = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clientesModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientesModelExists(decimal id)
        {
            return _context.Clientes.Any(e => e.CodigoCliente == id);
        }
    }
}
