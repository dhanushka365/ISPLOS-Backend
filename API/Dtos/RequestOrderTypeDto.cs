﻿using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestOrderTypeDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
