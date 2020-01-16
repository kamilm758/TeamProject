using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        public  JsonResult PatientForms(int id)
        {
           var patientForms =  _context.PatientForms.Where(m => m.IdPatient == id).ToList();

            List<PatientFormsHelper> list = new List<PatientFormsHelper>();

            foreach (PatientForms x in patientForms)
            {
                PatientFormsHelper pom = new PatientFormsHelper
                {
                    Id = x.Id,
                    IdForm = x.IdForm,
                    IdPatient = x.IdPatient,
                    nazwa_formularza = _context.Forms.FirstOrDefault(n => n.Id == x.IdForm).Name
                };
                list.Add(pom);
            }
           

            return Json(list);
        }



        [HttpGet]
        public IActionResult Create()
        {
            HttpContext.Session.SetString("lista", "ch");
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