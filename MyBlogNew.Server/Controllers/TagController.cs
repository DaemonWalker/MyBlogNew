using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogNew.Models;

namespace MyBlogNew.Server.Controllers
{
    [Route("/api/[controller]")]
    public class TagController : Controller
    {
        [HttpGet("[action]")]
        [HttpGet("")]
        public IActionResult GetTags()
        {
            var list = new List<TagModel>()
            {
                new TagModel(){Name="C#"},
                new TagModel(){Name="Web"},
                new TagModel(){Name=".Net Core"}
            };
            return Json(list);
        }
        [HttpPut("[action]")]
        [HttpGet("[action]")]
        public IActionResult GetInfo(string tagName)
        {
            var list = new List<ArticleSummaryModel>()
            {
                new ArticleSummaryModel()
                {
                    Title = "使用Blazor构建网站",
                    Date = new DateTime(2019,4,1),
                    Summary = "简要描述Blazor功能",
                    Tags = new List<string>(){"C#","Web","Blazor" },
                    Href = ""
                },
                new ArticleSummaryModel()
                {
                    Title = ".Net Core瞎玩",
                    Date = new DateTime(2019,3,1),
                    Summary = "初次接触.Net Core",
                    Tags = new List<string>(){"C#",".Net Core" },
                    Href = ""
                }
            };
            return Json(list);
        }
    }
}