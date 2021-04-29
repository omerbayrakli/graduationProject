using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add(int id = 0)
        {
            Category categoryModel = new Category();
            return View(categoryModel);
        }

        [HttpPost]
        public IActionResult Add(Category categoryModel)
        {
            using(ProjectContext _context = new ProjectContext())
            {
                _context.Categories.Add(categoryModel);
                _context.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Addition Successful";
            return RedirectToAction("Index", "Home");
        }



    }
}