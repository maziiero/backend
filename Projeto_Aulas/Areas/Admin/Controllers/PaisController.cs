using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Context;
using App.Models;
using App.Filters;
using X.PagedList;
using System.Xml;
using System.Text;

namespace Grafico.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class PaisController : Controller
    {
        private readonly AppDbContext _context;

        public PaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pais
        public IActionResult Index(string? txtFiltro, string? selOrdenacao, int pagina = 1)
        {
            int pageSize = 10; // Número de itens por página

            IQueryable<Pais> listaView = _context.Paises.Include(c => c.Continente);
            if (txtFiltro != null && txtFiltro != "")
            {
                ViewData["txtFiltro"] = txtFiltro;
                listaView = listaView.Where(item => item.Nome.ToLower().Contains(txtFiltro.ToLower()));
            }

            if (selOrdenacao == "Pais" || selOrdenacao == null)
            {
                listaView = listaView.OrderBy(item => item.Nome.ToLower());
            }
            else if (selOrdenacao == "Capital")
            {
                listaView = listaView.OrderByDescending(item => item.Capital.ToLower());
            }
            else if (selOrdenacao == "MenorPopul")
            {
                listaView = listaView.OrderBy(item => item.Populacao);
            }
            else if (selOrdenacao == "MaiorPopul")
            {
                listaView = listaView.OrderByDescending(item => item.Populacao);
            }
            else if (selOrdenacao == "Continente")
            if (botao == "XML")
            {
                return ExportarXML(listaView.ToList());
            }
            {
                listaView = listaView.OrderBy(item => item.Continente);
            }

            return View(listaView.ToPagedList(pagina, pageSize));
        }

        // GET: Pais/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefault(m => m.IdPaises == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // GET: Pais/Create
        public IActionResult Create()
        {
            ViewData["continenteID"] = new SelectList(_context.Continentes, "continenteID", "Nome");
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pais pais)
        {
            _context.Add(pais);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        // GET: Pais/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises.Find(id);
            if (pais == null)
            {
                return NotFound();
            }
            ViewData["continenteID"] = new SelectList(_context.Continentes, "continenteID", "Nome", pais.continenteID);
            return View(pais);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Pais pais)
        {
            if (id != pais.IdPaises)
            {
                return NotFound();
            }

            try
            {
                _context.Update(pais);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisExists(pais.IdPaises))
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

        // GET: Pais/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefault(m => m.IdPaises == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_context.Paises == null)
            {
                return Problem("Entity set 'AppDbContext.Paises'  is null.");
            }
            var pais = _context.Paises.Find(id);
            if (pais != null)
            {
                _context.Paises.Remove(pais);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExists(int id)
        {
            return (_context.Paises?.Any(e => e.IdPaises == id)).GetValueOrDefault();
        }

        public IActionResult Grafico()
        {
            return View();
        }

        public IActionResult ObterDadosParaGrafico()
        {
            var dados = _context.Paises.ToList();
            return Json(dados);
        }
    }
}
