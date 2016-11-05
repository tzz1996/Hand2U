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
    }
}
