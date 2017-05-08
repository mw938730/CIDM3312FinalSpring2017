using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Q400Calculator.Data;
using Q400Calculator.Models;

namespace Q400Calculator.Controllers
{
    public class Flap15DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Flap15DataController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Flap15Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flap15Data.ToListAsync());
        }

        // GET: Flap15Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flap15Data = await _context.Flap15Data.SingleOrDefaultAsync(m => m.Id == id);
            if (flap15Data == null)
            {
                return NotFound();
            }

            return View(flap15Data);
        }

        // GET: Flap15Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flap15Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cold0V2,Cold0Vr,Cold10000V2,Cold10000Vr,Cold2000V2,Cold2000Vr,Cold4000V2,Cold4000Vr,Cold6000V2,Cold6000Vr,Cold8000V2,Cold8000Vr,Hot0V2,Hot0Vr,Hot10000V2,Hot10000Vr,Hot2000V2,Hot2000Vr,Hot4000V2,Hot4000Vr,Hot6000V2,Hot6000Vr,Hot8000V2,Hot8000Vr,Weight")] Flap15Data flap15Data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flap15Data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(flap15Data);
        }

        // GET: Flap15Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flap15Data = await _context.Flap15Data.SingleOrDefaultAsync(m => m.Id == id);
            if (flap15Data == null)
            {
                return NotFound();
            }
            return View(flap15Data);
        }

        // POST: Flap15Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cold0V2,Cold0Vr,Cold10000V2,Cold10000Vr,Cold2000V2,Cold2000Vr,Cold4000V2,Cold4000Vr,Cold6000V2,Cold6000Vr,Cold8000V2,Cold8000Vr,Hot0V2,Hot0Vr,Hot10000V2,Hot10000Vr,Hot2000V2,Hot2000Vr,Hot4000V2,Hot4000Vr,Hot6000V2,Hot6000Vr,Hot8000V2,Hot8000Vr,Weight")] Flap15Data flap15Data)
        {
            if (id != flap15Data.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flap15Data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Flap15DataExists(flap15Data.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(flap15Data);
        }

        // GET: Flap15Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flap15Data = await _context.Flap15Data.SingleOrDefaultAsync(m => m.Id == id);
            if (flap15Data == null)
            {
                return NotFound();
            }

            return View(flap15Data);
        }

        // POST: Flap15Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flap15Data = await _context.Flap15Data.SingleOrDefaultAsync(m => m.Id == id);
            _context.Flap15Data.Remove(flap15Data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Flap15DataExists(int id)
        {
            return _context.Flap15Data.Any(e => e.Id == id);
        }
    }
}
