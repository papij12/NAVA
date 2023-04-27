using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(int userId, string userEmail, string userName)
        {
            UsersModel data = new UsersModel
            {
                UserId = userId,
                UserEmail = userEmail,
                UserName = userName

            };

            string sql = @"insert into dbo.Users (UserId, UserEmail, UserName)
                          values(@UserId,@UserEmail,@UserName);";
            return SqlDataAccess.SaveData(sql, data);
        }
       public static List<UsersModel> LoadUsers()
        {
            string sql = @"select Id, UserId, UserEmail, UserName
                           from dbo.Users;";

            return SqlDataAccess.LoadData<UsersModel>(sql);
        }
    }
}
