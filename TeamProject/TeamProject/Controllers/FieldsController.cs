using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FormGenerator.Models;
using TeamProject.Models.Modele_pomocnicze;
using System.Diagnostics;


namespace FormGenerator.Controllers
{
    public class FieldsController : Controller
    {
        private readonly FormGeneratorContext _context;
        

        public FieldsController(FormGeneratorContext context)
        {
            _context = context;
            
        }

        // GET: Fields
        public async Task<IActionResult> Index()
        {
            return View(await _context.Field.ToListAsync());
        }

        // GET: Fields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @field = await _context.Field
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@field == null)
            {
                return NotFound();
            }

            return View(@field);
        }

        // GET: Fields/Create
        public IActionResult Create()
        {            
            return View();
        }

        // POST: Fields/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type")] Field @field)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@field);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@field);
        }
        //przeładowane metody w celu dodaniapytania od razu do formularza
        
       
        public IActionResult AddNewField(int? id)
        {
            ViewBag.formid = Convert.ToInt32(id);

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewField([Bind("Id,Name,Type")] Field @field,int? id)
        {
            if (ModelState.IsValid)
            {
                field.Id = 0;
                _context.Add(@field);
                await _context.SaveChangesAsync();

                int newid = field.Id;
                FormField formField = new FormField
                {
                    IdField = newid,
                    IdForm = Convert.ToInt32(id)
                };

                _context.FormField.Add(formField);
                await _context.SaveChangesAsync();
                return RedirectToAction("AddNewField", new { id=id});
            }
            return View(@field);
        }
        // GET: Fields/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @field = await _context.Field.FindAsync(id);
            if (@field == null)
            {
                return NotFound();
            }
            return View(@field);
        }

        // POST: Fields/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type")] Field @field)
        {
            if (id != @field.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@field);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FieldExists(@field.Id))
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
            return View(@field);
        }

        // GET: Fields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @field = await _context.Field
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@field == null)
            {
                return NotFound();
            }

            return View(@field);
        }

        

        // GET: Fields1/Edit/5
        public async Task<IActionResult> EditNewField(int? id,int form)
        {
            ViewBag.IDFORM = form;
            
            if (id == null)
            {
                return NotFound();
            }

            var @field = await _context.Field.FindAsync(id);
            if (@field == null)
            {
                return NotFound();
            }
            return View(@field);
        }

        // POST: Fields1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditNewField(int id, [Bind("Id,Name,Type")] Field @field,int form)
        {
            ViewBag.IDFORM = form;
            if (id != @field.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@field);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FieldExists(@field.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                ViewBag.message = true;
                return View();
            }
            return View(@field);
        }


        // GET: Fields1/Delete/5
        public async Task<IActionResult> DeleteNewField(int? id,int form)
        {
            ViewBag.IDFORM = form;
            if (id == null)
            {
                return NotFound();
            }

            var @field = await _context.Field
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@field == null)
            {
                return NotFound();
            }

            return View(@field);
        }

        // POST: Fields1/Delete/5
        [HttpPost, ActionName("DeleteNewField")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteNewFieldConfirmed(int id,int form)
        {
            ViewBag.IDFORM = form;
            var @field = await _context.Field.FindAsync(id);
            _context.Field.Remove(@field);
            await _context.SaveChangesAsync();
            ViewBag.message = true;
            return View();
        }

        public async Task<IActionResult> DetailsNewField(int? id, int form)
        {
            ViewBag.IDFORM = form;
            if (id == null)
            {
                return NotFound();
            }

            var @field = await _context.Field
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@field == null)
            {
                return NotFound();
            }

            return View(@field);
        }


        // POST: Fields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @field = await _context.Field.FindAsync(id);
            _context.Field.Remove(@field);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
      
        private bool FieldExists(int id)
        {
            return _context.Field.Any(e => e.Id == id);
        }
    }
}
