using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TradeInfo
    {
        public int RecordId
        {
            get; set; }

        public string CommmdityId
        {
            get; set; }

        public string SellerId
        {
            get; set; }

        public string BuyerId
        {
            get; set; }

        public Boolean IsDeal
        {
            get; set; }

        public SqlMoney DealMoney
        {
            get; set; }

        public SqlMoney CutMoney
        {
            get; set;}

        public DateTime TradeDate
        {
            get; set; }

        public string TradeNote
        {
            get; set; }
    }
}
