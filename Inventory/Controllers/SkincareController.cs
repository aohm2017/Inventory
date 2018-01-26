using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;

namespace Inventory.Controllers
{
    public class SkincareController : Controller
    {
        private readonly InventoryContext _context;

        public SkincareController(InventoryContext context)
        {
            _context = context;
        }

        // GET: Skincare
        public async Task<IActionResult> Index()
        {
            var inventoryContext = _context.SkincareProduct.Include(s => s.SkincareCategoryNavigation);
            return View(await inventoryContext.ToListAsync());
        }

        // GET: Skincare/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skincareProduct = await _context.SkincareProduct
                .Include(s => s.SkincareCategoryNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (skincareProduct == null)
            {
                return NotFound();
            }

            return View(skincareProduct);
        }

        // GET: Skincare/Create
        public IActionResult Create()
        {
            ViewData["SkincareCategory"] = new SelectList(_context.SkincareCategory, "Id", "Category");
            return View();
        }

        // POST: Skincare/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Product,Brand,Ounces,Price,PricePerOunce,ProductLink,Comments,DatePurchased,SkincareCategory")] SkincareProduct skincareProduct)
        {
            if (ModelState.IsValid)
            {
                skincareProduct.Id = Guid.NewGuid();
                _context.Add(skincareProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SkincareCategory"] = new SelectList(_context.SkincareCategory, "Id", "Category", skincareProduct.SkincareCategory);
            return View(skincareProduct);
        }

        // GET: Skincare/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skincareProduct = await _context.SkincareProduct.SingleOrDefaultAsync(m => m.Id == id);
            if (skincareProduct == null)
            {
                return NotFound();
            }
            ViewData["SkincareCategory"] = new SelectList(_context.SkincareCategory, "Id", "Category", skincareProduct.SkincareCategory);
            return View(skincareProduct);
        }

        // POST: Skincare/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Product,Brand,Ounces,Price,PricePerOunce,ProductLink,Comments,DatePurchased,SkincareCategory")] SkincareProduct skincareProduct)
        {
            if (id != skincareProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(skincareProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SkincareProductExists(skincareProduct.Id))
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
            ViewData["SkincareCategory"] = new SelectList(_context.SkincareCategory, "Id", "Category", skincareProduct.SkincareCategory);
            return View(skincareProduct);
        }

        // GET: Skincare/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var skincareProduct = await _context.SkincareProduct
                .Include(s => s.SkincareCategoryNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (skincareProduct == null)
            {
                return NotFound();
            }

            return View(skincareProduct);
        }

        // POST: Skincare/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var skincareProduct = await _context.SkincareProduct.SingleOrDefaultAsync(m => m.Id == id);
            _context.SkincareProduct.Remove(skincareProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SkincareProductExists(Guid id)
        {
            return _context.SkincareProduct.Any(e => e.Id == id);
        }
    }
}
