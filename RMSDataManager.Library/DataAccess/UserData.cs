using RMSDataManager.Library.Internal.DataAccess;
using RMSDataManager.Library.Models;

namespace RMSDataManager.Library.DataAccess
{
    public class UserData
    {
        public UserModel GetUserById(string id)
        {
            var sql = new SqlDataAccess();

            var p = new { Id = id };

            var result = sql.LoadSingle<UserModel, dynamic>("[dbo].[usp_GetUser]", p, "RMSData");
            return result;
        }

    }
}
