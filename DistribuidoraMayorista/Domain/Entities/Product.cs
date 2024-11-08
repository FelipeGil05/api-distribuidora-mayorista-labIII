﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public required string ProductBrand { get; set; }
        public required string ProductDetail { get; set; }
        public int ProductPrice { get; set; }
        public string? ProductImageUrl { get; set; }
        public required string ProductCategory { get; set; }
    }
}
