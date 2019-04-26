using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlogNew.Data;

namespace MyBlogNew.Server.Controllers
{
    [Route("/api/{controller}")]
    [ApiController]
    public class ArticleController : Controller
    {
        [HttpPost("[action]")]
        [HttpGet("[action]/{name}")]
        public IActionResult GetArticle([FromBody]string name)
        {
            var article = DataBase.QueryArticleByTitleEn(name);
            return Json(article);
        }

        [HttpGet("[action]")]
        [HttpGet("[action]/{name}")]
        public IActionResult GetArticle2(string name)
        {
            var article = DataBase.QueryArticleByTitleEn(name);
            return Json(article);
        }
    }
}