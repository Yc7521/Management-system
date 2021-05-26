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
    public class BuyMerchandisesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BuyMerchandisesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BuyMerchandises
        public async Task<IActionResult> Index()
        {
            return View(await _context.BuyMerchandise.ToListAsync());
        }

        // GET: BuyMerchandises/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyMerchandise = await _context.BuyMerchandise
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyMerchandise == null)
            {
                return NotFound();
            }

            return View(buyMerchandise);
        }

        // GET: BuyMerchandises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BuyMerchandises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Unit,OrderNum,InboundNum,Remainder")] BuyMerchandise buyMerchandise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buyMerchandise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(buyMerchandise);
        }

        // GET: BuyMerchandises/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyMerchandise = await _context.BuyMerchandise.FindAsync(id);
            if (buyMerchandise == null)
            {
                return NotFound();
            }
            return View(buyMerchandise);
        }

        // POST: BuyMerchandises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Unit,OrderNum,InboundNum,Remainder")] BuyMerchandise buyMerchandise)
        {
            if (id != buyMerchandise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buyMerchandise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuyMerchandiseExists(buyMerchandise.Id))
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
            return View(buyMerchandise);
        }

        // GET: BuyMerchandises/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyMerchandise = await _context.BuyMerchandise
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyMerchandise == null)
            {
                return NotFound();
            }

            return View(buyMerchandise);
        }

        // POST: BuyMerchandises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var buyMerchandise = await _context.BuyMerchandise.FindAsync(id);
            _context.BuyMerchandise.Remove(buyMerchandise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuyMerchandiseExists(string id)
        {
            return _context.BuyMerchandise.Any(e => e.Id == id);
        }
    }
}
