using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using unity_getting_started.Services.Contracts;

namespace unity_getting_started.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController(IFooService fooService)
        {
            this.fooService = fooService;
        }
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Title = fooService.Foo();
            return View();
        }

        protected readonly IFooService fooService;
    }
}