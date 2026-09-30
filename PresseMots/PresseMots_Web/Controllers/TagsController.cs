using System;
using System.Threading.Tasks;
using Azure;
using Microsoft.AspNetCore.Mvc;
using PresseMots.Models;
using PresseMots.Models.Data;

namespace PresseMots.Controllers
{
    public class TagsController : Controller
    {
        private readonly PresseMotsDbContext _context;

        public TagsController(PresseMotsDbContext context)
        {
            _context = context;
        }

        // GET: Tags
        public async Task<IActionResult> Index()
        {
              return View(/*...*/);
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Object model, [Bind("Id,Name")] Tag tag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tag);
                /*?*/
            }
            return View(_context.Add(tag));
        }

        // GET: Tags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            /*..?*/
            if (ModelState.IsValid)
            {
                _context.Remove(id);
                /*?*/
            }
            return View(_context.Remove(id));
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*...*/

            return RedirectToAction(nameof(Index));
        }
    }
}
