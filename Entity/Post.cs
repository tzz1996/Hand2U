using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Post
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

        public int IsReplyType
        {
            get; set; }

        public string PostId
        {
            get; set; }

        public string UserId
        {
            get; set; }

        public string PostNote
        {
            get; set; }
    }
}
