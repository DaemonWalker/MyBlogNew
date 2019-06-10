using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogNew.Shared
{
    public class HttpContextAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public HttpContextAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public HttpContext Context => _httpContextAccessor.HttpContext;
    }
}
