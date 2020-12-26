using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ALE.TimeRegistration.Web.Controllers
{
    //[Authorize(Policy = "RequireAdmin")]
    public class AdminsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
