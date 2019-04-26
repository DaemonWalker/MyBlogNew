using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogNew.Shared
{
    public class Config
    {
        public static IConfiguration Configuration { get; set; }
    }
}
