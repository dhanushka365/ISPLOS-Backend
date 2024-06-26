﻿using Core.Entities.OrderAggregate;
using Core.Entities;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Identity;

namespace API.Dtos
{
    public class OrderDto
    {
        [Required]
        public Guid Id { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public Guid UserID { get; set; }
        public User User { get; set; }


        public bool IsPaid { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
