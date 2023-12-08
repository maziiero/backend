using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _19_Atividade_CRUD.Context;
using _19_Atividade_CRUD.Models;

namespace _19_Atividade_CRUD.Controllers
{
    public class RoupaController : Controller
    {
        private readonly AppDbContext _context;

        public RoupaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RoupaControllers
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Roupas.Include(r => r.Categoria);
            return View(await appDbContext.ToListAsync());
        }

        // GET: RoupaControllers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Roupas == null)
            {
                return NotFound();
            }

            var roupa = await _context.Roupas
                .Include(r => r.Categoria)
                .FirstOrDefaultAsync(m => m.RoupaId == id);
            if (roupa == null)
            {
                return NotFound();
            }

            return View(roupa);
        }

        // GET: RoupaControllers/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaNome");
            return View();
        }

        // POST: RoupaControllers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Roupa roupa)
        {
           
                _context.Add(roupa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaId", roupa.CategoriaId);
            return View(roupa);
        }

        // GET: RoupaControllers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Roupas == null)
            {
                return NotFound();
            }

            var roupa = await _context.Roupas.FindAsync(id);
            if (roupa == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaId", roupa.CategoriaId);
            return View(roupa);
        }

        // POST: RoupaControllers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Roupa roupa)
        {
            if (id != roupa.RoupaId)
            {
                return NotFound();
            }

           
                try
                {
                    _context.Update(roupa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoupaExists(roupa.RoupaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaId", roupa.CategoriaId);
            return View(roupa);
        }

        // GET: RoupaControllers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Roupas == null)
            {
                return NotFound();
            }

            var roupa = await _context.Roupas
                .Include(r => r.Categoria)
                .FirstOrDefaultAsync(m => m.RoupaId == id);
            if (roupa == null)
            {
                return NotFound();
            }

            return View(roupa);
        }

        // POST: RoupaControllers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Roupas == null)
            {
                return Problem("Entity set 'AppDbContext.Roupas'  is null.");
            }
            var roupa = await _context.Roupas.FindAsync(id);
            if (roupa != null)
            {
                _context.Roupas.Remove(roupa);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoupaExists(int id)
        {
          return (_context.Roupas?.Any(e => e.RoupaId == id)).GetValueOrDefault();
        }
    }
}
