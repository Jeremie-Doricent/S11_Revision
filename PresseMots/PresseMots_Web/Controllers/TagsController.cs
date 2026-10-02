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
              return View(_context.tags);
        }

        // GET: Tags/Create
        public IActionResult Create()
        {
            Tag tag = new Tag();
           
            return View();
        }

        // POST: Tags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Tag tag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tag);
                _context.SaveChanges();
                TempData["Success"] = $"Zombie {tag.Name} added";
                return this.RedirectToAction("Index"); ;
                /*?*/
            }
            return View(_context.Add(tag));
        }

        // GET: Tags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            /*..?*/
            Tag? tag = _context.tags.Find(id);
            if (tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }

        // POST: Tags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*...*/
            Tag? tag = _context.tags.Find(id);
            if (tag == null)
            {
                return NotFound();
            }

            _context.tags.Remove(tag);
            _context.SaveChanges();
            TempData["Success"] = $"ZombieType {tag.Name} has been removed";
            return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}
