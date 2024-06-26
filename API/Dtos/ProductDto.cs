﻿using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(0.10, 10000)]
        public decimal Price { get; set; }

        [Required]
        public string PictureUrl { get; set; }
    }
}
