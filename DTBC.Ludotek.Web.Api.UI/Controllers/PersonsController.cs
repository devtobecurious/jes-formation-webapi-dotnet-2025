using DTBC.Ludotek.Core.Persons.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTBC.Ludotek.Web.Api.UI.Controllers
{
	[Route("api/[controller]")]
	public class PersonsController(PersonsMachine machine, IConfiguration configuration) : ControllerBase
	{
		[HttpGet("default")]
		public IActionResult GetDefault()
		{
			var person = machine.GetDefault();
			person.FirstName = configuration["DATABASE_PWD"]!;
			return this.Ok(person);
		}

		[HttpGet()]
		public IActionResult Get()
		{
			return this.Ok(new List<string>());
		}
	}
}
