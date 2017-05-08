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
    public class Landing5DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Landing5DataController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Landing5Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Landing5Data.ToListAsync());
        }

        // GET: Landing5Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing5Data = await _context.Landing5Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing5Data == null)
            {
                return NotFound();
            }

            return View(landing5Data);
        }

        // GET: Landing5Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Landing5Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vapp,Vga,Vref,Weight")] Landing5Data landing5Data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landing5Data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(landing5Data);
        }

        // GET: Landing5Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing5Data = await _context.Landing5Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing5Data == null)
            {
                return NotFound();
            }
            return View(landing5Data);
        }

        // POST: Landing5Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vapp,Vga,Vref,Weight")] Landing5Data landing5Data)
        {
            if (id != landing5Data.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landing5Data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Landing5DataExists(landing5Data.Id))
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
            return View(landing5Data);
        }

        // GET: Landing5Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing5Data = await _context.Landing5Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing5Data == null)
            {
                return NotFound();
            }

            return View(landing5Data);
        }

        // POST: Landing5Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landing5Data = await _context.Landing5Data.SingleOrDefaultAsync(m => m.Id == id);
            _context.Landing5Data.Remove(landing5Data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Landing5DataExists(int id)
        {
            return _context.Landing5Data.Any(e => e.Id == id);
        }
    }
}
