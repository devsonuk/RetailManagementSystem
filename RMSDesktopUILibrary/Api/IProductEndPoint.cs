using RMSDesktopUILibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RMSDesktopUILibrary.Api
{
    public interface IProductEndPoint
    {
        Task<List<ProductModel>> GetAll();
    }
}