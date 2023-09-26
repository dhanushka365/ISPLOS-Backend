﻿using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.10, 10000)]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public ProductType ProductType { get; set; }

        [Required]
        public Guid ProductTypeId { get; set; }

        [Required]
        public ProductBrand ProductBrand { get; set; }

        [Required]
        public Guid ProductBrandId { get; set; }



    }
}
