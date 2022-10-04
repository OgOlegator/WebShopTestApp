using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopTobaccoWebApp.Domain.Entities;

namespace ShopTobaccoWebApp.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

        public string SearchProduct { get; set; }
    }
}