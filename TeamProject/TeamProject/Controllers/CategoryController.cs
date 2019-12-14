using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TeamProject.Controllers
{
    public class CategoryController : Controller
    {

        private readonly FormGeneratorContext _context;

        public CategoryController(FormGeneratorContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        // POST: Forms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,id_Category,Parent")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ListaKategorii));
            }
            return View();
        }
        public async Task<IActionResult> ListaKategorii()
        {
            return View(await _context.Categories.ToListAsync());
        }
        [HttpPost]
        public JsonResult GetList(string order)
        {
            return Json(_context.Categories.ToList());
        }
        [HttpPost]
        public JsonResult GetDzieci(string order)
        {
            int id = Convert.ToInt32(order);
            var result = _context.Categories.Where(m => m.Parent == id).ToList();
            return Json(result);
        }
    }
}