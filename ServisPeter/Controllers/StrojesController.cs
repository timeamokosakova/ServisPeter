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
    public class StrojesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StrojesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Strojes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stroje.ToListAsync());
        }

        // GET: Strojes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stroje = await _context.Stroje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stroje == null)
            {
                return NotFound();
            }

            return View(stroje);
        }

        // GET: Strojes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Strojes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nazov,Typ,Poznamky")] Stroje stroje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stroje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stroje);
        }

        // GET: Strojes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stroje = await _context.Stroje.FindAsync(id);
            if (stroje == null)
            {
                return NotFound();
            }
            return View(stroje);
        }

        // POST: Strojes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nazov,Typ,Poznamky")] Stroje stroje)
        {
            if (id != stroje.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stroje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StrojeExists(stroje.ID))
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
            return View(stroje);
        }

        // GET: Strojes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stroje = await _context.Stroje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stroje == null)
            {
                return NotFound();
            }

            return View(stroje);
        }

        // POST: Strojes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stroje = await _context.Stroje.FindAsync(id);
            _context.Stroje.Remove(stroje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StrojeExists(int id)
        {
            return _context.Stroje.Any(e => e.ID == id);
        }
    }
}
