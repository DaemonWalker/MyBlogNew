using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyBlogNew.Data;
using MyBlogNew.Models;
using MyBlogNew.Shared;

namespace MyBlogNew.Server.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult GetArcitalTitles(SortType sortType)
        {
            var list = DataBase.QueryLastestSixArticles();
            return new JsonResult(list);
        }

        [HttpGet("[action]")]
        public IActionResult GetShareWays()
        {
            var list = Config.Configuration.GetSection("ShareModels").Get<List<Models.ShareModel>>();
            return Json(list);
        }
    }
}