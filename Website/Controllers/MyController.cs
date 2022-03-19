using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Core.Cache;
using Umbraco.Core.Logging;
using Umbraco.Core.Persistence;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.Mvc;

namespace Website.Controllers
{
    public class MyController : SurfaceController
    {
        //public MyController(
        //    IUmbracoContextAccessor umbracoContextAccessor,
        //    IUmbracoDatabaseFactory databaseFactory,
        //    ServiceContext services,
        //    AppCaches appCaches)
        //    : base(umbracoContextAccessor, databaseFactory, services, appCaches)
        //{
        //}

        public IActionResult Index()
        {
            return (IActionResult)Content("Hello world");
        }
    }
}