﻿namespace ProductAPI.Models
{
    public class ProductDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
