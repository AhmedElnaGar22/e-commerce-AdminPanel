using AdminPanel.Models;
using AdminPanel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminPanel.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Categories = _context.Categories.ToList();
            return View(Categories);
        }
        public IActionResult Create()
        {
            var viewModel = new CategoryFormViewModel
            {
                Properites = _context.Properties.ToList()
            };
            return View("CategoryForm", viewModel);
        }
    }
}
