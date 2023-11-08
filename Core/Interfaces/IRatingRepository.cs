using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    internal class IRatingRepository
    {
        Task<Rating> CreateRatingAsync(Rating rating);
        Task<List<Rating>> GetRatingAsync();
    }
}
