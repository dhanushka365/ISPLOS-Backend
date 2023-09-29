using Core.Entities.OrderAggregate;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; set; }


        public string PictureUrl { get; set; }


        //public Guid ProductTypeId { get; set; }
        //public ProductType ProductType { get; set; }


        //public Guid ProductBrandId { get; set; }
        //public ProductBrand ProductBrand { get; set; }

        public IList<OrderProduct> OrderProducts { get; set; } 

        public DateTime CreatedAt { get; set; } 
        public DateTime UpdatedAt { get; set; }

    }
}
