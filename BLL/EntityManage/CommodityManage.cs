using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManage
{
    class CommodityManage
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        /// <param name="commodity"></param>
        /// <returns></returns>
        public int AddCommodity(Entity.Commodity commodity)
        {
            string sqlStr = @"INSERT INTO [Commodity]
                ([commodityID]
                ,[phoneNumber]
                ,[commodityName]
                ,[commodityDescription]
                ,[commodityType]
                ,[originalPrice]
                ,[estimatePrice]
                ,[commodityNumber]
                ,[degrees]
                ,[commodityImage1]
                ,[commodityImage2]
                ,[commodityImage3]
                ,[commodityNote]
                ,[launchDate])
            VALUES
                (
                @commodityID
                ,@phoneNumber
                ,@commodityName
                ,@commodityDescription
                ,@commodityType
                ,@originalPrice
                ,@estimatePrice
                ,@commodityNumber
                ,@degrees
                ,@commodityImage1
                ,@commodityImage2
                ,@commodityImage3
                ,@commodityNote
                ,@launchDate)";
            SqlParameter[] paras =
           {
                new SqlParameter("@commodityID", commodity.CommodityId),
                new SqlParameter("@phoneNumber", commodity.UserId),
                new SqlParameter("@commodityName", commodity.CommodityName),
                new SqlParameter("@commodityDescription", commodity.CommodityDescription),
                new SqlParameter("@commodityType", commodity.CommodityType),
                new SqlParameter("@originalPrice", commodity.OriginalPrice),
                new SqlParameter("@estimatePrice", commodity.EstimateMoney),
                new SqlParameter("@commodityNumber", commodity.CommodityNumber),
                new SqlParameter("@degrees", commodity.Degress),
                new SqlParameter("@commodityImage1", commodity.CommodityImage1),
                new SqlParameter("@commodityImage2", commodity.CommodityImage2),
                new SqlParameter("@commodityImage3", commodity.CommodityImage3),
                new SqlParameter("@commodityNote", commodity.CommodityNote),
                new SqlParameter("@launchDate", commodity.LaunchDate),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品信息（商品ID，即数据库中的commodityID）
        /// </summary>
        /// <param name="commodity_id"></param>
        /// <returns></returns>
        public DataSet SearchCommodityById(string commodity_id)
        {
            string sqlStr = @"SELECT [commodityID]
                ,[phoneNumber]
                ,[commodityName]
                ,[commodityDescription]
                ,[commodityType]
                ,[originalPrice]
                ,[estimatePrice]
                ,[commodityNumber]
                ,[degrees]
                ,[commodityImage1]
                ,[commodityImage2]
                ,[commodityImage3]
                ,[commodityNote]
                ,[launchDate]
            FROM [Commodity] WHERE commodityID = @commodity_id";
            SqlParameter[] paras =
           {
                new SqlParameter("@commodity_id", commodity_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品信息（用户ID，即数据库中的phoneNumber）
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        public DataSet SearchCommodityByUserId(string user_id)
        {
            string sqlStr = @"SELECT [commodityID]
                ,[phoneNumber]
                ,[commodityName]
                ,[commodityDescription]
                ,[commodityType]
                ,[originalPrice]
                ,[estimatePrice]
                ,[commodityNumber]
                ,[degrees]
                ,[commodityImage1]
                ,[commodityImage2]
                ,[commodityImage3]
                ,[commodityNote]
                ,[launchDate]
            FROM [Commodity] WHERE phoneNumber = @user_id";
            SqlParameter[] paras =
           {
                new SqlParameter("@user_id", user_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品信息（商品名称，即数据库中的commodityName）
        /// </summary>
        /// <param name="commodity_name"></param>
        /// <returns></returns>
        public DataSet SearchCommodityByName(string commodity_name)
        {
            string sqlStr = @"SELECT [commodityID]
                ,[phoneNumber]
                ,[commodityName]
                ,[commodityDescription]
                ,[commodityType]
                ,[originalPrice]
                ,[estimatePrice]
                ,[commodityNumber]
                ,[degrees]
                ,[commodityImage1]
                ,[commodityImage2]
                ,[commodityImage3]
                ,[commodityNote]
                ,[launchDate]
            FROM [Commodity] WHERE commodityName = @commodity_name";
            SqlParameter[] paras =
           {
                new SqlParameter("@commodity_name", commodity_name),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品信息（商品类型，即数据库中的commodityType）
        /// </summary>
        /// <param name="commodity_type"></param>
        /// <returns></returns>
        public DataSet SearchCommodityByType(string commodity_type)
        {
            string sqlStr = @"SELECT [commodityID]
                ,[phoneNumber]
                ,[commodityName]
                ,[commodityDescription]
                ,[commodityType]
                ,[originalPrice]
                ,[estimatePrice]
                ,[commodityNumber]
                ,[degrees]
                ,[commodityImage1]
                ,[commodityImage2]
                ,[commodityImage3]
                ,[commodityNote]
                ,[launchDate]
            FROM [Commodity] WHERE commodityType = @commodity_type";
            SqlParameter[] paras =
           {
                new SqlParameter("@commodity_type", commodity_type),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品信息（商品编号，即数据库中的commodityNumber）
        /// </summary>
        /// <param name="commodity_number"></param>
        /// <returns></returns>
        public DataSet SearchCommodityByNumber(string commodity_number)
        {
            string sqlStr = @"SELECT [commodityID]
                ,[phoneNumber]
                ,[commodityName]
                ,[commodityDescription]
                ,[commodityType]
                ,[originalPrice]
                ,[estimatePrice]
                ,[commodityNumber]
                ,[degrees]
                ,[commodityImage1]
                ,[commodityImage2]
                ,[commodityImage3]
                ,[commodityNote]
                ,[launchDate]
            FROM [Commodity] WHERE commodityNumber = @commodity_number";
            SqlParameter[] paras =
           {
                new SqlParameter("@commodity_number", commodity_number),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 修改商品数据
        /// </summary>
        /// <param name="commodity"></param>
        /// <returns></returns>
        public int EditCommodityInfo(Entity.Commodity commodity)
        {
            string sqlStr = @"UPDATE [Commodity]
                 SET [commodityID] = @commodityID
                ,[phoneNumber] = @phoneNumber
                ,[commodityName] = @commodityName
                ,[commodityDescription] = @commodityDescription
                ,[commodityType] = @commodityType
                ,[originalPrice] = @originalPrice
                ,[estimatePrice] = @estimatePrice
                ,[commodityNumber] = @commodityNumber
                ,[degrees] = @degrees
                ,[commodityImage1] = @commodityImage1
                ,[commodityImage2] = @commodityImage2
                ,[commodityImage3] = @commodityImage3
                ,[commodityNote] = @commodityNote
                ,[launchDate] = @launchDate
            WHERE commodityID = @commodityID";
            SqlParameter[] paras =
          {
                new SqlParameter("@commodityID", commodity.CommodityId),
                new SqlParameter("@phoneNumber", commodity.UserId),
                new SqlParameter("@commodityName", commodity.CommodityName),
                new SqlParameter("@commodityDescription", commodity.CommodityDescription),
                new SqlParameter("@commodityType", commodity.CommodityType),
                new SqlParameter("@originalPrice", commodity.OriginalPrice),
                new SqlParameter("@estimatePrice", commodity.EstimateMoney),
                new SqlParameter("@commodityNumber", commodity.CommodityNumber),
                new SqlParameter("@degrees", commodity.Degress),
                new SqlParameter("@commodityImage1", commodity.CommodityImage1),
                new SqlParameter("@commodityImage2", commodity.CommodityImage2),
                new SqlParameter("@commodityImage3", commodity.CommodityImage3),
                new SqlParameter("@commodityNote", commodity.CommodityNote),
                new SqlParameter("@launchDate", commodity.LaunchDate),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="commodity_id"></param>
        /// <returns></returns>
        public int DeleCommodity(string commodity_id)
        {
            string sqlStr = @"DELETE FROM [Commodity]
                    WHERE commodityID = @commodity_id";
            SqlParameter[] paras =
            {
                new SqlParameter("@commodity_id", commodity_id)
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

    }
}
