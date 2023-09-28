using Core.Entities.Identity;
using Core.Entities.OrderAggregate;
using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RequestOrderDto
    {

        [Required]
        public List<OrderProductDTO> Order { get; set;}

        
    }
}
