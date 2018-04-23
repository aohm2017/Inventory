using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;
using Microsoft.AspNetCore.Authorization;

namespace Inventory.Controllers
{
    [Authorize]
    public class MakeupController : Controller
    {
        private readonly InventoryContext _context;

        public MakeupController(InventoryContext context)
        {
            _context = context;
        }

        public ActionResult Index ()
        {
            return View();
        }
        // GET: Makeup
        public async Task<IActionResult> EyeIndex()
        {
            var eyes = _context.MakeupProduct.Include(m => m.MakeupCategoryNavigation).Where(m => m.MakeupCategoryNavigation.SubCategory.Contains("Eye"));

            //var inventoryContext = _context.MakeupProduct.Include(m => m.MakeupCategoryNavigation);
            var inventoryContext = eyes;
            
            return View(await inventoryContext.ToListAsync());
        }

        public async Task<IActionResult> FaceIndex()
        {
            var eyes = _context.MakeupProduct.Include(m => m.MakeupCategoryNavigation).Where(m => m.MakeupCategoryNavigation.SubCategory.Contains("Face"));

            //var inventoryContext = _context.MakeupProduct.Include(m => m.MakeupCategoryNavigation);
            var inventoryContext = eyes;

            return View(await inventoryContext.ToListAsync());
        }

        public async Task<IActionResult> LipIndex()
        {
            var eyes = _context.MakeupProduct.Include(m => m.MakeupCategoryNavigation).Where(m => m.MakeupCategoryNavigation.SubCategory.Contains("Lip"));

            //var inventoryContext = _context.MakeupProduct.Include(m => m.MakeupCategoryNavigation);
            var inventoryContext = eyes;

            return View(await inventoryContext.ToListAsync());
        }

        // GET: Makeup/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeupProduct = await _context.MakeupProduct
                .Include(m => m.MakeupCategoryNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (makeupProduct == null)
            {
                return NotFound();
            }

            return View(makeupProduct);
        }

        // GET: Makeup/Create
        public IActionResult Create()
        {
            ViewData["MakeupCategory"] = new SelectList(_context.MakeupCategory, "Id", "Category");
            return View();
        }

        // POST: Makeup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Product,Brand,Ounce,Price,ProductLink,Comments,DatePurchased,MakeupCategory")] MakeupProduct makeupProduct)
        {
            if (ModelState.IsValid)
            {
                makeupProduct.Id = Guid.NewGuid();
                _context.Add(makeupProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EyeIndex));
            }
            ViewData["MakeupCategory"] = new SelectList(_context.MakeupCategory, "Id", "Category", makeupProduct.MakeupCategory);
            return View(makeupProduct);
        }

        // GET: Makeup/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeupProduct = await _context.MakeupProduct.SingleOrDefaultAsync(m => m.Id == id);
            if (makeupProduct == null)
            {
                return NotFound();
            }
            ViewData["MakeupCategory"] = new SelectList(_context.MakeupCategory, "Id", "Category", makeupProduct.MakeupCategory);
            return View(makeupProduct);
        }

        // POST: Makeup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Product,Brand,Ounce,Price,ProductLink,Comments,DatePurchased,MakeupCategory")] MakeupProduct makeupProduct)
        {
            if (id != makeupProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(makeupProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MakeupProductExists(makeupProduct.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(EyeIndex));
            }
            ViewData["MakeupCategory"] = new SelectList(_context.MakeupCategory, "Id", "Category", makeupProduct.MakeupCategory);
            return View(makeupProduct);
        }

        // GET: Makeup/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var makeupProduct = await _context.MakeupProduct
                .Include(m => m.MakeupCategoryNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (makeupProduct == null)
            {
                return NotFound();
            }

            return View(makeupProduct);
        }

        // POST: Makeup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var makeupProduct = await _context.MakeupProduct.SingleOrDefaultAsync(m => m.Id == id);
            _context.MakeupProduct.Remove(makeupProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(EyeIndex));
        }

        private bool MakeupProductExists(Guid id)
        {
            return _context.MakeupProduct.Any(e => e.Id == id);
        }
    }
}
