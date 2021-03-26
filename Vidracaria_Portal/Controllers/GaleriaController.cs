using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
    public class GaleriaController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GaleriaController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Galeria
        public async Task<IActionResult> Index(int? pagina)
        {
            var galeria = from p in _context.GaleriaModels select p;
            int itensPorPagina = 9;
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(await galeria.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Galeria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeriaModel = await _context.GaleriaModels
                .FirstOrDefaultAsync(m => m.CodigoGaleria == id);
            if (galeriaModel == null)
            {
                return NotFound();
            }

            return View(galeriaModel);
        }

        // GET: Galeria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Galeria/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoGaleria,Imagem")] GaleriaModel galeriaModel, IFormFile imagem)
        {
            if (ModelState.IsValid)
            {
                if(imagem != null)
                {
                    // Definir pasta onde vai ser salvo
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Galeria");

                    //Nome unico
                    var NomeArquivo = Guid.NewGuid().ToString() + "_" + imagem.FileName; // nome da imagem e extensão

                    //Caminho Arquivo
                    var CaminhoArquivo = Path.Combine(pasta, NomeArquivo);

                    //Biblioteca - Criar e salvar aqreuivos em HD
                    using (var stream = new FileStream(CaminhoArquivo, FileMode.Create)) // Cria o Arquivo e copia a imagem que chegou do form
                    {
                        await imagem.CopyToAsync(stream);
                    }
                    // Localizaçao e nome imagem
                    galeriaModel.Imagem = "imagensSaves/Galeria/" + NomeArquivo;
                }

                _context.Add(galeriaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(galeriaModel);
        }

        // GET: Galeria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeriaModel = await _context.GaleriaModels.FindAsync(id);
            if (galeriaModel == null)
            {
                return NotFound();
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            return View(galeriaModel);
        }

        // POST: Galeria/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoGaleria,Imagem")] GaleriaModel galeriaModel, IFormFile NovaImagem)
        {
            if (id != galeriaModel.CodigoGaleria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (NovaImagem != null)
                {
                    // Definir pasta onde vai ser salvo
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Galeria");

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
                    galeriaModel.Imagem = "imagensSaves/Galeria/" + NomeArquivo;
                }

                try
                {
                    _context.Update(galeriaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GaleriaModelExists(galeriaModel.CodigoGaleria))
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
            return View(galeriaModel);
        }

        // GET: Galeria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var galeriaModel = await _context.GaleriaModels
                .FirstOrDefaultAsync(m => m.CodigoGaleria == id);
            if (galeriaModel == null)
            {
                return NotFound();
            }

            return View(galeriaModel);
        }

        // POST: Galeria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var galeriaModel = await _context.GaleriaModels.FindAsync(id);
            _context.GaleriaModels.Remove(galeriaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GaleriaModelExists(int id)
        {
            return _context.GaleriaModels.Any(e => e.CodigoGaleria == id);
        }
    }
}
