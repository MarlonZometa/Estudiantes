using CRUDOperationsDemo;
using CURDOprationsDimo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CURDOprationsDimo.Controllers
{
    public class EstudiantesController : Controller
    {
        private readonly CRUDDbContext _context;
        private readonly IWebHostEnvironment env;

        public EstudiantesController(CRUDDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            this.env = env;
        }
        public IActionResult Index()
        {
           var Result= _context.Estudiantes.Include(x=>x.Carrera)
                .OrderBy(x=>x.EstudiantesName).ToList();    
            return View(Result);
        }
        public IActionResult Create()
        {
            ViewBag.Carrera = _context.Carrera.OrderBy(x => x.CarreraName).ToList();
            return View();
        }
        public IActionResult Edit(int? Id)
        {
            ViewBag.Carrera = _context.Carrera.OrderBy(x => x.CarreraName).ToList();
            var result = _context.Estudiantes.Find(Id);
            return View("Create", result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.Estudiante model)
        {
            
            if (ModelState.IsValid)
            {
                _context.Estudiantes.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Carrera = _context.Carrera.OrderBy(x => x.CarreraName).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Models.Estudiante model)
        {

            if (model != null)
            {
                _context.Estudiantes.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Carrera = _context.Carrera.OrderBy(x => x.CarreraName).ToList();
            return View();
        }


        public IActionResult Delete(int? Id)
        {
            var result = _context.Estudiantes.Find(Id);
            if (result != null)
            {
                _context.Estudiantes.Remove(result);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
