﻿using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestLoginDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
