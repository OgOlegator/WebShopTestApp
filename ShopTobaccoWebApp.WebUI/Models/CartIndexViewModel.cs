﻿using ShopTobaccoWebApp.Domain.Entities;

namespace ShopTobaccoWebApp.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}