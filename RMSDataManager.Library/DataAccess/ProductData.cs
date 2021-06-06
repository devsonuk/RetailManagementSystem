using RMSDataManager.Library.Internal.DataAccess;
using RMSDataManager.Library.Models;
using System.Collections.Generic;

namespace RMSDataManager.Library.DataAccess
{
    public class ProductData
    {
        public List<ProductModel> GetProducts()
        {
            var sql = new SqlDataAccess();
            var result = sql.LoadData<ProductModel, dynamic>("[dbo].[usp_GetProducts]", new { }, "RMSData");
            return result;
        }
    }
}
