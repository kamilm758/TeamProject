using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FormGenerator.Models;

namespace TeamProject.Controllers
{
    public class EntranceFormFieldsController : Controller
    {
        private readonly FormGeneratorContext _context;

        public EntranceFormFieldsController(FormGeneratorContext context)
        {
            _context = context;
        }

        // GET: EntranceFormFields
        public async Task<IActionResult> Index()
        {
            return View(await _context.EntranceFormFields.ToListAsync());
        }

        // GET: EntranceFormFields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entranceFormFields = await _context.EntranceFormFields
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entranceFormFields == null)
            {
                return NotFound();
            }

            return View(entranceFormFields);
        }

        // GET: EntranceFormFields/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EntranceFormFields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdField")] EntranceFormFields entranceFormFields)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entranceFormFields);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entranceFormFields);
        }

        // GET: EntranceFormFields/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entranceFormFields = await _context.EntranceFormFields.FindAsync(id);
            if (entranceFormFields == null)
            {
                return NotFound();
            }
            return View(entranceFormFields);
        }

        // POST: EntranceFormFields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdField")] EntranceFormFields entranceFormFields)
        {
            if (id != entranceFormFields.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entranceFormFields);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntranceFormFieldsExists(entranceFormFields.Id))
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
            return View(entranceFormFields);
        }

        // GET: EntranceFormFields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entranceFormFields = await _context.EntranceFormFields
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entranceFormFields == null)
            {
                return NotFound();
            }

            return View(entranceFormFields);
        }

        // POST: EntranceFormFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entranceFormFields = await _context.EntranceFormFields.FindAsync(id);
            _context.EntranceFormFields.Remove(entranceFormFields);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntranceFormFieldsExists(int id)
        {
            return _context.EntranceFormFields.Any(e => e.Id == id);
        }
    }
}
