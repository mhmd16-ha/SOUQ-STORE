using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SOUQ_STORE.Models;
using System.Diagnostics;

namespace SOUQ_STORE.Controllers
{
    public class HomeController : Controller
    {
        //private readonly SOUQContext _context;

        //public HomeController(SOUQContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            SOUQContext _context = new SOUQContext();
             _context.Categories.ToList();
             _context.Products.ToList();

            return View(_context);
        }
        public IActionResult Product(int Id)
        { 
            SOUQContext _context = new SOUQContext();
            var result = _context.Products.Find(Id);
            return View(result);
        }
        public IActionResult Products(int id)
        {
            SOUQContext _context = new SOUQContext();
            var Result = _context.Products.Where(x => x.CatId == id).OrderByDescending(x => x.Name).ToList();
            return View(Result);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Categories()
        {
            SOUQContext _context = new SOUQContext();
           var Result=_context.Categories.ToList();
            return View(Result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}