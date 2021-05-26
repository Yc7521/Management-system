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
    public class BuyMerchandiseListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BuyMerchandiseListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BuyMerchandiseLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.BuyMerchandiseList.ToListAsync());
        }

        // GET: BuyMerchandiseLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyMerchandiseList = await _context.BuyMerchandiseList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyMerchandiseList == null)
            {
                return NotFound();
            }

            return View(buyMerchandiseList);
        }

        // GET: BuyMerchandiseLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BuyMerchandiseLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BillingDate,Storehouse,ExchangeCompany,Manager,Confirm,ConfirmDate,ArrivalDate,Contract,Prepaid,Operator,Explain")] BuyMerchandiseList buyMerchandiseList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(buyMerchandiseList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(buyMerchandiseList);
        }

        // GET: BuyMerchandiseLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyMerchandiseList = await _context.BuyMerchandiseList.FindAsync(id);
            if (buyMerchandiseList == null)
            {
                return NotFound();
            }
            return View(buyMerchandiseList);
        }

        // POST: BuyMerchandiseLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,BillingDate,Storehouse,ExchangeCompany,Manager,Confirm,ConfirmDate,ArrivalDate,Contract,Prepaid,Operator,Explain")] BuyMerchandiseList buyMerchandiseList)
        {
            if (id != buyMerchandiseList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(buyMerchandiseList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BuyMerchandiseListExists(buyMerchandiseList.Id))
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
            return View(buyMerchandiseList);
        }

        // GET: BuyMerchandiseLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var buyMerchandiseList = await _context.BuyMerchandiseList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (buyMerchandiseList == null)
            {
                return NotFound();
            }

            return View(buyMerchandiseList);
        }

        // POST: BuyMerchandiseLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var buyMerchandiseList = await _context.BuyMerchandiseList.FindAsync(id);
            _context.BuyMerchandiseList.Remove(buyMerchandiseList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BuyMerchandiseListExists(string id)
        {
            return _context.BuyMerchandiseList.Any(e => e.Id == id);
        }
    }
}
