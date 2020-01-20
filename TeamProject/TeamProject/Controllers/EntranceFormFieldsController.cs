using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FormGenerator.Models;
using FormGenerator.Models.Modele_pomocnicze;

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
            var entrance_form = _context.EntranceFormFields
                .Select(t => t.IdField)
                .ToList();
            var entrance_q = _context.Field
                .Where(t => entrance_form.Contains(t.Id))
                .ToList();
            
            return View(entrance_q);
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
        public async Task<IActionResult> Create([Bind("Id,Name,Type")] Field @field)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@field);
                await _context.SaveChangesAsync();
                Field current = _context.Field.Where(t => t == (@field)).ToList()[0];
                var entrance_field = new EntranceFormFields();
                entrance_field.IdField = current.Id;
                _context.Add(entrance_field);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@field);
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


        public async Task<IActionResult> EntranceForm()
        { 
            var entrance_form = _context.EntranceFormFields
                .Select(t => t.IdField)
                .ToList();
            var entrance_q = _context.Field
                .Where(t => entrance_form.Contains(t.Id))
                .ToList();
            List<EntranceFormAnswers> list = new List<EntranceFormAnswers>();
            EntranceFormAnswers ans; new EntranceFormAnswers();
            foreach(var elem in entrance_q)
            {
                ans = new EntranceFormAnswers();
                ans.IdField = elem.Id;
                ans.Name = elem.Name;
                list.Add(ans);
            }

            return View(list);
        }

        [HttpPost]
        public ActionResult EntranceForm(List<EntranceFormAnswers> tuple_list)
        {
            List<EntranceFormAnswers> tuple = tuple_list;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddConnection (int id)
        {
            ViewBag.bag = id;
            return View(_context.EntranceConnections.Where(m => m.IdField == id).ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddConnection([Bind("Id,IdField,IdForm")] EntranceConnections @entranceConnections)
        {
            if (ModelState.IsValid)
            {
                _context.EntranceConnections.Add(@entranceConnections);
                await _context.SaveChangesAsync();
                EntranceConnections current = _context.EntranceConnections.Where(t => t == (@entranceConnections)).ToList()[0];
              
                return View(_context.EntranceConnections.Where(m => m.IdField == current.IdField).ToList());
            }
            return RedirectToAction(nameof(Index));

        }
    }
}
