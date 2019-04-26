using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlogNew.Data;
using MyBlogNew.Models;

namespace MyBlogNew.Server.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class TagController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult GetTags()
        {
            var list = DataBase.QueryAllTags();
            return Json(list);
        }
        [HttpPut("[action]")]
        public IActionResult GetInfo([FromBody]string tagName)
        {
            var list = DataBase.QuerySummaryByTag(tagName);
            return Json(list);
        }
    }
}