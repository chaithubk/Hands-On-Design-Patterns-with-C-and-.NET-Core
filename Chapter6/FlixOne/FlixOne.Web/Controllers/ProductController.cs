﻿using System;
using FlixOne.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlixOne.Web.Controllers
{
    public class ProductController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Details(Guid id)
        {
            return View();
        }

       
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       public IActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private Product ToProductModel(ProductViewModel productvm)
        {
            return new Product
            {
                CategoryId = productvm.CategoryId,
                Description = productvm.ProductDescription,
                Id = productvm.ProductId,
                Name = productvm.ProductName,
                Price = productvm.ProductPrice
            };
        }

        private ProductViewModel ToProductvm(Product productModel)
        {
            return new ProductViewModel
            {
                CategoryId = productModel.CategoryId,
                CategoryDescription = productModel.Category.Description,
                CategoryName = productModel.Category.Name,
                ProductDescription = productModel.Description,
                ProductId = productModel.Id,
                ProductImage = productModel.Image,
                ProductName = productModel.Name,
                ProductPrice = productModel.Price
            };
        }
    }
}