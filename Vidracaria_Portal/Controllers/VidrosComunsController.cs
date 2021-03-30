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
    public class VidrosComunsController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VidrosComunsController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: VidrosComuns
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

            var VidroComuns = from p in _context.VidrosComuns select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                VidroComuns = VidroComuns.Where(p => p.NomeVidro.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 25;
            return View(await VidroComuns.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: VidrosComuns/Details/5
        public async Task<IActionResult> Details(int? id)
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
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome");
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura");
            return View();
        }

        // POST: VidrosComuns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoVidro,NomeVidro,AdesivoId,PeliculaId,ExpessuraId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] VidrosComunsModel vidrosComunsModel, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                if (Imagem != null)
                {
                    // Definir pasta onde vai ser salvo
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\VidrosComuns");

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
                    vidrosComunsModel.Imagem = "imagensSaves/VidrosComuns/" + NomeArquivo;

                }

                _context.Add(vidrosComunsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome", vidrosComunsModel.AdesivoId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome", vidrosComunsModel.PeliculaId);
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura", vidrosComunsModel.ExpessuraId);
            return View(vidrosComunsModel);
        }

        // GET: VidrosComuns/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome");
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura");
            return View(vidrosComunsModel);
        }

        // POST: VidrosComuns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoVidro,NomeVidro,AdesivoId,PeliculaId,ExpessuraId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] VidrosComunsModel vidrosComunsModel, IFormFile NovaImagem)
        {
            if (id != vidrosComunsModel.CodigoVidro)
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
                        string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\VidrosComuns");

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
                        vidrosComunsModel.Imagem = "imagensSaves/VidrosComuns/" + NomeArquivo;
                    }

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
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome", vidrosComunsModel.AdesivoId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome", vidrosComunsModel.PeliculaId);
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura", vidrosComunsModel.ExpessuraId);
            return View(vidrosComunsModel);
        }

        // GET: VidrosComuns/Delete/5
        public async Task<IActionResult> Delete(int? id)
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vidrosComunsModel = await _context.VidrosComuns.FindAsync(id);
            _context.VidrosComuns.Remove(vidrosComunsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VidrosComunsModelExists(int id)
        {
            return _context.VidrosComuns.Any(e => e.CodigoVidro == id);
        }
    }
}
