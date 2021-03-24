using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models.Administrador.Cadastros;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")] // Obrigatorio para nao entrar no admin pela URL
    public class VidrosTemperadosController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VidrosTemperadosController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: VidrosTemperados
        public async Task<IActionResult> Index([Bind("EstoqueMaximo,EstoqueMinimo")] VidrosTemperadosModel vidrosTemperadosModel, string filtro, string pesquisa, int? pagina)
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

            var VidrosTemperados = from p in _context.VidrosTemperados select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                VidrosTemperados = VidrosTemperados.Where(p => p.NomeVidro.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 15;
            return View(await VidrosTemperados.ToPagedListAsync(pagina, itensPorPagina));
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
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome");
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura");
            return View();
        }

        // POST: VidrosTemperados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoVidro,NomeVidro,AdesivoId,PeliculaId,ExpessuraId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] VidrosTemperadosModel vidrosTemperadosModel, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                if (vidrosTemperadosModel.EstoqueMinimo > vidrosTemperadosModel.EstoqueMaximo)
                {
                    return NotFound();
                }

                if (vidrosTemperadosModel.PrecoFabrica > vidrosTemperadosModel.PrecoVenda)
                {
                    return NotFound();
                }

                if (Imagem != null)
                {
                    // Definir pasta onde vai ser salvo
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\VidrosTemperados");

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
                    vidrosTemperadosModel.Imagem = "imagensSaves/VidrosTemperados/" + NomeArquivo;

                }

                _context.Add(vidrosTemperadosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome", vidrosTemperadosModel.AdesivoId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome", vidrosTemperadosModel.PeliculaId);
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura", vidrosTemperadosModel.ExpessuraId);
            return View(vidrosTemperadosModel);
        }

        // GET: VidrosTemperados/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome");
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome");
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura");
            return View(vidrosTemperadosModel);
        }

        // POST: VidrosTemperados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoVidro,NomeVidro,AdesivoId,PeliculaId,ExpessuraId,Marca,EstoqueMaximo,EstoqueMinimo,PrecoVenda,PrecoFabrica,Imagem,DataCadastro")] VidrosTemperadosModel vidrosTemperadosModel, IFormFile NovaImagem)
        {
            if (id != vidrosTemperadosModel.CodigoVidro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (vidrosTemperadosModel.EstoqueMinimo > vidrosTemperadosModel.EstoqueMaximo)
                    {
                        return NotFound();
                    }

                    if (vidrosTemperadosModel.PrecoFabrica > vidrosTemperadosModel.PrecoVenda)
                    {
                        return NotFound();
                    }

                    if (NovaImagem != null)
                    {
                        // Definir pasta onde vai ser salvo
                        string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\VidrosTemperados");

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
                        vidrosTemperadosModel.Imagem = "imagensSaves/VidrosTemperados/" + NomeArquivo;
                    }

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
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["AdesivoId"] = new SelectList(_context.Adesivos, "CodigoAdesivo", "Nome", vidrosTemperadosModel.AdesivoId);
            ViewData["PeliculaId"] = new SelectList(_context.Peliculas, "CodigoPelicula", "Nome", vidrosTemperadosModel.PeliculaId);
            ViewData["ExpessuraId"] = new SelectList(_context.Expessura, "CodigoExpessura", "Expessura", vidrosTemperadosModel.ExpessuraId);
            return View(vidrosTemperadosModel);
        }

        // GET: VidrosTemperados/Delete/5
        public async Task<IActionResult> Delete(int? id)
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vidrosTemperadosModel = await _context.VidrosTemperados.FindAsync(id);
            _context.VidrosTemperados.Remove(vidrosTemperadosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VidrosTemperadosModelExists(int id)
        {
            return _context.VidrosTemperados.Any(e => e.CodigoVidro == id);
        }
    }
}
