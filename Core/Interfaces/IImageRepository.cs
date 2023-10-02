using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IImageRepository : IGenericRepository<Image>
    {
        Task<Image> UploadImage(Image image);
    }
}
