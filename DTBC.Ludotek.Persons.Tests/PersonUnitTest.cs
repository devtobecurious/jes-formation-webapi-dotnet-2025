using DTBC.Ludotek.Core.Persons.Application;
using DTBC.Ludotek.Core.Persons.Application.Queries;
using DTBC.Ludotek.Core.Persons.Domains;
using DTBC.Ludotek.Core.Persons.Infrastructure.Queries;
using Microsoft.Extensions.Options;
using Moq;

namespace DTBC.Ludotek.Persons.Tests
{
	public class PersonUnitTest
	{
		[Fact]
		public void ShouldReturnDefaultPerson()
		{
			// Arrange 
			//var mockGetDefaultP = new Mock<IGetDefaultPerson>();
			//mockGetDefaultP.Setup(item => item.Get()).Returns(new Person());

			var mockOptions = new Mock<IOptions<Person>>();
			mockOptions.Setup(item => item.Value).Returns(new Person());
			IGetDefaultPerson getDefaultPerson = new GetDefaultPersonFromOptions(mockOptions.Object);
			PersonsMachine personMachine = new(getDefaultPerson);
 
			// Act
			var result = personMachine.GetDefault();

			// Assert
			Assert.NotNull(result);
			Assert.IsType<Person>(result);
			Assert.True(string.IsNullOrEmpty(result.FirstName));

			mockOptions.VerifyAll();
		}
	}
}
