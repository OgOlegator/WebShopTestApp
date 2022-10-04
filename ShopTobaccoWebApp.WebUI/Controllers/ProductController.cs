using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopTobaccoWebApp.Domain.Abstract;
using ShopTobaccoWebApp.Domain.Entities;
using ShopTobaccoWebApp.WebUI.Models;

namespace ShopTobaccoWebApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public int pageSize = 5;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, string searchString, int page = 1)
        {
            var model = new ProductsListViewModel
            {
                Products = repository.Products
                                        .Where(x => category == null || x.Category == category)
                                        .Where(x => searchString == null || x.Name.Contains(searchString))
                                        .OrderBy(x => x.ProductId)
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null && searchString == null?
                        repository.Products.Count() :
                        repository.Products
                        .Where(product => category != null && product.Category == category)
                        .Where(product => searchString != null && product.Name.Contains(searchString))
                        .Count()
                },
                CurrentCategory = category,
                SearchProduct = searchString
            };

            return View(model);
        }
    }
}