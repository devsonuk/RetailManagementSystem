using RMSDataManager.Library.DataAccess;
using RMSDataManager.Library.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace RMSDataManager.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        // GET: api/Product
        public List<ProductModel> Get()
        {
            ProductData data = new ProductData();
            return data.GetProducts();
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
