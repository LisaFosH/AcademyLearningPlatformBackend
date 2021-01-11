using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyProsjekt.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class ApiAspNetUsersController : Controller
	{
		public JsonResult Index()
		{
            return new JsonResult (new { username = User.Identity.Name});
		}
        
    }
}
