using AdminPanel.Models;
using AdminPanel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Properties = _context.Properties.ToList();

            return View(Properties);
        }
        public IActionResult Create()
        {
            var viewModel = new PropertyFormViewModel
            {
                Categories = _context.Categories.ToList()
            };
            return View("PropertyForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PropertyFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _context.Categories.ToList();
                return View("PropertyForm", model);
            }

            var Properties = new Property
            {
                Name = model.Name,
                CategoryId = model.CategoryId
            };

            _context.Properties.Add(Properties);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();

            var property = _context.Properties.Find(id);

            if (property == null)
                return NotFound();

            var viewModel = new PropertyFormViewModel
            {
                Id = property.Id,
                Name = property.Name,
                CategoryId = property.CategoryId,
                Categories = _context.Categories.ToList()
            };

            return View("PropertyForm", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PropertyFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _context.Categories.ToList();
                return View("PropertyForm", model);
            }

            var property = _context.Properties.Find(model.Id);

            if (property == null)
                return NotFound();

            property.Name = model.Name;
            property.CategoryId = model.CategoryId;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
