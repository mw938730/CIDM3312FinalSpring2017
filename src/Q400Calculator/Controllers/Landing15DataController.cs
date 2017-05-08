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
    public class Landing15DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Landing15DataController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Landing15Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Landing15Data.ToListAsync());
        }

        // GET: Landing15Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing15Data = await _context.Landing15Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing15Data == null)
            {
                return NotFound();
            }

            return View(landing15Data);
        }

        // GET: Landing15Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Landing15Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vapp,Vga,Vref,Weight")] Landing15Data landing15Data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landing15Data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(landing15Data);
        }

        // GET: Landing15Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing15Data = await _context.Landing15Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing15Data == null)
            {
                return NotFound();
            }
            return View(landing15Data);
        }

        // POST: Landing15Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vapp,Vga,Vref,Weight")] Landing15Data landing15Data)
        {
            if (id != landing15Data.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landing15Data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Landing15DataExists(landing15Data.Id))
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
            return View(landing15Data);
        }

        // GET: Landing15Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing15Data = await _context.Landing15Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing15Data == null)
            {
                return NotFound();
            }

            return View(landing15Data);
        }

        // POST: Landing15Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landing15Data = await _context.Landing15Data.SingleOrDefaultAsync(m => m.Id == id);
            _context.Landing15Data.Remove(landing15Data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Landing15DataExists(int id)
        {
            return _context.Landing15Data.Any(e => e.Id == id);
        }
    }
}
