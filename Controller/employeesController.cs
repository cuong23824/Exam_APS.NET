using Exam.Entities;
using Exam.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controller
{
    public class employeesController : Controller
    {
        private readonly DataContext _context;

        public employeesController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<employees> ls = _context.Employees.ToList();
            return View(ls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(employeesModel model)
        {
            if (ModelState.IsValid)
            {

                _context.Employees.Add(new employees { employeeName = model.employeeName, departmenCode = model.departmenCode });
                _context.SaveChanges();


                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
