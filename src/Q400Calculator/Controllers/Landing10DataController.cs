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
    public class Landing10DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Landing10DataController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Landing10Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Landing10Data.ToListAsync());
        }

        // GET: Landing10Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing10Data = await _context.Landing10Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing10Data == null)
            {
                return NotFound();
            }

            return View(landing10Data);
        }

        // GET: Landing10Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Landing10Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vapp,Vga,Vref,Weight")] Landing10Data landing10Data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landing10Data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(landing10Data);
        }

        // GET: Landing10Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing10Data = await _context.Landing10Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing10Data == null)
            {
                return NotFound();
            }
            return View(landing10Data);
        }

        // POST: Landing10Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vapp,Vga,Vref,Weight")] Landing10Data landing10Data)
        {
            if (id != landing10Data.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landing10Data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Landing10DataExists(landing10Data.Id))
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
            return View(landing10Data);
        }

        // GET: Landing10Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing10Data = await _context.Landing10Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing10Data == null)
            {
                return NotFound();
            }

            return View(landing10Data);
        }

        // POST: Landing10Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landing10Data = await _context.Landing10Data.SingleOrDefaultAsync(m => m.Id == id);
            _context.Landing10Data.Remove(landing10Data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Landing10DataExists(int id)
        {
            return _context.Landing10Data.Any(e => e.Id == id);
        }
    }
}
