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
    public class MerchandisesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MerchandisesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Merchandises
        public async Task<IActionResult> Index()
        {
            return View(await _context.Merchandise.ToListAsync());
        }

        // GET: Merchandises/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandise = await _context.Merchandise
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandise == null)
            {
                return NotFound();
            }

            return View(merchandise);
        }

        // GET: Merchandises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Merchandises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Company,StockNum,FinancialStock,PickingNum,OrderNum,PinableNum,CostPrice,StockAmount,Total")] Merchandise merchandise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merchandise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(merchandise);
        }

        // GET: Merchandises/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandise = await _context.Merchandise.FindAsync(id);
            if (merchandise == null)
            {
                return NotFound();
            }
            return View(merchandise);
        }

        // POST: Merchandises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Company,StockNum,FinancialStock,PickingNum,OrderNum,PinableNum,CostPrice,StockAmount,Total")] Merchandise merchandise)
        {
            if (id != merchandise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merchandise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerchandiseExists(merchandise.Id))
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
            return View(merchandise);
        }

        // GET: Merchandises/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchandise = await _context.Merchandise
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merchandise == null)
            {
                return NotFound();
            }

            return View(merchandise);
        }

        // POST: Merchandises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var merchandise = await _context.Merchandise.FindAsync(id);
            _context.Merchandise.Remove(merchandise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MerchandiseExists(string id)
        {
            return _context.Merchandise.Any(e => e.Id == id);
        }
    }
}
