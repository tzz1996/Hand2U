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
        public string CommodityName
        {
            get;
            set;
        }
        public string CommodityDescription
        {
            get;
            set;    
        }
        public int CommodityType
        {
            get;
            set;
        }

        public decimal OriginalPrice
        {
            get; set; }

        public decimal EstimateMoney
        {
            get; set; }

        public int CommodityNumber
        {
            get; set; }

        public int Degress
        {
            get; set; }

        public byte[] CommodityImage1
        {
            get; set; }
        public byte[] CommodityImage2
        {
            get; set; }
        public byte[] CommodityImage3
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
