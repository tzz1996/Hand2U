using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CommentPost
    {
        public string PostTitle
        {
            get; set; }

        public int PostType
        {
            get; set; }

        public string PostContent
        {
            get; set; }

        public DateTime PostDate
        {
            get; set; }
        /// <summary>
        /// 固定长度为10
        /// </summary>
        public string PostId
        {
            get; set;}
        /// <summary>
        /// 固定长度为13
        /// </summary>
        public string PostUserId
        {
            get; set; }
        /// <summary>
        /// 固定长度为10
        /// </summary>
        public string CommodityId
        {
            get; set; }

        public string PostNote
        {
            get; set; }
    }
}
