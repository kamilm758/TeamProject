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

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @patient = await _context.Patients
                .FirstOrDefaultAsync(m => m.IdPatient == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }
        //[HttpPost]
        public async Task<ActionResult> Index(string Id)
        {

           var patient = from m in _context.Patients select m;

            //   if (Id)
            // {
            //       patient = patient.Where(s => s.IdPatient.Equals(Id));
            //}

            var IdPatient = _context.Patients;

            
                
                var pom = await IdPatient.FirstOrDefaultAsync(m => m.IdPatient == Convert.ToInt32(Id));

                if(pom != null)
                {
                    TempData["Message"] = "znalazlo";
                    return RedirectToAction("PatientForms");
                }
                else
                {
                    TempData["Messagenie"]="Id pacjetna nie znajduje się w bazie";
                }

                
                
            

            return View(await _context.Patients.ToListAsync());
        }


    }
}