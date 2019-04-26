using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlogNew.Server.Controllers
{
    public class FileController : Controller
    {
        public IActionResult DownloadCode()
        {
            return File("/resources/MyBlogNew-master.zip", "application/x-zip-compressed", "MyBlogNew-master.zip", true);
        }
    }
}