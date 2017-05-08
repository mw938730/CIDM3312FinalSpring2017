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
    public class Landing35DataController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Landing35DataController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Landing35Data
        public async Task<IActionResult> Index()
        {
            return View(await _context.Landing35Data.ToListAsync());
        }

        // GET: Landing35Data/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing35Data = await _context.Landing35Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing35Data == null)
            {
                return NotFound();
            }

            return View(landing35Data);
        }

        // GET: Landing35Data/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Landing35Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Vapp,Vga,Vref,Weight")] Landing35Data landing35Data)
        {
            if (ModelState.IsValid)
            {
                _context.Add(landing35Data);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(landing35Data);
        }

        // GET: Landing35Data/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing35Data = await _context.Landing35Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing35Data == null)
            {
                return NotFound();
            }
            return View(landing35Data);
        }

        // POST: Landing35Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Vapp,Vga,Vref,Weight")] Landing35Data landing35Data)
        {
            if (id != landing35Data.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(landing35Data);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Landing35DataExists(landing35Data.Id))
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
            return View(landing35Data);
        }

        // GET: Landing35Data/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var landing35Data = await _context.Landing35Data.SingleOrDefaultAsync(m => m.Id == id);
            if (landing35Data == null)
            {
                return NotFound();
            }

            return View(landing35Data);
        }

        // POST: Landing35Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var landing35Data = await _context.Landing35Data.SingleOrDefaultAsync(m => m.Id == id);
            _context.Landing35Data.Remove(landing35Data);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Landing35DataExists(int id)
        {
            return _context.Landing35Data.Any(e => e.Id == id);
        }
    }
}
