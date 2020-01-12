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

        public async Task<IActionResult> PatientForms()
        {
            return View(await _context.PatientForms.ToListAsync());
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPatient")] Patient patient)
        {
            int y = patient.IdPatient; 
            if (ModelState.IsValid)
            {
                _context.Patients.Add(patient);

                var formsId =  _context.Forms;

                foreach(var x in formsId)
                {
                    PatientForms patientForms = new PatientForms();
                    patientForms.IdPatient = patient.IdPatient;
                    patientForms.IdForm = x.Id;
                    _context.PatientForms.Add(patientForms);
                }
                _context.SaveChanges();

            }
            return View();
        }
    }
}