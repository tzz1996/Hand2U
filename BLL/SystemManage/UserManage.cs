using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SystemManage
{
    public class UserManage
    {
        /// <summary>
        /// 登陆，用户输入账号、密码
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Entity.User Login(Entity.User user)
        {
            EntityManage.UserManage userManage = new EntityManage.UserManage();
            DataSet ds = userManage.SearchUser(user.UserId, user.PassWord);
            if (ds.Tables[0].Rows.Count == 0)
            {
                user = null;
            }
            else
            {
                user.UserName = Convert.ToString(ds.Tables[0].Rows[0]["userName"]);
                user.UserNickName = Convert.ToString(ds.Tables[0].Rows[0]["userNickname"]);
                user.Sex = Convert.ToInt32(ds.Tables[0].Rows[0]["sex"]);
                user.UserSchool = ds.Tables[0].Rows[0]["userSchool"].ToString();
                user.UserGrade = Convert.ToInt32(ds.Tables[0].Rows[0]["grade"]);
                user.UserEmail = Convert.ToString(ds.Tables[0].Rows[0]["email"]);
                user.UserImage = (byte[])(ds.Tables[0].Rows[0]["userImage"]);
                user.PassWord = Convert.ToString(ds.Tables[0].Rows[0]["password"]);
                user.CreditRate = Convert.ToInt32(ds.Tables[0].Rows[0]["creditRate"]);
                user.UserId = Convert.ToString(ds.Tables[0].Rows[0]["phoneNumber"]);
                user.PersonalSign = Convert.ToString(ds.Tables[0].Rows[0]["personalSignature"]);
                user.RegistrationDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["registrationDate"]);
                user.UserType = Convert.ToInt32(ds.Tables[0].Rows[0]["userType"]);
            }
            return user;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Register(Entity.User user)
        {
            var en = new BLL.Common.MD5Encrypt();
            user.PassWord = en.MD5_Encrypt(user.PassWord, 32);
            var addUserManage=new EntityManage.UserManage();
            return addUserManage.AddUser(user);
        }
    }
}
