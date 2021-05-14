using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;

namespace RMSDataManager.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            var userId = RequestContext.Principal.Identity.GetUserId();
            var data = new List<int>() { 1, 2, 3, 4, 5 };
            return new string[] { "value1", "value2", userId };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
