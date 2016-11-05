using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManage
{
    class TradeInfoManage
    {
        /// <summary>
        /// 添加商品交易信息
        /// </summary>
        /// <param name="trade_info"></param>
        /// <returns></returns>
        public int AddTradeInfo(Entity.TradeInfo trade_info)
        {
            string sqlStr = @"INSERT INTO [TradeInfo]
            ([recordID]
            ,[commodityID]
            ,[sellerID]
            ,[buyerID]
            ,[isDeal]
            ,[dealPrice]
            ,[cut]
            ,[tradeDate]
            ,[tradeNote])
    VALUES
            (
            @recordID
            ,@commodityID
            ,@sellerID
            ,@buyerID
            ,@isDeal
            ,@dealPrice
            ,@cut
            ,@tradeDate
            ,@tradeNote)";
            SqlParameter[] paras =
            {
                new SqlParameter("@recordID", trade_info.RecordId),
                new SqlParameter("@commodityID", trade_info.CommmdityId),
                new SqlParameter("@sellerID", trade_info.SellerId),
                new SqlParameter("@buyerID", trade_info.BuyerId),
                new SqlParameter("@isDeal", trade_info.IsDeal),
                new SqlParameter("@dealPrice", trade_info.DealMoney),
                new SqlParameter("@cut", trade_info.CutMoney),
                new SqlParameter("@tradeDate",trade_info.TradeDate),
                new SqlParameter("@tradeNote", trade_info.TradeNote),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品交易信息（通过记录ID查找，ID即数据库中的recordID）
        /// </summary>
        /// <param name="trade_info_id"></param>
        /// <returns></returns>
        public DataSet SearchTradeInfo(int trade_info_id)
        {
            string sqlStr = @"SELECT [commodityID]
                ,[sellerID]
                ,[buyerID]
                ,[isDeal]
                ,[dealPrice]
                ,[cut]
                ,[tradeDate]
                ,[tradeNote]   
            FROM [TradeInfo] where recordID = @trade_info_id";
            SqlParameter[] paras =
            {
                new SqlParameter("@trade_info_id", trade_info_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品交易信息（通过商品ID查找，即数据库中的commodityID）
        /// </summary>
        /// <param name="commodity_id"></param>
        /// <returns></returns>
        public DataSet SearchTradeInfo(string commodity_id)
        {
            string sqlStr = @"SELECT [recordID]
                ,[commodityID]
                ,[sellerID]
                ,[buyerID]
                ,[isDeal]
                ,[dealPrice]
                ,[cut]
                ,[tradeDate]
                ,[tradeNote]   
            FROM [TradeInfo] where commodityID = @commodity_id";
            SqlParameter[] paras =
            {
                new SqlParameter("@commodity_id", commodity_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        ///<summary>
        ///查询商品交易信息（通过recordID和commodityID查找）
        ///</summary>
        ///<param name="record_id"></param>
        ///<param name="commodity_id"></param>
        ///<returns></returns>
        public DataSet SearchTradeInfo(int record_id, string commodity_id)
        {
            string sqlStr = @"SELECT [recordID]
                ,[commodityID]
                ,[sellerID]
                ,[buyerID]
                ,[isDeal]
                ,[dealPrice]
                ,[cut]
                ,[tradeDate]
                ,[tradeNote]   
            FROM [TradeInfo] where recordID = @record_id and commodityID = @commodity_id";
            SqlParameter[] paras =
            {
                new SqlParameter("@record_id", record_id),
                new SqlParameter("@commodity_id", commodity_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 查询商品交易信息（通过卖家ID&买家ID查找；卖家ID，即数据库中的sellerID；买家ID，即数据库中的buyerID）
        /// </summary>
        /// <param name="seller_id"></param>
        /// <param name="buyer_id"></param>
        /// <returns></returns>
        public DataSet SearchTradeInfo(string seller_id, string buyer_id)
        {
            string sqlStr = @"SELECT [recordID]
                ,[commodityID]
                ,[sellerID]
                ,[buyerID]
                ,[isDeal]
                ,[dealPrice]
                ,[cut]
                ,[tradeDate]
                ,[tradeNote]   
            FROM [TradeInfo] where sellerID = @seller_id and buyerID = @buyer_id";
            SqlParameter[] paras =
            {
                new SqlParameter("@seller_id", seller_id),
                new SqlParameter("@buyer_id", buyer_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.Search(sqlStr, paras);
        }

        /// <summary>
        /// 修改交易信息数据
        /// </summary>
        /// <param name="trade_info"></param>
        /// <returns></returns>
        public int EditTradeInfo(Entity.TradeInfo trade_info)
        {
            string sqlStr = @"UPDATE [TradeInfo]
                SET [commodityID] = @commodityID
                    ,[sellerID] = @sellerID
                    ,[buyerID] = @buyerID
                    ,[isDeal] = @isDeal
                    ,[dealPrice] = @dealPrice
                    ,[cut] = @cut
                    ,[tradeDate] = @tradeDate
                    ,[tradeNote] = @tradeNote
                WHERE recordID = @recordID";
            SqlParameter[] paras =
            {
                new SqlParameter("@recordID", trade_info.RecordId),
                new SqlParameter("@commodityID", trade_info.CommmdityId),
                new SqlParameter("@sellerID", trade_info.SellerId),
                new SqlParameter("@buyerID", trade_info.BuyerId),
                new SqlParameter("@isDeal", trade_info.IsDeal),
                new SqlParameter("@dealPrice", trade_info.DealMoney),
                new SqlParameter("@cut", trade_info.CutMoney),
                new SqlParameter("@tradeDate", trade_info.TradeDate),
                new SqlParameter("@tradeNote", trade_info.TradeNote),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

        /// <summary>
        /// 删除交易记录
        /// </summary>
        /// <param name="record_id"></param>
        /// <returns></returns>
        public int DeleTradeInfo(int record_id)
        {
            string sqlStr = @"DELETE FROM [TradeInfo]
                WHERE recordID = @record_id";
            SqlParameter[] paras =
            {
                new SqlParameter("@record_id", record_id),
            };
            var handler = new DAL.DatabaseHandler();
            return handler.ExeSql(sqlStr, paras);
        }

    }
}
