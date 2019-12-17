﻿using System;
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
            Field field;
            if (newFieldList.currentName == "")
                return View("AddNewField", newFieldList);
            if (newFieldList.currentId != 0)
            {
                field = new Field
                {
                    Id=newFieldList.currentId,
                    Name = newFieldList.currentName,
                    Type = newFieldList.currentType
                };
            }
            else
            {
                field = new Field
                {
                    Name = newFieldList.currentNameToCreate,
                    Type = newFieldList.currentTypeToCreate
                };
            }
            newFieldList.fields.Add(field);
            TempData.Put<NewFieldList>("newFieldListModel", newFieldList);
            return RedirectToAction("ListWithFields");
        }

        public IActionResult DeleteFromList(int fieldId, NewFieldList newFieldList)
        {

            newFieldList.fields = newFieldList.fields.Where(f => f.Id != fieldId).ToList();
            TempData.Put<NewFieldList>("newFieldListModel", newFieldList);
            return RedirectToAction("ListWithFields");
        }

        [HttpGet]
        public IActionResult ListWithFields()
        {
            var newFieldList = TempData.Get<NewFieldList>("newFieldListModel");
            newFieldList.currentId = 0;
            newFieldList.currentName = null;
            newFieldList.currentNameToCreate = null;
            newFieldList.currentTypeToCreate = null;
            newFieldList.currentType = null;
            return View("AddNewField", newFieldList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewField(NewFieldList newFieldList)
        {
            var toRemove = _context.FormField.Where(ff => ff.IdForm == newFieldList.FormId).ToList();
            foreach (var toremove in toRemove)
                _context.FormField.Remove(toremove);
            await _context.SaveChangesAsync();

            foreach(var item in newFieldList.fields)
            {
                if (item.Id != 0)
                {
                    FormField ff = new FormField
                    {
                        IdField = item.Id,
                        IdForm = newFieldList.FormId
                    };

                    _context.FormField.Add(ff);
                }
                //nie istnieje pole
                else
                {
                    Field newField = new Field
                    {
                        Name = item.Name,
                        Type = item.Type
                    };
                    _context.Field.Add(newField);
                    _context.SaveChanges();
                    var thisField = _context.Field.Where(f => f == newField).ToList()[0];
                    FormField ff = new FormField
                    {
                        IdField = thisField.Id,
                        IdForm = newFieldList.FormId
                    };
                    _context.FormField.Add(ff);
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Formularz", "Forms", new { id = newFieldList.FormId });

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
