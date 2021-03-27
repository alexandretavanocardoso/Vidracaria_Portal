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
using Vidracaria_Portal.Models.Administrador.Servicos;
using X.PagedList;

namespace Vidracaria_Portal.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class OrcamentosController : Controller
    {
        private readonly VidracariaContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public OrcamentosController(VidracariaContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<ActionResult> AprovarOrcamento(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamentosModel = await _context.Orcamentos.FindAsync(id);
            if (orcamentosModel == null)
            {
                return NotFound();
            }

            

            _context.Orcamentos.Remove(orcamentosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Aprovados", orcamentosModel);
        }

        // GET: Orcamentos
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

            var Orcamentos = from p in _context.Orcamentos select p;
            if (!String.IsNullOrEmpty(pesquisa))
            {
                Orcamentos = Orcamentos.Where(p => p.Nome.Contains(pesquisa)).AsNoTracking();
            }
            int itensPorPagina = 25;
            return View(await Orcamentos.ToPagedListAsync(pagina, itensPorPagina));
        }

        // GET: Orcamentos/Create
        public IActionResult Create()
        {
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo");
            return View();
        }

        // POST: Orcamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodigoOrcamento,Nome,Rua,NumeroCasa,Cidade,Bairro,Celular,Telefone,Estado,TipoId,DataCadastro,Imagem")] OrcamentosModel orcamentosModel, IFormFile Imagem)
        {
            if (ModelState.IsValid)
            {
                if (Imagem != null)
                {
                    // Definir pasta onde vai ser salvo
                    string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Orcamentos");

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
                    orcamentosModel.Imagem = "imagensSaves/Orcamentos" + NomeArquivo;

                }

                _context.Add(orcamentosModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo", orcamentosModel.TipoId);
            return View(orcamentosModel);
        }

        // GET: Orcamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamentosModel = await _context.Orcamentos.FindAsync(id);
            if (orcamentosModel == null)
            {
                return NotFound();
            }
            ViewData["CaminhoImagem"] = _webHostEnvironment.WebRootPath;
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo");
            return View(orcamentosModel);
        }

        // POST: Orcamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CodigoOrcamento,Nome,Rua,NumeroCasa,Cidade,Bairro,Celular,Telefone,Estado,TipoId,DataCadastro,Imagem")] OrcamentosModel orcamentosModel, IFormFile NovaImagem)
        {
            if (id != orcamentosModel.CodigoOrcamento)
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
                        string pasta = Path.Combine(_webHostEnvironment.WebRootPath, "imagensSaves\\Orcamentos");

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
                        orcamentosModel.Imagem = "imagensSaves/Orcamentos" + NomeArquivo;
                    }

                    _context.Update(orcamentosModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrcamentosModelExists(orcamentosModel.CodigoOrcamento))
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
            ViewData["TipoId"] = new SelectList(_context.TipoDeServicos, "CodigoTipo", "Tipo", orcamentosModel.TipoId);
            return View(orcamentosModel);
        }

        // GET: Orcamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orcamentosModel = await _context.Orcamentos
                .FirstOrDefaultAsync(m => m.CodigoOrcamento == id);
            if (orcamentosModel == null)
            {
                return NotFound();
            }

            return View(orcamentosModel);
        }

        // POST: Orcamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orcamentosModel = await _context.Orcamentos.FindAsync(id);
            _context.Orcamentos.Remove(orcamentosModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrcamentosModelExists(int id)
        {
            return _context.Orcamentos.Any(e => e.CodigoOrcamento == id);
        }
    }
}
