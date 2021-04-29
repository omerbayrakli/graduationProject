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
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int category)
        {
            var model = new ProductListViewModel
            {
                Products = category > 0 ? _productService.GetByCategory(category) : _productService.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Add(int id = 0)
        {
            Product productModel = new Product();
            return View(productModel);
        }

        [HttpPost]
        public IActionResult Add(Product productModel)
        {
            using (ProjectContext _context = new ProjectContext())
            {
                _context.Products.Add(productModel);
                _context.SaveChanges();
            }

            ModelState.Clear();
            ViewBag.SuccessMessage = "Addition Successful";
            return RedirectToAction("Index", "Home");
        }

       
    }
}