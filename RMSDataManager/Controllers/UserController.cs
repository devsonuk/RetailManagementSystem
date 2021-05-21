using Microsoft.AspNet.Identity;
using RMSDataManager.Library.DataAccess;
using RMSDataManager.Library.Models;
using System.Web.Http;

namespace RMSDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {

        // GET api/<controller>
        public UserModel Get()
        {
            var userId = RequestContext.Principal.Identity.GetUserId();
            var data = new UserData();
            return data.GetUserById(userId);

        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}