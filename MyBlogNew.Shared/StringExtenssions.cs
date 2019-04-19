using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace MyBlogNew.Shared
{
    public static class StringExtenssions
    {
        public static string UrlEncode(this string content)
        {
            var str = HttpUtility.UrlEncode(content);
            str = str.Replace("#", "%23");
            return str;
        }

        public static string UrlDecode(this string content)
        {
            var str = HttpUtility.UrlDecode(content);
            return str;
        }
    }
}
