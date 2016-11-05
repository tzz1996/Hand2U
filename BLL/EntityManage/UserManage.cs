using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManage
{
    public class UserManage
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(Entity.User user)
        {
            string sqlStr = @"INSERT INTO [User]
           ([userName]
           ,[userNickname]
           ,[sex]
           ,[userSchool]
           ,[grade]
           ,[email]
           ,[userImage]
           ,[password]
           ,[creditRate]
           ,[phoneNumber]
           ,[personalSignature]
           ,[registrationDate]
           ,[userType])
     VALUES
           (
            @userName,
           ,@userNickname
           ,@sex
           ,@userSchool
           ,@grade
           ,@email
           ,@userImage
           ,@password
           ,@creditRate
           ,@phoneNumber
           ,@personalSignature
           ,@registrationDate
           ,@userType)";
            SqlParameter[] paras =
            {
                new SqlParameter("@userName", user.UserName),
                new SqlParameter("@userNickname", user.UserNickName),
                new SqlParameter("@sex", user.Sex),
                new SqlParameter("@userSchool", user.UserSchool),
                new SqlParameter("@grade", user.UserGrade),
                new SqlParameter("@email", user.UserEmail),
                new SqlParameter("@phoneNumber", user.UserId),
                new SqlParameter("@userImage",user.UserImage), 
                new SqlParameter("@password",user.PassWord), 
                new SqlParameter("@creditRate",user.CreditRate), 
                new SqlParameter("@personalSignature", user.PersonalSign),
                new SqlParameter("@registrationDate", user.RegistrationDate),
                new SqlParameter("@userType", user.UserType),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 查询用户信息（用户ID，ID即数据库中的电话号码）
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataSet SearchUser(string userId)
        {
            string sqlStr = @"SELECT [userName]
                      ,[userNickname]
                      ,[sex]
                      ,[userSchool]
                      ,[grade]
                      ,[email]
                      ,[userImage]
                      ,[password]
                      ,[creditRate]
                      ,[phoneNumber]
                      ,[personalSignature]
                      ,[registrationDate]
                      ,[userType]
                  FROM [User] where phoneNumber=@userId";
            SqlParameter[] paras =
            {
                new SqlParameter("@userId", userId),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询用户信息（账号，密码）
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        public DataSet SearchUser(string userId, object userPwd)
        {
            string sqlStr = @"SELECT [userName]
                      ,[userNickname]
                      ,[sex]
                      ,[userSchool]
                      ,[grade]
                      ,[email]
                      ,[userImage]
                      ,[password]
                      ,[creditRate]
                      ,[phoneNumber]
                      ,[personalSignature]
                      ,[registrationDate]
                      ,[userType]
                  FROM [User] where phoneNumber=@userId and password=@userPwd";
            SqlParameter[] paras =
            {
                new SqlParameter("@userId", userId),
                new SqlParameter("@userPwd", userPwd),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }
        /// <summary>
        /// 查询用户信息（通过用户昵称）
        /// </summary>
        /// <param name="userNickName"></param>
        /// <param name="nothing1"></param>
        /// <param name="nothing2"></param>
        /// <returns></returns>
        public DataSet SearchUser(string userNickName, object nothing1,object nothing2)
        {
            string sqlStr = @"SELECT [userName]
                      ,[userNickname]
                      ,[sex]
                      ,[userSchool]
                      ,[grade]
                      ,[email]
                      ,[userImage]
                      ,[password]
                      ,[creditRate]
                      ,[phoneNumber]
                      ,[personalSignature]
                      ,[registrationDate]
                      ,[userType]
                  FROM [User] where userNickname=@userNickname";
            SqlParameter[] paras =
            {
                new SqlParameter("@userNickname", userNickName),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 修改用户数据
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int EditUserInfo(Entity.User user)
        {
            string sqlStr = @"UPDATE [User]
                       SET [userName] = @userName
                          ,[userNickname] = @userNickname
                          ,[sex] = @sex
                          ,[userSchool] = @userSchool
                          ,[grade] = @grade
                          ,[email] = @email
                          ,[userImage] = @userImage
                          ,[password]=@password
                          ,[creditRate]=@creditRate
                          ,[personalSignature] = @personalSignature
                          ,[registrationDate] = @registrationDate
                          ,[userType] = @userType
                     WHERE phoneNumber = @userId";
            SqlParameter[] paras =
            {
                new SqlParameter("@userName", user.UserName),
                new SqlParameter("@userNickname", user.UserNickName),
                new SqlParameter("@sex", user.Sex),
                new SqlParameter("@userSchool", user.UserSchool),
                new SqlParameter("@grade", user.UserGrade),
                new SqlParameter("@email", user.UserEmail),
                new SqlParameter("@userImage", user.UserImage),
                new SqlParameter("@password", user.PassWord),
                new SqlParameter("@creditRate", user.CreditRate),
                new SqlParameter("@personalSignature", user.PersonalSign),
                new SqlParameter("@registrationDate", user.RegistrationDate),
                new SqlParameter("@userType", user.UserType),
                new SqlParameter("@userId", user.UserId),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int DeleUser(string userId)
        {
            string sqlStr = @"DELETE FROM [User]
                    WHERE phoneNumber = @userId";
            SqlParameter[] paras =
            {
                new SqlParameter("@userId", userId)
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }
    }
}
