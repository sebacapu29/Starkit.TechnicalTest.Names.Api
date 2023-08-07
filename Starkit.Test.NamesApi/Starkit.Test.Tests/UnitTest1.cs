using App.Controllers;
using Moq;
using Starkit.Test.Application.DTOs.Requests;
using Starkit.Test.Application.DTOs.Responses;
using Starkit.Test.Application.Gateways;
using Starkit.Test.Application.Interfaces;
using Starkit.Test.Application.Services;
using Starkit.Test.Application.ServicesMock;
using Starkit.Test.Domain;

namespace Starkit.Test.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Names_Should_Return_Filtered_List_Ok()
        {
            // Arrange
            var mockedName = new NameRequest { Gender = 'm', Name = "Adrian" };
            var mockedNameEntity = new NameEntity { Gender = 'm', Name = "Adrian" };
            IEnumerable<NameEntity> mockedContext = new List<NameEntity> { mockedNameEntity };
            var gateWayMock = new Mock<INameGateway>();
            gateWayMock.Setup(gateway => gateway.GetContext()).ReturnsAsync(mockedContext);

            // Use the mocked service instance
            var objNameService = new NameService(gateWayMock.Object);

            //Act
            var obj = await objNameService.GetNames(mockedName);

            // Assert
            Assert.AreEqual(mockedName.Name, obj.FirstOrDefault().Name);
        }
    }
}