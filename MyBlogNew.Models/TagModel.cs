using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MyBlogNew.Models
{
    [DataContract]
    public class TagModel
    {
        [DataMember]
        public string Name { get; set; }
    }
}
