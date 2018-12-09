using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServisPeter.Data;
using ServisPeter.Models;

namespace ServisPeter.Controllers
{
    public class DatabazasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DatabazasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Databazas
        public async Task<IActionResult> Index(string searchString, string searchdva)
        {
            var movies = from m in _context.Databaza
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.WIN.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(searchdva))
            {
                movies = movies.Where(s => s.SPZ.Contains(searchdva));
            }

            return View(await movies.ToListAsync());
        }

        // GET: Databazas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var databaza = await _context.Databaza
                .FirstOrDefaultAsync(m => m.ID == id);
            if (databaza == null)
            {
                return NotFound();
            }

            return View(databaza);
        }

        // GET: Databazas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Databazas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Datump,datumo,Auto,Typ,Kod,Kilometre,SPZ,WIN,Oprava,Cena,Poznamky")] Databaza databaza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(databaza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(databaza);
        }

        // GET: Databazas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var databaza = await _context.Databaza.FindAsync(id);
            if (databaza == null)
            {
                return NotFound();
            }
            return View(databaza);
        }

        // POST: Databazas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Datump,datumo,Auto,Typ,Kod,Kilometre,SPZ,WIN,Oprava,Cena,Poznamky")] Databaza databaza)
        {
            if (id != databaza.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(databaza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DatabazaExists(databaza.ID))
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
            return View(databaza);
        }

        // GET: Databazas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var databaza = await _context.Databaza
                .FirstOrDefaultAsync(m => m.ID == id);
            if (databaza == null)
            {
                return NotFound();
            }

            return View(databaza);
        }

        // POST: Databazas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var databaza = await _context.Databaza.FindAsync(id);
            _context.Databaza.Remove(databaza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DatabazaExists(int id)
        {
            return _context.Databaza.Any(e => e.ID == id);
        }
    }
}
