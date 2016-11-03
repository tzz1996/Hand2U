using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Commodity
    {
        public string CommodityId
        {
            get;
            set;
        }
        public string UserId
        {
            get;
            set;
        }
        public string CommomdityDescription
        {
            get;
            set;    
        }
        public int CommomdityType
        {
            get;
            set;
        }

        public SqlMoney OriginalPrice
        {
            get; set; }

        public SqlMoney EstimateMoney
        {
            get; set; }

        public int CommodityNumber
        {
            get; set; }

        public int Degress
        {
            get; set; }

        public SqlBytes CommodityImage1
        {
            get; set; }
        public SqlBytes CommodityImage2
        {
            get; set; }
        public SqlBytes CommodityImage3
        {
            get; set; }

        public string CommodityNote
        {
            get; set; }

        public DateTime LaunchDate
        {
            get; set; }
    }
}
