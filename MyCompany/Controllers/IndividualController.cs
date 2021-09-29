using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class IndividualController : Controller
    {
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var individual = await _context.Individuals 
                .AsNoTracking()  
                .FirstOrDefaultAsync(m => m.Id == id);

            if (individual == null)
            {
                return NotFound();
            }

            return View(individual);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Individual individual)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Individuals.Add(individual);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(individual);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Individual individual)
        {
            if (id == null)
            {
                return NotFound();
            }
            var individualToUpdate = await _context.Individuals
               .AsNoTracking()
               .FirstOrDefaultAsync(m => m.Id == id);

            if (individualToUpdate == null)
            {
                return NotFound();
            }
            try
            {
                    _context.Individuals.Update(individual);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(individual);
        }

        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var individual = await _context.Individuals
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (individual == null)
            {
                return NotFound();
            }

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(individual);
        }
    }
}
