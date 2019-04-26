using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MyBlogNew.Models
{
    [DataContract]
    public class ShareModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Describe { get; set; }

        [DataMember]
        public string ImgPath { get; set; }

        [DataMember]
        public string Link { get; set; }
    }
}
