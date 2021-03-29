using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class FerragensController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FerragensController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Ferragens
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

            var Ferragens = from p in _context.Ferragens select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                Ferragens = Ferragens.Where(p => p.NomeFerragem.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 25;
            return View(await Ferragens.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Ferragens/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferragensModel = await _context.Ferragens
                .FirstOrDefaultAsync(m => m.CodigoFerragem == id);
            if (ferragensModel == null)
            {
                return NotFound();
            }

            return View(ferragensModel);
        }

        // GET: Ferragens/Create
        public IActionResult Create()
        {
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor");
            return View();
        }

        // POST: Ferragens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoFerragem,NomeFerragem,CorId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] FerragensModel ferragensModel, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                if (Imagem != null)
                {
                    // Definir pasta onde vai ser salvo
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Ferragens");

                    //Nome unico
                    var NomeArquivo = Guid.NewGuid().ToString() + "_" + Imagem.FileName; // nome da imagem e extensão

                    //Caminho Arquivo
                    var CaminhoArquivo = Path.Combine(pasta, NomeArquivo);

                    //Biblioteca - Criar e salvar aqreuivos em HD
                    using (var stream = new FileStream(CaminhoArquivo, FileMode.Create)) // Cria o Arquivo e copia a imagem que chegou do form
                    {
                        await Imagem.CopyToAsync(stream);
                    }
                    // Localizaçao e nome imagem
                    ferragensModel.Imagem = "imagensSaves/Ferragens" + NomeArquivo;

                }

                _context.Add(ferragensModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor", ferragensModel.CorId);
            return View(ferragensModel);
        }

        // GET: Ferragens/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferragensModel = await _context.Ferragens.FindAsync(id);
            if (ferragensModel == null)
            {
                return NotFound();
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["CorId"] = new SelectList(_context.Cores, "CodigoCor", "NomeCor");
            return View(ferragensModel);
        }

        // POST: Ferragens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoFerragem,NomeFerragem,CorId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] FerragensModel ferragensModel, IFormFile NovaImagem)
        {
            if (id != ferragensModel.CodigoFerragem)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (NovaImagem != null)
                    {
                        // Definir pasta onde vai ser salvo
                        string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Ferragens");

                        //Nome unico
                        var NomeArquivo = Guid.NewGuid().ToString() + "_" + NovaImagem.FileName; // nome da imagem e extensão

                        //Caminho Arquivo
                        var CaminhoArquivo = Path.Combine(pasta, NomeArquivo);

                        //Biblioteca - Criar e salvar aqreuivos em HD
                        using (var stream = new FileStream(CaminhoArquivo, FileMode.Create)) // Cria o Arquivo e copia a imagem que chegou do form
                        {
                            await NovaImagem.CopyToAsync(stream);
                        }
                        // Localizaçao e nome imagem
                        ferragensModel.Imagem = "imagensSaves/Ferragens" + NomeArquivo;
                    }

                    _context.Update(ferragensModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FerragensModelExists(ferragensModel.CodigoFerragem))
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
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["CorId"] = new SelectList(_context.Cores, "Id", "Nome", ferragensModel.CorId);
            return View(ferragensModel);
        }

        // GET: Ferragens/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ferragensModel = await _context.Ferragens
                .FirstOrDefaultAsync(m => m.CodigoFerragem == id);
            if (ferragensModel == null)
            {
                return NotFound();
            }

            return View(ferragensModel);
        }

        // POST: Ferragens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ferragensModel = await _context.Ferragens.FindAsync(id);
            _context.Ferragens.Remove(ferragensModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FerragensModelExists(int id)
        {
            return _context.Ferragens.Any(e => e.CodigoFerragem == id);
        }
    }
}
