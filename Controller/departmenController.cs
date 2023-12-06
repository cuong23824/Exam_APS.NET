using Exam.Entities;
using Exam.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Controller
{
    public class departmenController : Controller
    {
        private readonly DataContext _context;

        public departmenController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<departmen> ls = _context.Departmens.ToList();
            return View(ls);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(departmenModel model)
        {
            if (ModelState.IsValid)
            {
                
                _context.Departmens.Add(new departmen { departmenName = model.departmenName });
                _context.SaveChanges();

                
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int departmenCode)
        {
            departmen departmen = _context.Departmens.Find(departmenCode);
            if (departmen == null)
                return NotFound();
            return View(new departmenModel { departmenCode = departmen.departmenCode, departmenName = departmen.departmenName }); ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(departmenModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Departmens.Update(new departmen
                {
                    departmenCode = model.departmenCode,
                    departmenName = model.departmenName
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }

        public IActionResult Delete(int id)
        {
            departmen departmen = _context.Departmens.Find(departmenCode);
            if (departmen == null)
                return NotFound();
            _context.Departmens.Remove(departmen);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
