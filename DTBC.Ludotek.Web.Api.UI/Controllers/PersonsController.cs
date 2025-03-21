using DTBC.Ludotek.Core.Persons.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTBC.Ludotek.Web.Api.UI.Controllers
{
	[Route("api/[controller]")]
	public class PersonsController(PersonsMachine machine) : ControllerBase
	{
		[HttpGet("default")]
		public IActionResult GetDefault()
		{
			return this.Ok(machine.GetDefault());
		}

		[HttpGet()]
		public IActionResult Get()
		{
			return this.Ok(new List<string>());
		}
	}
}
