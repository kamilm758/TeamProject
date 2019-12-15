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
using TeamProject.ExtensionMethods;

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
            NewFieldList newFieldList = new NewFieldList();
            var idFieldsInForm = _context.FormField.Where(ff => ff.IdForm == id)
                .Select(ff => ff.IdField).ToList();
            newFieldList.fields = _context.Field.Where(f => idFieldsInForm.Contains(f.Id)).ToList();
            newFieldList.FormId =Convert.ToInt32(id);
            return View(newFieldList);
        }
        [HttpPost]
        public IActionResult AddToList(NewFieldList newFieldList)
        {
            if (newFieldList.currentName == "")
                return View("AddNewField", newFieldList);
            var field = new Field
            {
                Name = newFieldList.currentName,
                Type = newFieldList.currentType
            };
            newFieldList.fields.Add(field);
            TempData.Put<NewFieldList>("newFieldListModel", newFieldList);
            return RedirectToAction("ListWithFields");
        }
        [HttpGet]
        public IActionResult ListWithFields()
        {
            var newFieldList = TempData.Get<NewFieldList>("newFieldListModel");
            return View("AddNewField", newFieldList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewField(NewFieldList newFieldList)
        {
            if (ModelState.IsValid)
            {
               
                
            }
            return View(newFieldList);
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
