using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using 管理系统.Data;
using 管理系统.Models;

namespace 管理系统.Controllers
{
    public class OutMerchandisesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OutMerchandisesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OutMerchandises
        public async Task<IActionResult> Index()
        {
            return View(await _context.OutMerchandise.ToListAsync());
        }

        // GET: OutMerchandises/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outMerchandise = await _context.OutMerchandise
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outMerchandise == null)
            {
                return NotFound();
            }

            return View(outMerchandise);
        }

        // GET: OutMerchandises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OutMerchandises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Unit,OrderNum,PickingNum,SN,BarCode")] OutMerchandise outMerchandise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outMerchandise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outMerchandise);
        }

        // GET: OutMerchandises/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outMerchandise = await _context.OutMerchandise.FindAsync(id);
            if (outMerchandise == null)
            {
                return NotFound();
            }
            return View(outMerchandise);
        }

        // POST: OutMerchandises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Unit,OrderNum,PickingNum,SN,BarCode")] OutMerchandise outMerchandise)
        {
            if (id != outMerchandise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outMerchandise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutMerchandiseExists(outMerchandise.Id))
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
            return View(outMerchandise);
        }

        // GET: OutMerchandises/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outMerchandise = await _context.OutMerchandise
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outMerchandise == null)
            {
                return NotFound();
            }

            return View(outMerchandise);
        }

        // POST: OutMerchandises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var outMerchandise = await _context.OutMerchandise.FindAsync(id);
            _context.OutMerchandise.Remove(outMerchandise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutMerchandiseExists(string id)
        {
            return _context.OutMerchandise.Any(e => e.Id == id);
        }
    }
}
