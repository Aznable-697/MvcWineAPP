﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcWineAPP.Data;
using MvcWineAPP.Models;

namespace MvcWineAPP.Controllers
{
    [Authorize]
    public class WineController : Controller
    {
        private readonly WineDBContext _context;

        public WineController(WineDBContext context)
        {
            _context = context;
        }

        // GET: Wines
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wines.ToListAsync());
        }

        // GET: Wines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = await _context.Wines
                .FirstOrDefaultAsync(m => m.WineID == id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }

        // GET: Wines/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Vineyard,WineID,WineName,WineVintage,WineTypes,PairsWith,DateAdded")] Wine wine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wine);
        }

        // GET: Wines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = await _context.Wines.FindAsync(id);
            if (wine == null)
            {
                return NotFound();
            }
            return View(wine);
        }

        // POST: Wines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Vineyard,WineID,WineName,WineVintage,WineTypes,PairsWith,DateAdded")] Wine wine)
        {
            if (id != wine.WineID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WineExists(wine.WineID))
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
            return View(wine);
        }

        // GET: Wines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wine = await _context.Wines
                .FirstOrDefaultAsync(m => m.WineID == id);
            if (wine == null)
            {
                return NotFound();
            }

            return View(wine);
        }

        // POST: Wines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wine = await _context.Wines.FindAsync(id);
            _context.Wines.Remove(wine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WineExists(int id)
        {
            return _context.Wines.Any(e => e.WineID == id);
        }
    }
}
