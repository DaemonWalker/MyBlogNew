using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlogNew.Models;

namespace MyBlogNew.Server.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult GetArcitalTitles(SortType sortType)
        {
            var list = new List<ArticleSummaryModel>()
            {
                new ArticleSummaryModel(){Title="第一篇博文",Href="/Artical.html?ID=1"},
                new ArticleSummaryModel(){Title="第二篇文章",Href="/Artical.html?ID=1"}
            };
            return new JsonResult(list);
        }
    }
}