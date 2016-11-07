using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManage
{
    class PostManage
    {
        /// <summary>
        /// 添加帖子
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public int AddPost(Entity.Post post)
        {
            string sqlStr = @"INSERT INTO [Post]
                ([postTitle]
                ,[postType]
                ,[postContent]
                ,[postData]
                ,[isReplyType]
                ,[postID]
                ,[phoneNumber]
                ,[postNote])
            VALUES 
                (
                @postTitle
                ,@postType
                ,@postContent
                ,@postData
                ,@isReplyType
                ,@postID
                ,@phoneNumber
                ,@postNote)";
            SqlParameter[] paras =
            {
                new SqlParameter("@postTitle", post.PostTitle),
                new SqlParameter("@postType", post.PostType),
                new SqlParameter("@postContent", post.PostContent),
                new SqlParameter("@postData", post.PostDate),
                new SqlParameter("@isReplyType", post.IsReplyType),
                new SqlParameter("@postID", post.PostId),
                new SqlParameter("@phoneNumber", post.UserId),
                new SqlParameter("@postNote", post.PostNote),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 查询帖子信息（帖子ID，即数据库中postID）
        /// </summary>
        /// <param name="post_id"></param>
        /// <returns></returns>
        public DataSet SearchPost(string post_id)
        {
            string sqlStr = @"SELECT [postTitle]
                ,[postType]
                ,[postContent]
                ,[postDate]
                ,[isReplyType]
                ,[postID]
                ,[phoneNumber]
                ,[postNote]
            FROM [Post] WHERE postID = @postID";
            SqlParameter[] paras =
            {
                new SqlParameter("@postID", post_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询帖子信息（帖子ID，即数据库中的postID；用户ID/userID，即数据库中的phoneNumber）
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="post_id"></param>
        /// <returns></returns>
        public DataSet SearchPost(string post_id, string user_id)
        {
            string sqlStr = @"SELECT [postTitle]
                ,[postType]
                ,[postContent]
                ,[postDate]
                ,[isReplyType]
                ,[postID]
                ,[phoneNumber]
                ,[postNote]
            FROM [Post] WHERE postID = @postID AND phoneNumber = @phoneNumber";
            SqlParameter[] paras =
            {
                new SqlParameter("@postID", post_id),
                new SqlParameter("@phoneNumber", user_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 修改帖子数据
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public int EditPostInfo(Entity.Post post)
        {
            string sqlStr = @"UPDATE [Post]
                SET [postTitle] = @postTitle
                ,[postType] = @postType
                ,[postContent] = @postContent
                ,[postDate] = @postDate
                ,[isReplyType] = @isReplyType
                ,[postID] = @postID
                ,[phoneNumber] = @phoneNumber
                ,[postNote] = @postNote
            WHERE postID = @postID";
            SqlParameter[] paras =
           {
                new SqlParameter("@postTitle", post.PostTitle),
                new SqlParameter("@postType", post.PostType),
                new SqlParameter("@postContent", post.PostContent),
                new SqlParameter("@postDate", post.PostDate),
                new SqlParameter("@isReplyType", post.IsReplyType),
                new SqlParameter("@postID", post.PostId),
                new SqlParameter("@phoneNumber", post.UserId),
                new SqlParameter("@postNote", post.PostNote),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="post_id"></param>
        /// <returns></returns>
        public int DelePost(string post_id)
        {
            string sqlStr = @"DELETE FROM [Post]
                    WHERE postID = @postID";
            SqlParameter[] paras =
            {
                new SqlParameter("@postID", post_id)
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

    }
}
