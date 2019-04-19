using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogNew.Shared
{
    public static class DateTimeExtenssion
    {
        private static string chineseNumber = @"零一二三四五六七八九十";
        public static string ToLoacalTimeString(this DateTime dateTime)
        {
            var sb = new StringBuilder();
            var month = dateTime.Month;
            sb.AppendFormat("{0}{1}月",
                month < 10 ? string.Empty : chineseNumber[10].ToString(),
                month % 10 == 0 ? string.Empty : chineseNumber[month % 10].ToString());
            sb.AppendFormat(" {0}日,{1}", dateTime.Day, dateTime.Year);
            return sb.ToString();
        }
    }
}
