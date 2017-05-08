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
    public class Flap10DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Flap10DataController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Flap10Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flap10Data.ToListAsync());
        }

        // GET: Flap10Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flapData = await _context.Flap10Data.SingleOrDefaultAsync(m => m.Id == id);
            if (flapData == null)
            {
                return NotFound();
            }

            return View(flapData);
        }

        // GET: Flap10Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flap10Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cold0V2,Cold0Vr,Cold10000V2,Cold10000Vr,Cold2000V2,Cold2000Vr,Cold4000V2,Cold4000Vr,Cold6000V2,Cold6000Vr,Cold8000V2,Cold8000Vr,Hot0V2,Hot0Vr,Hot10000V2,Hot10000Vr,Hot2000V2,Hot2000Vr,Hot4000V2,Hot4000Vr,Hot6000V2,Hot6000Vr,Hot8000V2,Hot8000Vr,Weight")] FlapData flapData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flapData);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(flapData);
        }

        // GET: Flap10Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flapData = await _context.Flap10Data.SingleOrDefaultAsync(m => m.Id == id);
            if (flapData == null)
            {
                return NotFound();
            }
            return View(flapData);
        }

        // POST: Flap10Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cold0V2,Cold0Vr,Cold10000V2,Cold10000Vr,Cold2000V2,Cold2000Vr,Cold4000V2,Cold4000Vr,Cold6000V2,Cold6000Vr,Cold8000V2,Cold8000Vr,Hot0V2,Hot0Vr,Hot10000V2,Hot10000Vr,Hot2000V2,Hot2000Vr,Hot4000V2,Hot4000Vr,Hot6000V2,Hot6000Vr,Hot8000V2,Hot8000Vr,Weight")] FlapData flapData)
        {
            if (id != flapData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flapData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlapDataExists(flapData.Id))
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
            return View(flapData);
        }

        // GET: Flap10Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flapData = await _context.Flap10Data.SingleOrDefaultAsync(m => m.Id == id);
            if (flapData == null)
            {
                return NotFound();
            }

            return View(flapData);
        }

        // POST: Flap10Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flapData = await _context.Flap10Data.SingleOrDefaultAsync(m => m.Id == id);
            _context.Flap10Data.Remove(flapData);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FlapDataExists(int id)
        {
            return _context.Flap10Data.Any(e => e.Id == id);
        }
    }
}
