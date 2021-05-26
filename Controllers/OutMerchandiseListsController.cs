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
    public class OutMerchandiseListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OutMerchandiseListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OutMerchandiseLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.OutMerchandiseList.ToListAsync());
        }

        // GET: OutMerchandiseLists/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outMerchandiseList = await _context.OutMerchandiseList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outMerchandiseList == null)
            {
                return NotFound();
            }

            return View(outMerchandiseList);
        }

        // GET: OutMerchandiseLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OutMerchandiseLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Client,Handle,DeliveryMethod,Date,Type,HandleMan,Explain")] OutMerchandiseList outMerchandiseList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(outMerchandiseList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(outMerchandiseList);
        }

        // GET: OutMerchandiseLists/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outMerchandiseList = await _context.OutMerchandiseList.FindAsync(id);
            if (outMerchandiseList == null)
            {
                return NotFound();
            }
            return View(outMerchandiseList);
        }

        // POST: OutMerchandiseLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Client,Handle,DeliveryMethod,Date,Type,HandleMan,Explain")] OutMerchandiseList outMerchandiseList)
        {
            if (id != outMerchandiseList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(outMerchandiseList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OutMerchandiseListExists(outMerchandiseList.Id))
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
            return View(outMerchandiseList);
        }

        // GET: OutMerchandiseLists/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var outMerchandiseList = await _context.OutMerchandiseList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (outMerchandiseList == null)
            {
                return NotFound();
            }

            return View(outMerchandiseList);
        }

        // POST: OutMerchandiseLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var outMerchandiseList = await _context.OutMerchandiseList.FindAsync(id);
            _context.OutMerchandiseList.Remove(outMerchandiseList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OutMerchandiseListExists(string id)
        {
            return _context.OutMerchandiseList.Any(e => e.Id == id);
        }
    }
}
