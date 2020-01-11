using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamProject.Models.FormGeneratorModels;

namespace TeamProject.Controllers
{
    public class PatientController : Controller
    {

        private readonly FormGeneratorContext _context;

        public PatientController(FormGeneratorContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddPatient()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Patients.Add(patient);

                var formsId =  _context.Forms;

            }
            return View();
        }
    }
}