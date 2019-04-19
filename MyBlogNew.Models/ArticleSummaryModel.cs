using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MyBlogNew.Models
{
    [DataContract]
    public class ArticleSummaryModel
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public List<string> Tags { get; set; }

        [DataMember]
        public string Href { get; set; }
    }
}
