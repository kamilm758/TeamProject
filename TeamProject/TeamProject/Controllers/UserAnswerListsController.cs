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
    public class UserAnswerListsController : Controller
    {
        private readonly FormGeneratorContext _context;

        public UserAnswerListsController(FormGeneratorContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> AnswerList(int? id)
        {
            if (id == null) return NotFound();
            var usersAnswers = _context.UserAnswers
                .Where(m => m.IdForm.Equals(id))
                .ToList();
            List<UserAnswerList> answersList = new List<UserAnswerList>();
            bool exist = false;
            int idx = -1;
            UserAnswerList newUAL;
            foreach (var elem in usersAnswers)
            {
                for(int i = 0; i<answersList.Count; i++)
                {
                    if (answersList[i].Id_User.Equals(elem.IdUser))
                    {
                        idx = i;
                        exist = true;
                    }
                }
                if(!exist)
                {
                    newUAL = new UserAnswerList();
                    newUAL.Id_User = elem.IdUser;
                    newUAL.user_answer_list.Add(elem);
                    answersList.Add(newUAL);
                }
                else
                {
                    answersList[idx].user_answer_list.Add(elem);
                }
            }
            /*UserAnswerList usersAnswersList;
            foreach (var elem in usersAnswers)
            {
                if (!elem.IdForm.Equals(id)) continue;
                usersAnswersList = _context.UserAnswerList
                    .Where(m => m.Id_User.Equals(elem.IdUser))
                    .FirstOrDefault();

                if (usersAnswersList == null)
                {
                    usersAnswersList = new UserAnswerList();
                    usersAnswersList.Id_User = elem.IdUser;
                    Models.FormGeneratorModels.UserAnswers tmp = new Models.FormGeneratorModels.UserAnswers();
                    tmp = elem;
                    usersAnswersList.user_answer_list.Add(tmp);
                    _context.Add(usersAnswersList);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var flag = false;
                    Models.FormGeneratorModels.UserAnswers tmp = new Models.FormGeneratorModels.UserAnswers();
                    tmp = elem;
                    foreach (var i in usersAnswersList.user_answer_list)
                    {
                        if (i.Id.Equals(tmp.Id)) flag = true;
                    }
                    if (!flag)
                    {
                        usersAnswersList.user_answer_list.Add(tmp);
                        _context.Update(usersAnswersList);
                        await _context.SaveChangesAsync();
                    }
                }
                
            }*/
            var _form = _context.FormField
                    .Where(m => m.IdForm.Equals(id))
                    .Select(m => m.IdField)
                    .ToList();

            var _fields = _context.Field
                .Where(m => _form.Contains(m.Id))
                .ToList();

            ViewBag.Fields = _fields;
            ViewBag.FormId = id;

            var xD = await _context.UserAnswerList
                .Where(m => m.user_answer_list.Count > 0)
                .ToListAsync();

            return View(answersList);
        }

        // GET: UserAnswerLists
        public async Task<IActionResult> Index()
        {
            var usersAnswers = _context.UserAnswers.ToList();
            var usersAnswersList = new UserAnswerList();
            foreach (var elem in usersAnswers)
            {
                usersAnswersList = _context.UserAnswerList
                    .Where(m => m.Id_User.Equals(elem.IdUser))
                    .FirstOrDefault();
                if (usersAnswersList == null)
                {
                    usersAnswersList = new UserAnswerList();
                    usersAnswersList.Id_User = elem.IdUser;
                    Models.FormGeneratorModels.UserAnswers tmp = new Models.FormGeneratorModels.UserAnswers();
                    tmp = elem;
                    usersAnswersList.user_answer_list.Add(tmp);
                    _context.Add(usersAnswersList);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    var flag = false;
                    Models.FormGeneratorModels.UserAnswers tmp = new Models.FormGeneratorModels.UserAnswers();
                    tmp = elem;
                    foreach (var i in usersAnswersList.user_answer_list)
                    {
                        if (i.Id.Equals(tmp.Id)) flag = true;
                    }
                    if (!flag)
                    {
                        usersAnswersList.user_answer_list.Add(tmp);
                        _context.Update(usersAnswersList);
                        await _context.SaveChangesAsync();
                    }
                }

            }
            return View(await _context.UserAnswerList.ToListAsync());
        }

        // GET: UserAnswerLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAnswerList = await _context.UserAnswerList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userAnswerList == null)
            {
                return NotFound();
            }

            return View(userAnswerList);
        }

        // GET: UserAnswerLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserAnswerLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_User,Name")] UserAnswerList userAnswerList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userAnswerList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userAnswerList);
        }

        // GET: UserAnswerLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAnswerList = await _context.UserAnswerList.FindAsync(id);
            if (userAnswerList == null)
            {
                return NotFound();
            }
            return View(userAnswerList);
        }

        // POST: UserAnswerLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_User,Name")] UserAnswerList userAnswerList)
        {
            if (id != userAnswerList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userAnswerList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserAnswerListExists(userAnswerList.Id))
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
            return View(userAnswerList);
        }

        // GET: UserAnswerLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userAnswerList = await _context.UserAnswerList
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userAnswerList == null)
            {
                return NotFound();
            }

            return View(userAnswerList);
        }

        // POST: UserAnswerLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userAnswerList = await _context.UserAnswerList.FindAsync(id);
            _context.UserAnswerList.Remove(userAnswerList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserAnswerListExists(int id)
        {
            return _context.UserAnswerList.Any(e => e.Id == id);
        }
    }
}
